﻿namespace TimeToDo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack_Stinupform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSummit
            // 
            this.btnSummit.Location = new System.Drawing.Point(165, 263);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(91, 36);
            this.btnSummit.TabIndex = 12;
            this.btnSummit.Text = "확인";
            this.btnSummit.UseVisualStyleBackColor = true;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 21);
            this.txtPassword.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 21);
            this.txtId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원가입";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 21);
            this.txtEmail.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(36, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "이메일";
            // 
            // btnBack_Stinupform
            // 
            this.btnBack_Stinupform.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btnBack_Stinupform.Location = new System.Drawing.Point(68, 263);
            this.btnBack_Stinupform.Name = "btnBack_Stinupform";
            this.btnBack_Stinupform.Size = new System.Drawing.Size(91, 36);
            this.btnBack_Stinupform.TabIndex = 15;
            this.btnBack_Stinupform.Text = "돌아가기";
            this.btnBack_Stinupform.UseVisualStyleBackColor = true;
            this.btnBack_Stinupform.Click += new System.EventHandler(this.btnBack_Stinupform_Click);
            // 
            // SignUpForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 330);
            this.Controls.Add(this.btnBack_Stinupform);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSummit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm1";
            this.Text = "SignUpForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSummit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack_Stinupform;
    }
}