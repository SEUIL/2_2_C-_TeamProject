using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TimeToDo
{
    public partial class LoginForm1 : Form
    {
        private DBClass db;

        public LoginForm1()
        {
            InitializeComponent();
            db = new DBClass();  // DBClass 객체 초기화
        }

        private void ClearTextBoxes()
        {
            txtUserId.Clear();
            txtPassword.Clear();
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
            /*if (userId.Equals("1234") && password.Equals("1234"))
            {
                return isValidUser=true;
            }*/

            try
            {
                // 매개변수를 사용한 쿼리
                string query = "SELECT COUNT(*) FROM Users WHERE USERID = :userId AND PASSWORD = :password";

                // 매개변수를 딕셔너리로 설정
                var parameters = new Dictionary<string, object>
                {
                    { "userId", userId },
                    { "password", password }
                };

                // DBClass의 DB_Open 메서드를 호출하여 DataSet을 반환받음
                DataSet userDataSet = db.DB_Open(query, parameters);

                // 결과가 존재하는지 확인 (COUNT(*) 결과가 1 이상이면 해당 사용자가 존재)
                if (userDataSet.Tables[0].Rows.Count > 0 && Convert.ToInt32(userDataSet.Tables[0].Rows[0][0]) > 0)
                {
                    isValidUser = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoginForm1 오류 발생: " + ex.Message);
            }
            finally
            {
                db.DB_Close(); // 연결을 닫습니다.
            }

            return isValidUser;
        }

        private void signUp_loginPage_Click(object sender, EventArgs e)
        {
            // SignUpForm1으로 이동
            SignUpForm1 signUpForm = new SignUpForm1();
            signUpForm.Show();
            this.Hide(); // LoginForm1을 숨김
        }
    }
}


/*private bool ValidateUser(string userId, string password)
{
bool isValidUser = false;
if (userId.Equals("1234") && password.Equals("1234"))
{
    isValidUser = true;
    return isValidUser;
} //계속 오류나서 일단 로그인 하드코딩

try
{
    // 대소문자를 무시하고 비교하기 위해 UPPER() 함수 사용
    string query = "SELECT * FROM Users WHERE USERID = :userId AND PASSWORD = :password";

    using (OracleCommand command = new OracleCommand(query, db.Connection))
    {
        // 매개변수 설정
        command.Parameters.Add("userId", OracleDbType.Varchar2, 50).Value = userId;
        command.Parameters.Add("password", OracleDbType.Varchar2, 50).Value = password;

        // 연결이 닫혀 있는 경우에만 엽니다.
        if (db.Connection.State == ConnectionState.Closed)
        {
            db.Connection.Open();
        }

        using (OracleDataReader reader = command.ExecuteReader())
        {
            // 결과가 있으면 해당 사용자 정보가 존재한다는 뜻
            if (reader.Read())
            {
                isValidUser = true;
            }
        }
    }
}
catch (Exception ex)
{
    MessageBox.Show("LoginForm1 오류 발생: " + ex.Message);
}
finally
{
    if (db.Connection.State == ConnectionState.Open)
    {
        db.Connection.Close();
    }
}
return isValidUser;
}*/
