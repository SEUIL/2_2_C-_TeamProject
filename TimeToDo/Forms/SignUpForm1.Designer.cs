namespace TimeToDo
{
    partial class SignUpForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSummit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnBack_Stinupform = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSummit
            // 
            this.btnSummit.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSummit.Location = new System.Drawing.Point(218, 273);
            this.btnSummit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(104, 45);
            this.btnSummit.TabIndex = 12;
            this.btnSummit.Text = "확인";
            this.btnSummit.UseVisualStyleBackColor = true;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Noto Sans KR Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassword.Location = new System.Drawing.Point(161, 159);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 29);
            this.txtPassword.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Noto Sans KR Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtId.Location = new System.Drawing.Point(161, 107);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 29);
            this.txtId.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Noto Sans KR Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmail.Location = new System.Drawing.Point(161, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 29);
            this.txtEmail.TabIndex = 14;
            // 
            // btnBack_Stinupform
            // 
            this.btnBack_Stinupform.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btnBack_Stinupform.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack_Stinupform.Location = new System.Drawing.Point(53, 273);
            this.btnBack_Stinupform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack_Stinupform.Name = "btnBack_Stinupform";
            this.btnBack_Stinupform.Size = new System.Drawing.Size(159, 45);
            this.btnBack_Stinupform.TabIndex = 15;
            this.btnBack_Stinupform.Text = "로그인으로 돌아가기\r\n";
            this.btnBack_Stinupform.UseVisualStyleBackColor = true;
            this.btnBack_Stinupform.Click += new System.EventHandler(this.btnBack_Stinupform_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans KR Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(39, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "PW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans KR Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(39, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "email";
            // 
            // SignUpForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack_Stinupform);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSummit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUpForm1";
            this.Text = "회원가입";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm1_FormClosing);
            this.Load += new System.EventHandler(this.SignUpForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSummit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnBack_Stinupform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}