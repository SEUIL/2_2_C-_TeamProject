using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeToDo
{
    public partial class SignUpForm1 : MetroFramework.Forms.MetroForm
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

        private void SignUpForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
            this.Hide();
        }

        private void btnBack_Stinupform_Click(object sender, EventArgs e)
        {
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
            this.Hide();
        }

        private void SignUpForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
