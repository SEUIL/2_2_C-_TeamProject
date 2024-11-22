namespace TimeToDo
{
    partial class LoginForm1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.summit_loginPage = new System.Windows.Forms.Button();
            this.signUp_loginPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(161, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(62, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(62, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(167, 97);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(141, 21);
            this.txtUserId.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 21);
            this.txtPassword.TabIndex = 4;
            // 
            // summit_loginPage
            // 
            this.summit_loginPage.Location = new System.Drawing.Point(99, 231);
            this.summit_loginPage.Name = "summit_loginPage";
            this.summit_loginPage.Size = new System.Drawing.Size(168, 36);
            this.summit_loginPage.TabIndex = 5;
            this.summit_loginPage.Text = "확인";
            this.summit_loginPage.UseVisualStyleBackColor = true;
            this.summit_loginPage.Click += new System.EventHandler(this.summit_loginPage_Click);
            // 
            // signUp_loginPage
            // 
            this.signUp_loginPage.Location = new System.Drawing.Point(273, 231);
            this.signUp_loginPage.Name = "signUp_loginPage";
            this.signUp_loginPage.Size = new System.Drawing.Size(82, 36);
            this.signUp_loginPage.TabIndex = 6;
            this.signUp_loginPage.Text = "회원가입";
            this.signUp_loginPage.UseVisualStyleBackColor = true;
            this.signUp_loginPage.Click += new System.EventHandler(this.signUp_loginPage_Click);
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 338);
            this.Controls.Add(this.signUp_loginPage);
            this.Controls.Add(this.summit_loginPage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm1";
            this.Text = "LoginForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button summit_loginPage;
        private System.Windows.Forms.Button signUp_loginPage;
    }
}

