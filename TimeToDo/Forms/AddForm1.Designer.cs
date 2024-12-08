﻿namespace TimeToDo.Forms
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
            this.date_addForm = new System.Windows.Forms.DateTimePicker();
            this.btnSummit_addForm = new System.Windows.Forms.Button();
            this.comboCategory_addForm = new System.Windows.Forms.ComboBox();
            this.comboRepeats_addForm = new System.Windows.Forms.ComboBox();
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
            this.label2.Font = new System.Drawing.Font("Noto Sans KR", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "카테고리";
            // 
            // txtDescription_addForm
            // 
            this.txtDescription_addForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDescription_addForm.Location = new System.Drawing.Point(3, 36);
            this.txtDescription_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription_addForm.Name = "txtDescription_addForm";
            this.txtDescription_addForm.Size = new System.Drawing.Size(305, 29);
            this.txtDescription_addForm.TabIndex = 14;
            // 
            // date_addForm
            // 
            this.date_addForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date_addForm.Location = new System.Drawing.Point(3, 105);
            this.date_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_addForm.Name = "date_addForm";
            this.date_addForm.Size = new System.Drawing.Size(305, 29);
            this.date_addForm.TabIndex = 16;
            // 
            // btnSummit_addForm
            // 
            this.btnSummit_addForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSummit_addForm.Font = new System.Drawing.Font("Noto Sans KR SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSummit_addForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSummit_addForm.Location = new System.Drawing.Point(231, 401);
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
            this.comboCategory_addForm.Location = new System.Drawing.Point(3, 174);
            this.comboCategory_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCategory_addForm.Name = "comboCategory_addForm";
            this.comboCategory_addForm.Size = new System.Drawing.Size(305, 29);
            this.comboCategory_addForm.TabIndex = 18;
            // 
            // comboRepeats_addForm
            // 
            this.comboRepeats_addForm.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboRepeats_addForm.FormattingEnabled = true;
            this.comboRepeats_addForm.Items.AddRange(new object[] {
            "반복없음",
            "매일",
            "매주",
            "매달",
            "매년"});
            this.comboRepeats_addForm.Location = new System.Drawing.Point(3, 237);
            this.comboRepeats_addForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboRepeats_addForm.Name = "comboRepeats_addForm";
            this.comboRepeats_addForm.Size = new System.Drawing.Size(305, 29);
            this.comboRepeats_addForm.TabIndex = 20;
            this.comboRepeats_addForm.Text = "매일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans KR", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "일정 상세";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans KR", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "반복 여부";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtDescription_addForm);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.date_addForm);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comboCategory_addForm);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.comboRepeats_addForm);
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
            this.ClientSize = new System.Drawing.Size(369, 476);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSummit_addForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddForm1";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "일정 추가";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription_addForm;
        private System.Windows.Forms.DateTimePicker date_addForm;
        private System.Windows.Forms.Button btnSummit_addForm;
        private System.Windows.Forms.ComboBox comboCategory_addForm;
        private System.Windows.Forms.ComboBox comboRepeats_addForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}