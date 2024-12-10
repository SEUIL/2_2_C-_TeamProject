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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription_addForm = new System.Windows.Forms.TextBox();
            this.date_detailForm = new System.Windows.Forms.DateTimePicker();
            this.btnSummit_addForm = new System.Windows.Forms.Button();
            this.comboCategory_addForm = new System.Windows.Forms.ComboBox();
            this.txtRepeats_detailForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "카테고리";
            // 
            // txtDescription_addForm
            // 
            this.txtDescription_addForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDescription_addForm.Location = new System.Drawing.Point(3, 30);
            this.txtDescription_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription_addForm.Name = "txtDescription_addForm";
            this.txtDescription_addForm.Size = new System.Drawing.Size(305, 29);
            this.txtDescription_addForm.TabIndex = 14;
            // 
            // date_detailForm
            // 
            this.date_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date_detailForm.Location = new System.Drawing.Point(3, 103);
            this.date_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_detailForm.Name = "date_detailForm";
            this.date_detailForm.Size = new System.Drawing.Size(205, 29);
            this.date_detailForm.TabIndex = 16;
            // 
            // btnSummit_addForm
            // 
            this.btnSummit_addForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSummit_addForm.Font = new System.Drawing.Font("Noto Sans KR SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSummit_addForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSummit_addForm.Location = new System.Drawing.Point(234, 391);
            this.btnSummit_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSummit_addForm.Name = "btnSummit_addForm";
            this.btnSummit_addForm.Size = new System.Drawing.Size(103, 46);
            this.btnSummit_addForm.TabIndex = 17;
            this.btnSummit_addForm.Text = "확인";
            this.btnSummit_addForm.UseVisualStyleBackColor = false;
            this.btnSummit_addForm.Click += new System.EventHandler(this.btnSummit_addForm_Click);
            // 
            // comboCategory_addForm
            // 
            this.comboCategory_addForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboCategory_addForm.FormattingEnabled = true;
            this.comboCategory_addForm.Items.AddRange(new object[] {
            "공적 일정",
            "사적 일정",
            "자기 개발",
            "취미 생활"});
            this.comboCategory_addForm.Location = new System.Drawing.Point(3, 176);
            this.comboCategory_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCategory_addForm.Name = "comboCategory_addForm";
            this.comboCategory_addForm.Size = new System.Drawing.Size(205, 29);
            this.comboCategory_addForm.TabIndex = 18;
            // 
            // txtRepeats_detailForm
            // 
            this.txtRepeats_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRepeats_detailForm.FormattingEnabled = true;
            this.txtRepeats_detailForm.Items.AddRange(new object[] {
            "반복없음",
            "매일",
            "매주",
            "매달",
            "매년"});
            this.txtRepeats_detailForm.Location = new System.Drawing.Point(3, 249);
            this.txtRepeats_detailForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepeats_detailForm.Name = "txtRepeats_detailForm";
            this.txtRepeats_detailForm.Size = new System.Drawing.Size(205, 29);
            this.txtRepeats_detailForm.TabIndex = 20;
            this.txtRepeats_detailForm.Text = "매일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(46, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "일정 상세";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 209);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(85, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "반복 여부";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtDescription_addForm);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.date_detailForm);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comboCategory_addForm);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtRepeats_detailForm);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 316);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // AddForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 456);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSummit_addForm);
            this.Location = new System.Drawing.Point(1075, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddForm1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "일정 추가";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription_addForm;
        private System.Windows.Forms.DateTimePicker date_detailForm;
        private System.Windows.Forms.Button btnSummit_addForm;
        private System.Windows.Forms.ComboBox comboCategory_addForm;
        private System.Windows.Forms.ComboBox txtRepeats_detailForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}