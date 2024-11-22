namespace TimeToDo.Forms
{
    partial class AddForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription_addForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_addForm = new System.Windows.Forms.DateTimePicker();
            this.btnSummit_addForm = new System.Windows.Forms.Button();
            this.comboCategory_addForm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(180, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "일정 추가";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "카테고리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "시간";
            // 
            // txtDescription_addForm
            // 
            this.txtDescription_addForm.Location = new System.Drawing.Point(156, 176);
            this.txtDescription_addForm.Name = "txtDescription_addForm";
            this.txtDescription_addForm.Size = new System.Drawing.Size(267, 21);
            this.txtDescription_addForm.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(51, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "일정 상세";
            // 
            // date_addForm
            // 
            this.date_addForm.Location = new System.Drawing.Point(156, 138);
            this.date_addForm.Name = "date_addForm";
            this.date_addForm.Size = new System.Drawing.Size(267, 21);
            this.date_addForm.TabIndex = 16;
            // 
            // btnSummit_addForm
            // 
            this.btnSummit_addForm.Location = new System.Drawing.Point(199, 223);
            this.btnSummit_addForm.Name = "btnSummit_addForm";
            this.btnSummit_addForm.Size = new System.Drawing.Size(90, 37);
            this.btnSummit_addForm.TabIndex = 17;
            this.btnSummit_addForm.Text = "확인";
            this.btnSummit_addForm.UseVisualStyleBackColor = true;
            this.btnSummit_addForm.Click += new System.EventHandler(this.btnSummit_addForm_Click);
            // 
            // comboCategory_addForm
            // 
            this.comboCategory_addForm.FormattingEnabled = true;
            this.comboCategory_addForm.Items.AddRange(new object[] {
            "공적 일정",
            "사적 일정",
            "자기 개발",
            "취미 생활"});
            this.comboCategory_addForm.Location = new System.Drawing.Point(156, 98);
            this.comboCategory_addForm.Name = "comboCategory_addForm";
            this.comboCategory_addForm.Size = new System.Drawing.Size(267, 20);
            this.comboCategory_addForm.TabIndex = 18;
            // 
            // AddForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 334);
            this.Controls.Add(this.comboCategory_addForm);
            this.Controls.Add(this.btnSummit_addForm);
            this.Controls.Add(this.date_addForm);
            this.Controls.Add(this.txtDescription_addForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm1";
            this.Text = "AddForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription_addForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_addForm;
        private System.Windows.Forms.Button btnSummit_addForm;
        private System.Windows.Forms.ComboBox comboCategory_addForm;
    }
}