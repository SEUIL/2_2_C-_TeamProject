using System;
using System.Windows.Forms;

namespace TimeToDo.Forms
{
    partial class TodoForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoForm1));
            this.listView = new System.Windows.Forms.ListView();
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TodoDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.중요도ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.일반ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.중요ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.완료여부ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.미완료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.완료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.카테고리별ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공적일정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사적일정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자기계발ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.취미생활ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.listView.Location = new System.Drawing.Point(22, 64);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(873, 535);
            this.listView.TabIndex = 9;
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
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.중요도ToolStripMenuItem1,
            this.완료여부ToolStripMenuItem1,
            this.카테고리별ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 29);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 중요도ToolStripMenuItem1
            // 
            this.중요도ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.일반ToolStripMenuItem1,
            this.중요ToolStripMenuItem1});
            this.중요도ToolStripMenuItem1.Name = "중요도ToolStripMenuItem1";
            this.중요도ToolStripMenuItem1.Size = new System.Drawing.Size(80, 25);
            this.중요도ToolStripMenuItem1.Text = "중요도별";
            // 
            // 일반ToolStripMenuItem1
            // 
            this.일반ToolStripMenuItem1.Name = "일반ToolStripMenuItem1";
            this.일반ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.일반ToolStripMenuItem1.Text = "중요";
            this.일반ToolStripMenuItem1.Click += new System.EventHandler(this.중요ToolStripMenuItem_Click);
            // 
            // 중요ToolStripMenuItem1
            // 
            this.중요ToolStripMenuItem1.Name = "중요ToolStripMenuItem1";
            this.중요ToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.중요ToolStripMenuItem1.Text = "일반";
            this.중요ToolStripMenuItem1.Click += new System.EventHandler(this.일반ToolStripMenuItem_Click);
            // 
            // 완료여부ToolStripMenuItem1
            // 
            this.완료여부ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.미완료ToolStripMenuItem1,
            this.완료ToolStripMenuItem1});
            this.완료여부ToolStripMenuItem1.Name = "완료여부ToolStripMenuItem1";
            this.완료여부ToolStripMenuItem1.Size = new System.Drawing.Size(94, 25);
            this.완료여부ToolStripMenuItem1.Text = "완료여부별";
            // 
            // 미완료ToolStripMenuItem1
            // 
            this.미완료ToolStripMenuItem1.Name = "미완료ToolStripMenuItem1";
            this.미완료ToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.미완료ToolStripMenuItem1.Text = "미완료";
            this.미완료ToolStripMenuItem1.Click += new System.EventHandler(this.미완료ToolStripMenuItem_Click);
            // 
            // 완료ToolStripMenuItem1
            // 
            this.완료ToolStripMenuItem1.Name = "완료ToolStripMenuItem1";
            this.완료ToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.완료ToolStripMenuItem1.Text = "완료";
            this.완료ToolStripMenuItem1.Click += new System.EventHandler(this.완료ToolStripMenuItem_Click);
            // 
            // 카테고리별ToolStripMenuItem
            // 
            this.카테고리별ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공적일정ToolStripMenuItem,
            this.사적일정ToolStripMenuItem,
            this.자기계발ToolStripMenuItem,
            this.취미생활ToolStripMenuItem});
            this.카테고리별ToolStripMenuItem.Name = "카테고리별ToolStripMenuItem";
            this.카테고리별ToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.카테고리별ToolStripMenuItem.Text = "카테고리별";
            // 
            // 공적일정ToolStripMenuItem
            // 
            this.공적일정ToolStripMenuItem.Name = "공적일정ToolStripMenuItem";
            this.공적일정ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.공적일정ToolStripMenuItem.Text = "공적일정";
            this.공적일정ToolStripMenuItem.Click += new System.EventHandler(this.공적일정ToolStripMenuItem1_Click);
            // 
            // 사적일정ToolStripMenuItem
            // 
            this.사적일정ToolStripMenuItem.Name = "사적일정ToolStripMenuItem";
            this.사적일정ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.사적일정ToolStripMenuItem.Text = "사적일정";
            this.사적일정ToolStripMenuItem.Click += new System.EventHandler(this.사적일정ToolStripMenuItem_Click);
            // 
            // 자기계발ToolStripMenuItem
            // 
            this.자기계발ToolStripMenuItem.Name = "자기계발ToolStripMenuItem";
            this.자기계발ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.자기계발ToolStripMenuItem.Text = "자기개발";
            this.자기계발ToolStripMenuItem.Click += new System.EventHandler(this.자기개발ToolStripMenuItem_Click);
            // 
            // 취미생활ToolStripMenuItem
            // 
            this.취미생활ToolStripMenuItem.Name = "취미생활ToolStripMenuItem";
            this.취미생활ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.취미생활ToolStripMenuItem.Text = "취미생활";
            this.취미생활ToolStripMenuItem.Click += new System.EventHandler(this.취미생활ToolStripMenuItem_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Noto Sans KR", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(918, 64);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(102, 41);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "검색";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(903, 137);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 44);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "추가";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 29);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SlateGray;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(903, 217);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 44);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "수정";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(903, 297);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 44);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(573, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "시작 기준 날짜 : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(281, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "필터 해제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TodoForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TodoForm1";
            this.Size = new System.Drawing.Size(1030, 625);
            this.Load += new System.EventHandler(this.TodoForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem 중요도ToolStripMenuItem1;
        private ToolStripMenuItem 완료여부ToolStripMenuItem1;
        private ToolStripMenuItem 카테고리별ToolStripMenuItem;
        private ToolStripMenuItem 일반ToolStripMenuItem1;
        private ToolStripMenuItem 중요ToolStripMenuItem1;
        private ToolStripMenuItem 미완료ToolStripMenuItem1;
        private ToolStripMenuItem 완료ToolStripMenuItem1;
        private ToolStripMenuItem 공적일정ToolStripMenuItem;
        private ToolStripMenuItem 사적일정ToolStripMenuItem;
        private ToolStripMenuItem 자기계발ToolStripMenuItem;
        private ToolStripMenuItem 취미생활ToolStripMenuItem;
        private Button SearchButton;
        private Button AddButton;
        private DateTimePicker dateTimePicker1;
        private Button EditButton;
        private Button DeleteButton;
        private Label label1;
        private ColumnHeader Task;
        private ColumnHeader Category;
        private ColumnHeader Priority;
        private ColumnHeader TodoDate;
        private ColumnHeader Deadline;
        private Button button1;
        private ImageList imageList1;
    }
}