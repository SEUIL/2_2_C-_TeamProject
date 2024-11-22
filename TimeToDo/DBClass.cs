using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        private DataSet dS;// DataSet 객체입니다.
        private OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체
        private OracleConnection connection;
        string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
        
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }
        public OracleConnection Connection { get { return connection; } }

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
        public void DB_Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("DBClass 연결 닫힘"); // 연결 닫힘 메시지 출력

            }
        }

    }
}