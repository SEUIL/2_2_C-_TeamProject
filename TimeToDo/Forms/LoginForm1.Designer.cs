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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.summit_loginPage = new System.Windows.Forms.Button();
            this.signUp_loginPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans KR Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.Location = new System.Drawing.Point(97, 96);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(182, 29);
            this.txtUserId.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassword.Location = new System.Drawing.Point(97, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // summit_loginPage
            // 
            this.summit_loginPage.BackColor = System.Drawing.Color.DarkGray;
            this.summit_loginPage.Font = new System.Drawing.Font("Noto Sans KR ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.summit_loginPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.summit_loginPage.Location = new System.Drawing.Point(32, 210);
            this.summit_loginPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.summit_loginPage.Name = "summit_loginPage";
            this.summit_loginPage.Size = new System.Drawing.Size(176, 48);
            this.summit_loginPage.TabIndex = 5;
            this.summit_loginPage.Text = "확인";
            this.summit_loginPage.UseVisualStyleBackColor = false;
            this.summit_loginPage.Click += new System.EventHandler(this.summit_loginPage_Click);
            // 
            // signUp_loginPage
            // 
            this.signUp_loginPage.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.signUp_loginPage.Location = new System.Drawing.Point(214, 210);
            this.signUp_loginPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUp_loginPage.Name = "signUp_loginPage";
            this.signUp_loginPage.Size = new System.Drawing.Size(78, 48);
            this.signUp_loginPage.TabIndex = 6;
            this.signUp_loginPage.Text = "회원가입";
            this.signUp_loginPage.UseVisualStyleBackColor = true;
            this.signUp_loginPage.Click += new System.EventHandler(this.signUp_loginPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "PW";
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUp_loginPage);
            this.Controls.Add(this.summit_loginPage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button summit_loginPage;
        private System.Windows.Forms.Button signUp_loginPage;
        private System.Windows.Forms.Label label1;
    }
}

