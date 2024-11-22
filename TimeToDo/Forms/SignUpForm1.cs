using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeToDo
{
    public partial class SignUpForm1 : Form
    {
        private DBClass db;

        public SignUpForm1()
        {
            InitializeComponent();
            db = new DBClass();
        }

        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            string userId = txtId.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("모든 필드를 입력해 주세요.");
                return;
            }

            /*try 
            {
                // 1. INSERT 쿼리 작성
                string insertQuery = "INSERT INTO Users (USERID, PASSWORD, EMAIL) VALUES (:userId, :password, :email)";

                // 2. 매개변수 설정
                var parameters = new Dictionary<string, object>
                {
                    { ":userId", userId },
                    { ":password", password },
                    { ":email", email }
                };

                // 3. DBClass를 사용하여 쿼리 실행
                db.DB_Open(insertQuery, parameters);

                // 4. 성공 메시지
                MessageBox.Show("회원가입이 완료되었습니다.");
                ClearTextBoxes();

                // 회원가입 완료 후 LoginForm1으로 이동
                LoginForm1 loginForm = new LoginForm1();
                loginForm.Show();
                this.Close(); // 현재 창 닫기
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }*/
            try
            {
                string insertQuery = "INSERT INTO Users (USERID, PASSWORD, EMAIL) VALUES (:userId, :password, :email)";
                var parameters = new Dictionary<string, object>
                {
                    { ":userId", userId },
                    { ":password", password },
                    { ":email", email }
                };

                int rowsAffected = db.ExecuteNonQuery(insertQuery, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    ClearTextBoxes();

                    LoginForm1 loginForm = new LoginForm1();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("회원가입에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                db.DB_Close();
            }
        }
    }
}
