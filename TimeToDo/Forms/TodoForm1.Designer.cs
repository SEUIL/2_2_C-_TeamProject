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
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.필터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공적일정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공적일정ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.사적일정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자기개발ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.취미생활ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중요도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일반ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중요ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.완료여부ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.완료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.미완료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(16, 153);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(66, 18);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "검색하기";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(720, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(99, 247);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "menu";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(16, 205);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(66, 18);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(16, 95);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(66, 18);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "수정";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 34);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(66, 18);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "추가";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Check});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 35);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(677, 339);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Check
            // 
            this.Check.Text = "";
            this.Check.Width = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.필터ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 필터ToolStripMenuItem
            // 
            this.필터ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공적일정ToolStripMenuItem,
            this.중요도ToolStripMenuItem,
            this.완료여부ToolStripMenuItem});
            this.필터ToolStripMenuItem.Name = "필터ToolStripMenuItem";
            this.필터ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.필터ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.필터ToolStripMenuItem.Text = "필터(F)";
            // 
            // 공적일정ToolStripMenuItem
            // 
            this.공적일정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공적일정ToolStripMenuItem1,
            this.사적일정ToolStripMenuItem,
            this.자기개발ToolStripMenuItem,
            this.취미생활ToolStripMenuItem});
            this.공적일정ToolStripMenuItem.Name = "공적일정ToolStripMenuItem";
            this.공적일정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.공적일정ToolStripMenuItem.Text = "카테고리";
            // 
            // 공적일정ToolStripMenuItem1
            // 
            this.공적일정ToolStripMenuItem1.Name = "공적일정ToolStripMenuItem1";
            this.공적일정ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.공적일정ToolStripMenuItem1.Text = "공적일정";
            this.공적일정ToolStripMenuItem1.Click += new System.EventHandler(this.공적일정ToolStripMenuItem1_Click);
            // 
            // 사적일정ToolStripMenuItem
            // 
            this.사적일정ToolStripMenuItem.Name = "사적일정ToolStripMenuItem";
            this.사적일정ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.사적일정ToolStripMenuItem.Text = "사적일정";
            this.사적일정ToolStripMenuItem.Click += new System.EventHandler(this.사적일정ToolStripMenuItem_Click);
            // 
            // 자기개발ToolStripMenuItem
            // 
            this.자기개발ToolStripMenuItem.Name = "자기개발ToolStripMenuItem";
            this.자기개발ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.자기개발ToolStripMenuItem.Text = "자기개발";
            this.자기개발ToolStripMenuItem.Click += new System.EventHandler(this.자기개발ToolStripMenuItem_Click);
            // 
            // 취미생활ToolStripMenuItem
            // 
            this.취미생활ToolStripMenuItem.Name = "취미생활ToolStripMenuItem";
            this.취미생활ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.취미생활ToolStripMenuItem.Text = "취미생활";
            this.취미생활ToolStripMenuItem.Click += new System.EventHandler(this.취미생활ToolStripMenuItem_Click);
            // 
            // 중요도ToolStripMenuItem
            // 
            this.중요도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.일반ToolStripMenuItem,
            this.중요ToolStripMenuItem});
            this.중요도ToolStripMenuItem.Name = "중요도ToolStripMenuItem";
            this.중요도ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.중요도ToolStripMenuItem.Text = "중요도";
            // 
            // 일반ToolStripMenuItem
            // 
            this.일반ToolStripMenuItem.Name = "일반ToolStripMenuItem";
            this.일반ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.일반ToolStripMenuItem.Text = "일반";
            this.일반ToolStripMenuItem.Click += new System.EventHandler(this.일반ToolStripMenuItem_Click);
            // 
            // 중요ToolStripMenuItem
            // 
            this.중요ToolStripMenuItem.Name = "중요ToolStripMenuItem";
            this.중요ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.중요ToolStripMenuItem.Text = "중요";
            this.중요ToolStripMenuItem.Click += new System.EventHandler(this.중요ToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(701, 292);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 29);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "전체 할 일 불러오기";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnLoadTodoList_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(720, 337);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(105, 37);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "캘린더 이동";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // 완료여부ToolStripMenuItem
            // 
            this.완료여부ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.완료ToolStripMenuItem,
            this.미완료ToolStripMenuItem});
            this.완료여부ToolStripMenuItem.Name = "완료여부ToolStripMenuItem";
            this.완료여부ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.완료여부ToolStripMenuItem.Text = "완료여부";
            // 
            // 완료ToolStripMenuItem
            // 
            this.완료ToolStripMenuItem.Name = "완료ToolStripMenuItem";
            this.완료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.완료ToolStripMenuItem.Text = "완료";
            this.완료ToolStripMenuItem.Click += new System.EventHandler(this.완료ToolStripMenuItem_Click);
            // 
            // 미완료ToolStripMenuItem
            // 
            this.미완료ToolStripMenuItem.Name = "미완료ToolStripMenuItem";
            this.미완료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.미완료ToolStripMenuItem.Text = "미완료";
            this.미완료ToolStripMenuItem.Click += new System.EventHandler(this.미완료ToolStripMenuItem_Click);
            // 
            // TodoForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 390);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TodoForm1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodoForm1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 필터ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolStripMenuItem 공적일정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공적일정ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 사적일정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자기개발ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 취미생활ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중요도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일반ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중요ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 완료여부ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 완료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 미완료ToolStripMenuItem;
    }
}