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
            this.btnSummit_addForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription_editForm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_editForm = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboCategory_editForm = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboRepeats_editForm = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSummit_addForm
            // 
            this.btnSummit_addForm.Location = new System.Drawing.Point(233, 401);
            this.btnSummit_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSummit_addForm.Name = "btnSummit_addForm";
            this.btnSummit_addForm.Size = new System.Drawing.Size(103, 46);
            this.btnSummit_addForm.TabIndex = 25;
            this.btnSummit_addForm.Text = "확인";
            this.btnSummit_addForm.UseVisualStyleBackColor = true;
            this.btnSummit_addForm.Click += new System.EventHandler(this.btnSummit_addForm_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.comboCategory_editForm);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtDescription_editForm);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.date_editForm);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.comboRepeats_editForm);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(309, 316);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "일정 상세";
            // 
            // txtDescription_editForm
            // 
            this.txtDescription_editForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDescription_editForm.Location = new System.Drawing.Point(3, 103);
            this.txtDescription_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription_editForm.Name = "txtDescription_editForm";
            this.txtDescription_editForm.Size = new System.Drawing.Size(305, 29);
            this.txtDescription_editForm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 136);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label7.Size = new System.Drawing.Size(46, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "시간";
            // 
            // date_editForm
            // 
            this.date_editForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date_editForm.Location = new System.Drawing.Point(3, 176);
            this.date_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_editForm.Name = "date_editForm";
            this.date_editForm.Size = new System.Drawing.Size(205, 29);
            this.date_editForm.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(80, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "카테고리";
            // 
            // comboCategory_editForm
            // 
            this.comboCategory_editForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboCategory_editForm.FormattingEnabled = true;
            this.comboCategory_editForm.Items.AddRange(new object[] {
            "공적 일정",
            "사적 일정",
            "자기 개발",
            "취미 생활"});
            this.comboCategory_editForm.Location = new System.Drawing.Point(3, 40);
            this.comboCategory_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCategory_editForm.Name = "comboCategory_editForm";
            this.comboCategory_editForm.Size = new System.Drawing.Size(205, 29);
            this.comboCategory_editForm.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 209);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label9.Size = new System.Drawing.Size(46, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "반복";
            // 
            // comboRepeats_editForm
            // 
            this.comboRepeats_editForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboRepeats_editForm.FormattingEnabled = true;
            this.comboRepeats_editForm.Items.AddRange(new object[] {
            "반복없음",
            "매일",
            "매주",
            "매달",
            "매년"});
            this.comboRepeats_editForm.Location = new System.Drawing.Point(3, 249);
            this.comboRepeats_editForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboRepeats_editForm.Name = "comboRepeats_editForm";
            this.comboRepeats_editForm.Size = new System.Drawing.Size(205, 29);
            this.comboRepeats_editForm.TabIndex = 20;
            this.comboRepeats_editForm.Text = "매일";
            // 
            // editForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 462);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSummit_addForm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "editForm1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "일정 수정하기";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSummit_addForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboCategory_editForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription_editForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_editForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboRepeats_editForm;
    }
}