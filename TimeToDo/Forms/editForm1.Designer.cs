namespace TimeToDo.Forms
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
            this.txtRepeats_editForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.comboCategory_editForm.Location = new System.Drawing.Point(162, 95);
            this.comboCategory_editForm.Name = "comboCategory_editForm";
            this.comboCategory_editForm.Size = new System.Drawing.Size(267, 20);
            this.comboCategory_editForm.TabIndex = 26;
            // 
            // btnSummit_addForm
            // 
            this.btnSummit_addForm.Location = new System.Drawing.Point(204, 263);
            this.btnSummit_addForm.Name = "btnSummit_addForm";
            this.btnSummit_addForm.Size = new System.Drawing.Size(90, 37);
            this.btnSummit_addForm.TabIndex = 25;
            this.btnSummit_addForm.Text = "확인";
            this.btnSummit_addForm.UseVisualStyleBackColor = true;
            this.btnSummit_addForm.Click += new System.EventHandler(this.btnSummit_addForm_Click);
            // 
            // date_editForm
            // 
            this.date_editForm.Location = new System.Drawing.Point(162, 135);
            this.date_editForm.Name = "date_editForm";
            this.date_editForm.Size = new System.Drawing.Size(267, 21);
            this.date_editForm.TabIndex = 24;
            // 
            // txtDescription_editForm
            // 
            this.txtDescription_editForm.Location = new System.Drawing.Point(162, 173);
            this.txtDescription_editForm.Name = "txtDescription_editForm";
            this.txtDescription_editForm.Size = new System.Drawing.Size(267, 21);
            this.txtDescription_editForm.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(57, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "일정 상세";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(57, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(57, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "카테고리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(186, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "일정 편집";
            // 
            // txtRepeats_editForm
            // 
            this.txtRepeats_editForm.Location = new System.Drawing.Point(162, 217);
            this.txtRepeats_editForm.Name = "txtRepeats_editForm";
            this.txtRepeats_editForm.Size = new System.Drawing.Size(267, 21);
            this.txtRepeats_editForm.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(57, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "반복";
            // 
            // editForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 348);
            this.Controls.Add(this.txtRepeats_editForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCategory_editForm);
            this.Controls.Add(this.btnSummit_addForm);
            this.Controls.Add(this.date_editForm);
            this.Controls.Add(this.txtDescription_editForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editForm1";
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
        private System.Windows.Forms.TextBox txtRepeats_editForm;
        private System.Windows.Forms.Label label5;
    }
}