﻿using System;
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
            this.listView = new System.Windows.Forms.ListView();
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Check});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(20, 84);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(764, 429);
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
            this.중요도ToolStripMenuItem1,
            this.완료여부ToolStripMenuItem1,
            this.카테고리별ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 중요도ToolStripMenuItem1
            // 
            this.중요도ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.일반ToolStripMenuItem1,
            this.중요ToolStripMenuItem1});
            this.중요도ToolStripMenuItem1.Name = "중요도ToolStripMenuItem1";
            this.중요도ToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.중요도ToolStripMenuItem1.Text = "중요도별";
            // 
            // 일반ToolStripMenuItem1
            // 
            this.일반ToolStripMenuItem1.Name = "일반ToolStripMenuItem1";
            this.일반ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.일반ToolStripMenuItem1.Text = "중요";
            this.일반ToolStripMenuItem1.Click += new System.EventHandler(this.중요ToolStripMenuItem_Click);
            // 
            // 중요ToolStripMenuItem1
            // 
            this.중요ToolStripMenuItem1.Name = "중요ToolStripMenuItem1";
            this.중요ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.중요ToolStripMenuItem1.Text = "일반";
            this.중요ToolStripMenuItem1.Click += new System.EventHandler(this.일반ToolStripMenuItem_Click);
            // 
            // 완료여부ToolStripMenuItem1
            // 
            this.완료여부ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.미완료ToolStripMenuItem1,
            this.완료ToolStripMenuItem1});
            this.완료여부ToolStripMenuItem1.Name = "완료여부ToolStripMenuItem1";
            this.완료여부ToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.완료여부ToolStripMenuItem1.Text = "완료여부별";
            // 
            // 미완료ToolStripMenuItem1
            // 
            this.미완료ToolStripMenuItem1.Name = "미완료ToolStripMenuItem1";
            this.미완료ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.미완료ToolStripMenuItem1.Text = "미완료";
            this.미완료ToolStripMenuItem1.Click += new System.EventHandler(this.미완료ToolStripMenuItem_Click);
            // 
            // 완료ToolStripMenuItem1
            // 
            this.완료ToolStripMenuItem1.Name = "완료ToolStripMenuItem1";
            this.완료ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
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
            this.카테고리별ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.카테고리별ToolStripMenuItem.Text = "카테고리별";
            // 
            // 공적일정ToolStripMenuItem
            // 
            this.공적일정ToolStripMenuItem.Name = "공적일정ToolStripMenuItem";
            this.공적일정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.공적일정ToolStripMenuItem.Text = "공적일정";
            this.공적일정ToolStripMenuItem.Click += new System.EventHandler(this.공적일정ToolStripMenuItem1_Click);
            // 
            // 사적일정ToolStripMenuItem
            // 
            this.사적일정ToolStripMenuItem.Name = "사적일정ToolStripMenuItem";
            this.사적일정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.사적일정ToolStripMenuItem.Text = "사적일정";
            this.사적일정ToolStripMenuItem.Click += new System.EventHandler(this.사적일정ToolStripMenuItem_Click);
            // 
            // 자기계발ToolStripMenuItem
            // 
            this.자기계발ToolStripMenuItem.Name = "자기계발ToolStripMenuItem";
            this.자기계발ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자기계발ToolStripMenuItem.Text = "자기개발";
            this.자기계발ToolStripMenuItem.Click += new System.EventHandler(this.자기개발ToolStripMenuItem_Click);
            // 
            // 취미생활ToolStripMenuItem
            // 
            this.취미생활ToolStripMenuItem.Name = "취미생활ToolStripMenuItem";
            this.취미생활ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.취미생활ToolStripMenuItem.Text = "취미생활";
            this.취미생활ToolStripMenuItem.Click += new System.EventHandler(this.취미생활ToolStripMenuItem_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(774, 20);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(105, 22);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "캘린더 이동";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(803, 74);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(66, 18);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "검색하기";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(788, 113);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 35);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "추가";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(605, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 21);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SlateGray;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(788, 168);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 35);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "수정";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(788, 229);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(102, 35);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // TodoForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 526);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TodoForm1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Todo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodoForm1_FormClosing);
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
        private System.Windows.Forms.Button BtnExit;
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
    }
}