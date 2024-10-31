using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TimeToDo
{
    public partial class LoginForm1 : Form
    {
        private int SelectedRowIndex;
        private string connectionString = "User Id=test01; Password=clrchr91961; " +
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))(CONNECT_DATA=(SERVICE_NAME=xe)))";

        OracleDataAdapter DBAdapter; // Data Provider인 DBAdapter 입니다. 
        DataSet DS; // DataSet 객체입니다. 
        OracleCommandBuilder myCommandBuilder;

        public LoginForm1()
        {
            InitializeComponent();
            DB_Open();
            TestDBConnection();
        }

        private void ClearTextBoxes()
        {
            txtUserId.Clear();
            txtPassword.Clear();
        }

        private void DB_Open()
        {
            try
            {
                string commandString = "SELECT * FROM UserTable";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 연결 오류: " + ex.Message);
            }
        }

        private void summit_loginPage_Click(object sender, EventArgs e)
        {
            // 아이디와 비밀번호 가져오기
            string userId = txtUserId.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.");
                return;
            }

            // 로그인 검증 함수 호출
            if (ValidateUser(userId, password))
            {
                MessageBox.Show("로그인 성공!");
                // 로그인 성공 시 다음 화면으로 이동하거나 필요한 작업 수행
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
                ClearTextBoxes();
            }
        }

        private bool ValidateUser(string userId, string password)
        {
            bool isValidUser = false;

            try
            {
                // 올바른 테이블 및 컬럼 이름 사용
                string query = "SELECT COUNT(*) FROM USERTABLE WHERE USERID = :userId AND PASSWORD = :password";

                using (OracleConnection connection = new OracleConnection(connectionString))
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("userId", userId));
                    command.Parameters.Add(new OracleParameter("password", password));

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        isValidUser = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }

            return isValidUser;
        }

        private void TestDBConnection()
        {
            string connectionString = "User Id=test01; Password=clrchr91961; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))(CONNECT_DATA=(SERVICE_NAME=xe)))";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("데이터베이스 연결 성공!");
                    }
                    else
                    {
                        MessageBox.Show("데이터베이스 연결 실패!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("연결 오류: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


    }
}
