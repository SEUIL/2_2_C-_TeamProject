namespace TimeToDo.Forms
{
    partial class HomeForm1
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TodoDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(16, 60);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(389, 197);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "카테고리";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "시간";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "일정 상세";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "반복";
            this.columnHeader4.Width = 85;
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Check,
            this.Task,
            this.Category,
            this.Priority,
            this.TodoDate,
            this.Deadline});
            this.listView.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 60);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(585, 500);
            this.listView.TabIndex = 22;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Check
            // 
            this.Check.Text = "";
            this.Check.Width = 34;
            // 
            // Task
            // 
            this.Task.Text = "Task";
            this.Task.Width = 200;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 100;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 100;
            // 
            // TodoDate
            // 
            this.TodoDate.Text = "TodoDate";
            this.TodoDate.Width = 120;
            // 
            // Deadline
            // 
            this.Deadline.Text = "Deadline";
            this.Deadline.Width = 120;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(324, 17);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 39);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SlateGray;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(415, 17);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 39);
            this.EditButton.TabIndex = 25;
            this.EditButton.Text = "수정";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(506, 17);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 39);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "추가";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans KR Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 275);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "오늘의 일정";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Font = new System.Drawing.Font("Noto Sans KR Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(13, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 300);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "앞으로의 일정";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.listView);
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.Controls.Add(this.EditButton);
            this.groupBox3.Controls.Add(this.AddButton);
            this.groupBox3.Font = new System.Drawing.Font("Noto Sans KR Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(437, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 581);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "남은 할 일";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 67);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(389, 212);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "카테고리";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "시간";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "일정 상세";
            this.columnHeader7.Width = 148;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "반복";
            this.columnHeader8.Width = 85;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(138, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(229, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(320, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 39);
            this.button3.TabIndex = 27;
            this.button3.Text = "추가";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(138, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 39);
            this.button4.TabIndex = 32;
            this.button4.Text = "삭제";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SlateGray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(229, 21);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 39);
            this.button5.TabIndex = 31;
            this.button5.Text = "수정";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(320, 21);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 39);
            this.button6.TabIndex = 30;
            this.button6.Text = "추가";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // HomeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm1";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 20);
            this.Size = new System.Drawing.Size(1063, 625);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Check;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader TodoDate;
        private System.Windows.Forms.ColumnHeader Deadline;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}