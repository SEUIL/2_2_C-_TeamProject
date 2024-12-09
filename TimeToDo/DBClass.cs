using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToDo
{
    internal class DBClass
    {
        private OracleDataAdapter dBAdapter; // Data Provider인 DBAdapter 입니다.
        private DataSet dS; // DataSet 객체입니다.
        private OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체
        private OracleConnection connection;
        string connectionString = "User Id=Calendar; Password=1234; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";

        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
        public OracleConnection Connection { get { return connection; } }

        // DataSet을 반환하는 메서드 (SELECT)
        public DataSet DB_Open(string query, Dictionary<string, object> parameters = null)
        {
            DataSet resultDataSet = new DataSet(); // 반환할 DataSet을 생성

            try
            {
                if (connection == null)
                {
                    connection = new OracleConnection(connectionString);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                dBAdapter = new OracleDataAdapter(query, connection);

                // 매개변수 설정
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        dBAdapter.SelectCommand.Parameters.Add(new OracleParameter(param.Key, param.Value));
                    }
                }

                dBAdapter.Fill(resultDataSet); // 지정된 쿼리에 따라 DataSet을 채웁니다.
            }
            catch (Exception ex)
            {
                MessageBox.Show("DBClass 연결 오류: " + ex.Message);
            }
            finally
            {
                DB_Close();
            }

            return resultDataSet; // 채워진 DataSet 반환
        }

        // ExecuteNonQuery 메서드 (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int rowsAffected = 0; // 영향받은 행의 수를 반환할 변수

            try
            {
                if (connection == null)
                {
                    connection = new OracleConnection(connectionString);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    // 매개변수 추가
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new OracleParameter(param.Key, param.Value));
                        }
                    }

                    rowsAffected = command.ExecuteNonQuery(); // 쿼리 실행
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DBClass ExecuteNonQuery 오류: " + ex.Message);
            }
            finally
            {
                DB_Close();
            }

            return rowsAffected; // 영향받은 행의 수 반환
        }
        public int ExecuteNonQueryWithReturn(string query, Dictionary<string, object> parameters)
        {
            int insertedId = -1;

            try
            {
                if (connection == null)
                {
                    connection = new OracleConnection(connectionString);
                }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    // 입력 매개변수 추가
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new OracleParameter(param.Key, param.Value));
                        }
                    }

                    // 반환 값 처리
                    OracleParameter outputParam = new OracleParameter(":InsertedID", OracleDbType.Decimal)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    // 쿼리 실행
                    command.ExecuteNonQuery();

                    // 반환된 ID 가져오기 (OracleDecimal을 Int32로 변환)
                    OracleDecimal oracleDecimal = (OracleDecimal)outputParam.Value;
                    insertedId = oracleDecimal.ToInt32();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DBClass 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB_Close();
            }

            return insertedId;
        }
        public int ExecuteNonQueryWithReturn2(string query, Dictionary<string, object> parameters)
        {
            int resultId = 0;

            try
            {
                if (connection == null)
                {
                    connection = new OracleConnection(connectionString);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new OracleParameter(param.Key, param.Value));
                        }
                    }

                    // Output parameter for ID
                    OracleParameter outputParam = new OracleParameter(":InsertedID", OracleDbType.Int32);
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    // Get the inserted ID
                    resultId = Convert.ToInt32(outputParam.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return resultId;
        }




        // 연결 닫기 메서드
        public void DB_Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                // 연결 닫힘 메시지 출력 (필요시 활성화)
                // MessageBox.Show("DBClass 연결 닫힘");
            }
        }


        // 데이터 가져오기 (SearchForm1에서 쓰이는 메서드)
        public DataTable GetSearchResults(string userId, string searchKeyword, DateTime startDate, DateTime endDate)
        {
            // 결과를 담을 DataTable
            DataTable table = new DataTable();

            // 데이터베이스 쿼리 수정
            string query = @"
                SELECT category, time, description, repeats
                FROM Calendar
                WHERE USERSID = :userId
                AND description LIKE :searchKeyword
                AND time BETWEEN TO_DATE(:startDate, 'YYYY-MM-DD HH24:MI:SS') 
                             AND TO_DATE(:endDate, 'YYYY-MM-DD HH24:MI:SS')";

            try
            {
                // OracleConnection을 사용
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // 매개변수 추가
                        command.Parameters.Add(new OracleParameter(":userId", OracleDbType.Varchar2) { Value = userId });
                        command.Parameters.Add(new OracleParameter(":searchKeyword", OracleDbType.Varchar2) { Value = $"%{searchKeyword}%" });
                        command.Parameters.Add(new OracleParameter(":startDate", OracleDbType.Varchar2)
                        {
                            Value = startDate.ToString("yyyy-MM-dd HH:mm:ss")
                        });
                        command.Parameters.Add(new OracleParameter(":endDate", OracleDbType.Varchar2)
                        {
                            Value = endDate.ToString("yyyy-MM-dd HH:mm:ss")
                        });

                        // 데이터 어댑터를 사용하여 결과 채우기
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DBClass GetSearchResults 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

       

    }

}
