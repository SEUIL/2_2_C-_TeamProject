﻿namespace TimeToDo.Forms
{
    partial class editForm1
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
            this.comboCategory_editForm = new System.Windows.Forms.ComboBox();
            this.btnSummit_addForm = new System.Windows.Forms.Button();
            this.date_editForm = new System.Windows.Forms.DateTimePicker();
            this.txtDescription_editForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboRepeats_editForm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboCategory_editForm
            // 
            this.comboCategory_editForm.FormattingEnabled = true;
            this.comboCategory_editForm.Items.AddRange(new object[] {
            "공적 일정",
            "사적 일정",
            "자기 개발",
            "취미 생활"});
            this.comboCategory_editForm.Location = new System.Drawing.Point(185, 119);
            this.comboCategory_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCategory_editForm.Name = "comboCategory_editForm";
            this.comboCategory_editForm.Size = new System.Drawing.Size(305, 23);
            this.comboCategory_editForm.TabIndex = 26;
            // 
            // btnSummit_addForm
            // 
            this.btnSummit_addForm.Location = new System.Drawing.Point(233, 329);
            this.btnSummit_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSummit_addForm.Name = "btnSummit_addForm";
            this.btnSummit_addForm.Size = new System.Drawing.Size(103, 46);
            this.btnSummit_addForm.TabIndex = 25;
            this.btnSummit_addForm.Text = "확인";
            this.btnSummit_addForm.UseVisualStyleBackColor = true;
            this.btnSummit_addForm.Click += new System.EventHandler(this.btnSummit_addForm_Click);
            // 
            // date_editForm
            // 
            this.date_editForm.Location = new System.Drawing.Point(185, 169);
            this.date_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_editForm.Name = "date_editForm";
            this.date_editForm.Size = new System.Drawing.Size(305, 25);
            this.date_editForm.TabIndex = 24;
            // 
            // txtDescription_editForm
            // 
            this.txtDescription_editForm.Location = new System.Drawing.Point(185, 216);
            this.txtDescription_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription_editForm.Name = "txtDescription_editForm";
            this.txtDescription_editForm.Size = new System.Drawing.Size(305, 25);
            this.txtDescription_editForm.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(65, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "일정 상세";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(65, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(65, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "카테고리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(1075, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "일정 편집";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(65, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "반복";
            // 
            // comboRepeats_editForm
            // 
            this.comboRepeats_editForm.FormattingEnabled = true;
            this.comboRepeats_editForm.Items.AddRange(new object[] {
            "반복없음",
            "매일",
            "매주",
            "매달",
            "매년"});
            this.comboRepeats_editForm.Location = new System.Drawing.Point(185, 272);
            this.comboRepeats_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboRepeats_editForm.Name = "comboRepeats_editForm";
            this.comboRepeats_editForm.Size = new System.Drawing.Size(305, 23);
            this.comboRepeats_editForm.TabIndex = 28;
            this.comboRepeats_editForm.Text = "매일";
            // 
            // editForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 735);
            this.Controls.Add(this.comboRepeats_editForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCategory_editForm);
            this.Controls.Add(this.btnSummit_addForm);
            this.Controls.Add(this.date_editForm);
            this.Controls.Add(this.txtDescription_editForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "editForm1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "editForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategory_editForm;
        private System.Windows.Forms.Button btnSummit_addForm;
        private System.Windows.Forms.DateTimePicker date_editForm;
        private System.Windows.Forms.TextBox txtDescription_editForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboRepeats_editForm;
    }
}