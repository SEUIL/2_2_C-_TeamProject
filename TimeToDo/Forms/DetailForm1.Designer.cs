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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete_detailForm = new System.Windows.Forms.Button();
            this.btnEdit_detailForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRepeats_detailForm
            // 
            this.txtRepeats_detailForm.Enabled = false;
            this.txtRepeats_detailForm.Location = new System.Drawing.Point(148, 210);
            this.txtRepeats_detailForm.Name = "txtRepeats_detailForm";
            this.txtRepeats_detailForm.Size = new System.Drawing.Size(267, 21);
            this.txtRepeats_detailForm.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(43, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
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
            this.comboCategory_detailForm.Location = new System.Drawing.Point(148, 88);
            this.comboCategory_detailForm.Name = "comboCategory_detailForm";
            this.comboCategory_detailForm.Size = new System.Drawing.Size(267, 20);
            this.comboCategory_detailForm.TabIndex = 36;
            // 
            // btnClose_detailForm
            // 
            this.btnClose_detailForm.Location = new System.Drawing.Point(276, 265);
            this.btnClose_detailForm.Name = "btnClose_detailForm";
            this.btnClose_detailForm.Size = new System.Drawing.Size(90, 37);
            this.btnClose_detailForm.TabIndex = 35;
            this.btnClose_detailForm.Text = "돌아가기";
            this.btnClose_detailForm.UseVisualStyleBackColor = true;
            this.btnClose_detailForm.Click += new System.EventHandler(this.btnClose_detailForm_Click);
            // 
            // date_detailForm
            // 
            this.date_detailForm.Enabled = false;
            this.date_detailForm.Location = new System.Drawing.Point(148, 128);
            this.date_detailForm.Name = "date_detailForm";
            this.date_detailForm.Size = new System.Drawing.Size(267, 21);
            this.date_detailForm.TabIndex = 34;
            // 
            // txtDescription_detailForm
            // 
            this.txtDescription_detailForm.Enabled = false;
            this.txtDescription_detailForm.Location = new System.Drawing.Point(148, 166);
            this.txtDescription_detailForm.Name = "txtDescription_detailForm";
            this.txtDescription_detailForm.Size = new System.Drawing.Size(267, 21);
            this.txtDescription_detailForm.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "일정 상세";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(43, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "카테고리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(127, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "일정 자세히 보기";
            // 
            // btnDelete_detailForm
            // 
            this.btnDelete_detailForm.Location = new System.Drawing.Point(180, 265);
            this.btnDelete_detailForm.Name = "btnDelete_detailForm";
            this.btnDelete_detailForm.Size = new System.Drawing.Size(90, 37);
            this.btnDelete_detailForm.TabIndex = 39;
            this.btnDelete_detailForm.Text = "삭제";
            this.btnDelete_detailForm.UseVisualStyleBackColor = true;
            this.btnDelete_detailForm.Click += new System.EventHandler(this.btnDelete_detailForm_Click);
            // 
            // btnEdit_detailForm
            // 
            this.btnEdit_detailForm.Location = new System.Drawing.Point(84, 265);
            this.btnEdit_detailForm.Name = "btnEdit_detailForm";
            this.btnEdit_detailForm.Size = new System.Drawing.Size(90, 37);
            this.btnEdit_detailForm.TabIndex = 40;
            this.btnEdit_detailForm.Text = "수정";
            this.btnEdit_detailForm.UseVisualStyleBackColor = true;
            this.btnEdit_detailForm.Click += new System.EventHandler(this.btnEdit_detailForm_Click);
            // 
            // DetailForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 344);
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
            this.Controls.Add(this.label1);
            this.Name = "DetailForm1";
            this.Text = "DetailForm1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete_detailForm;
        private System.Windows.Forms.Button btnEdit_detailForm;
    }
}