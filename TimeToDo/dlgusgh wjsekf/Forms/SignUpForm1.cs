using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

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

            try
            {
                string insertQuery = "INSERT INTO Users (USERID, PASSWORD, EMAIL) VALUES (:userId, :password, :email)";
                db.DB_Open(insertQuery);

                using (OracleCommand command = new OracleCommand(insertQuery, db.Connection))
                {
                    command.Parameters.Add("userId", OracleDbType.Varchar2).Value = userId;
                    command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                    command.Parameters.Add("email", OracleDbType.Varchar2).Value = email;

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다.");
                        ClearTextBoxes();

                        // 회원가입 완료 후 LoginForm1으로 이동
                        LoginForm1 loginForm = new LoginForm1();
                        loginForm.Show();
                        this.Close(); // 현재 창 닫기
                    }
                    else
                    {
                        MessageBox.Show("회원가입에 실패했습니다. 다시 시도해 주세요.");
                    }
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
