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
            this.btnClose_detailForm = new System.Windows.Forms.Button();
            this.btnDelete_detailForm = new System.Windows.Forms.Button();
            this.btnEdit_detailForm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCategory_detailForm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_detailForm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription_deatilForm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRepeats_detailForm = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose_detailForm
            // 
            this.btnClose_detailForm.BackColor = System.Drawing.Color.LightGray;
            this.btnClose_detailForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_detailForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose_detailForm.Location = new System.Drawing.Point(23, 318);
            this.btnClose_detailForm.Name = "btnClose_detailForm";
            this.btnClose_detailForm.Size = new System.Drawing.Size(90, 37);
            this.btnClose_detailForm.TabIndex = 35;
            this.btnClose_detailForm.Text = "돌아가기";
            this.btnClose_detailForm.UseVisualStyleBackColor = false;
            this.btnClose_detailForm.Click += new System.EventHandler(this.btnClose_detailForm_Click);
            // 
            // btnDelete_detailForm
            // 
            this.btnDelete_detailForm.BackColor = System.Drawing.Color.Red;
            this.btnDelete_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_detailForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete_detailForm.Location = new System.Drawing.Point(185, 318);
            this.btnDelete_detailForm.Name = "btnDelete_detailForm";
            this.btnDelete_detailForm.Size = new System.Drawing.Size(90, 37);
            this.btnDelete_detailForm.TabIndex = 39;
            this.btnDelete_detailForm.Text = "삭제";
            this.btnDelete_detailForm.UseVisualStyleBackColor = false;
            this.btnDelete_detailForm.Click += new System.EventHandler(this.btnDelete_detailForm_Click);
            // 
            // btnEdit_detailForm
            // 
            this.btnEdit_detailForm.BackColor = System.Drawing.Color.SlateGray;
            this.btnEdit_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_detailForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit_detailForm.Location = new System.Drawing.Point(281, 318);
            this.btnEdit_detailForm.Name = "btnEdit_detailForm";
            this.btnEdit_detailForm.Size = new System.Drawing.Size(90, 37);
            this.btnEdit_detailForm.TabIndex = 40;
            this.btnEdit_detailForm.Text = "수정";
            this.btnEdit_detailForm.UseVisualStyleBackColor = false;
            this.btnEdit_detailForm.Click += new System.EventHandler(this.btnEdit_detailForm_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.comboCategory_detailForm);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.date_detailForm);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtDescription_deatilForm);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.comboRepeats_detailForm);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 55);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 249);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "카테고리";
            // 
            // comboCategory_detailForm
            // 
            this.comboCategory_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboCategory_detailForm.FormattingEnabled = true;
            this.comboCategory_detailForm.Items.AddRange(new object[] {
            "공적 일정",
            "사적 일정",
            "자기 개발",
            "취미 생활"});
            this.comboCategory_detailForm.Location = new System.Drawing.Point(3, 32);
            this.comboCategory_detailForm.Name = "comboCategory_detailForm";
            this.comboCategory_detailForm.Size = new System.Drawing.Size(180, 25);
            this.comboCategory_detailForm.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label6.Size = new System.Drawing.Size(38, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "시간";
            // 
            // date_detailForm
            // 
            this.date_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date_detailForm.Location = new System.Drawing.Point(3, 92);
            this.date_detailForm.Name = "date_detailForm";
            this.date_detailForm.Size = new System.Drawing.Size(180, 25);
            this.date_detailForm.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 120);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "일정 상세";
            // 
            // txtDescription_deatilForm
            // 
            this.txtDescription_deatilForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDescription_deatilForm.Location = new System.Drawing.Point(3, 152);
            this.txtDescription_deatilForm.Name = "txtDescription_deatilForm";
            this.txtDescription_deatilForm.Size = new System.Drawing.Size(267, 25);
            this.txtDescription_deatilForm.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 180);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "반복 여부";
            // 
            // comboRepeats_detailForm
            // 
            this.comboRepeats_detailForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboRepeats_detailForm.FormattingEnabled = true;
            this.comboRepeats_detailForm.Items.AddRange(new object[] {
            "반복없음",
            "매일",
            "매주",
            "매달",
            "매년"});
            this.comboRepeats_detailForm.Location = new System.Drawing.Point(3, 212);
            this.comboRepeats_detailForm.Name = "comboRepeats_detailForm";
            this.comboRepeats_detailForm.Size = new System.Drawing.Size(180, 25);
            this.comboRepeats_detailForm.TabIndex = 20;
            this.comboRepeats_detailForm.Text = "매일";
            // 
            // DetailForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 376);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEdit_detailForm);
            this.Controls.Add(this.btnDelete_detailForm);
            this.Controls.Add(this.btnClose_detailForm);
            this.Location = new System.Drawing.Point(1075, 50);
            this.Name = "DetailForm1";
            this.Text = "일정 자세히 보기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailForm1_FormClosing);
            this.Load += new System.EventHandler(this.DetailForm1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose_detailForm;
        private System.Windows.Forms.Button btnDelete_detailForm;
        private System.Windows.Forms.Button btnEdit_detailForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription_deatilForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_detailForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCategory_detailForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboRepeats_detailForm;
    }
}