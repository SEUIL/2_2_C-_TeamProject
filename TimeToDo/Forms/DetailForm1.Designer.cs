namespace TimeToDo.Forms
{
    partial class DetailForm1
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
            this.txtRepeats_detailForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCategory_detailForm = new System.Windows.Forms.ComboBox();
            this.btnClose_detailForm = new System.Windows.Forms.Button();
            this.date_detailForm = new System.Windows.Forms.DateTimePicker();
            this.txtDescription_detailForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete_detailForm = new System.Windows.Forms.Button();
            this.btnEdit_detailForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRepeats_detailForm
            // 
            this.txtRepeats_detailForm.Enabled = false;
            this.txtRepeats_detailForm.Location = new System.Drawing.Point(169, 262);
            this.txtRepeats_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepeats_detailForm.Name = "txtRepeats_detailForm";
            this.txtRepeats_detailForm.Size = new System.Drawing.Size(305, 25);
            this.txtRepeats_detailForm.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(49, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "반복";
            // 
            // comboCategory_detailForm
            // 
            this.comboCategory_detailForm.Enabled = false;
            this.comboCategory_detailForm.FormattingEnabled = true;
            this.comboCategory_detailForm.Items.AddRange(new object[] {
            "공적 일정",
            "사적 일정",
            "자기 개발",
            "취미 생활"});
            this.comboCategory_detailForm.Location = new System.Drawing.Point(169, 110);
            this.comboCategory_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCategory_detailForm.Name = "comboCategory_detailForm";
            this.comboCategory_detailForm.Size = new System.Drawing.Size(305, 23);
            this.comboCategory_detailForm.TabIndex = 36;
            // 
            // btnClose_detailForm
            // 
            this.btnClose_detailForm.Location = new System.Drawing.Point(9, 366);
            this.btnClose_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose_detailForm.Name = "btnClose_detailForm";
            this.btnClose_detailForm.Size = new System.Drawing.Size(103, 46);
            this.btnClose_detailForm.TabIndex = 35;
            this.btnClose_detailForm.Text = "돌아가기";
            this.btnClose_detailForm.UseVisualStyleBackColor = true;
            this.btnClose_detailForm.Click += new System.EventHandler(this.btnClose_detailForm_Click);
            // 
            // date_detailForm
            // 
            this.date_detailForm.Enabled = false;
            this.date_detailForm.Location = new System.Drawing.Point(169, 160);
            this.date_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_detailForm.Name = "date_detailForm";
            this.date_detailForm.Size = new System.Drawing.Size(305, 25);
            this.date_detailForm.TabIndex = 34;
            // 
            // txtDescription_detailForm
            // 
            this.txtDescription_detailForm.Enabled = false;
            this.txtDescription_detailForm.Location = new System.Drawing.Point(169, 208);
            this.txtDescription_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription_detailForm.Name = "txtDescription_detailForm";
            this.txtDescription_detailForm.Size = new System.Drawing.Size(305, 25);
            this.txtDescription_detailForm.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(49, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "일정 상세";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(49, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "카테고리";
            // 
            // btnDelete_detailForm
            // 
            this.btnDelete_detailForm.Location = new System.Drawing.Point(265, 366);
            this.btnDelete_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete_detailForm.Name = "btnDelete_detailForm";
            this.btnDelete_detailForm.Size = new System.Drawing.Size(103, 46);
            this.btnDelete_detailForm.TabIndex = 39;
            this.btnDelete_detailForm.Text = "삭제";
            this.btnDelete_detailForm.UseVisualStyleBackColor = true;
            this.btnDelete_detailForm.Click += new System.EventHandler(this.btnDelete_detailForm_Click);
            // 
            // btnEdit_detailForm
            // 
            this.btnEdit_detailForm.Location = new System.Drawing.Point(386, 366);
            this.btnEdit_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit_detailForm.Name = "btnEdit_detailForm";
            this.btnEdit_detailForm.Size = new System.Drawing.Size(103, 46);
            this.btnEdit_detailForm.TabIndex = 40;
            this.btnEdit_detailForm.Text = "수정";
            this.btnEdit_detailForm.UseVisualStyleBackColor = true;
            this.btnEdit_detailForm.Click += new System.EventHandler(this.btnEdit_detailForm_Click);
            // 
            // DetailForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 735);
            this.Controls.Add(this.btnEdit_detailForm);
            this.Controls.Add(this.btnDelete_detailForm);
            this.Controls.Add(this.txtRepeats_detailForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCategory_detailForm);
            this.Controls.Add(this.btnClose_detailForm);
            this.Controls.Add(this.date_detailForm);
            this.Controls.Add(this.txtDescription_detailForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(1075, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailForm1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "일정 자세히 보기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailForm1_FormClosing);
            this.Load += new System.EventHandler(this.DetailForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepeats_detailForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCategory_detailForm;
        private System.Windows.Forms.Button btnClose_detailForm;
        private System.Windows.Forms.DateTimePicker date_detailForm;
        private System.Windows.Forms.TextBox txtDescription_detailForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete_detailForm;
        private System.Windows.Forms.Button btnEdit_detailForm;
    }
}