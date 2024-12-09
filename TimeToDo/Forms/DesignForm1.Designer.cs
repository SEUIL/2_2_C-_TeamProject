using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimeToDo.Forms
{
    partial class DesignForm1
    {
        private System.ComponentModel.IContainer components = null;

        // UI 구성 요소 선언
        private Panel SideMenu;
        private Button TodoBtn;
        private Button CalendarBtn;
        private CheckBox SideCloseCheck;
        private Button HomeBtn;
        private Timer Sliding;
        private Panel childFormPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.TodoBtn = new System.Windows.Forms.Button();
            this.CalendarBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SideCloseCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.Sliding = new System.Windows.Forms.Timer(this.components);
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.SideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.SideMenu.Controls.Add(this.TodoBtn);
            this.SideMenu.Controls.Add(this.CalendarBtn);
            this.SideMenu.Controls.Add(this.HomeBtn);
            this.SideMenu.Controls.Add(this.SideCloseCheck);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(18, 60);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(175, 586);
            this.SideMenu.TabIndex = 0;
            // 
            // TodoBtn
            // 
            this.TodoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TodoBtn.FlatAppearance.BorderSize = 0;
            this.TodoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoBtn.Font = new System.Drawing.Font("Noto Sans KR SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TodoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TodoBtn.Location = new System.Drawing.Point(0, 160);
            this.TodoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TodoBtn.Name = "TodoBtn";
            this.TodoBtn.Size = new System.Drawing.Size(175, 40);
            this.TodoBtn.TabIndex = 3;
            this.TodoBtn.Text = "할 일 관리";
            this.TodoBtn.UseVisualStyleBackColor = true;
            this.TodoBtn.Click += new System.EventHandler(this.TodoBtn_Click);
            // 
            // CalendarBtn
            // 
            this.CalendarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarBtn.FlatAppearance.BorderSize = 0;
            this.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarBtn.Font = new System.Drawing.Font("Noto Sans KR SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalendarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalendarBtn.Location = new System.Drawing.Point(0, 120);
            this.CalendarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalendarBtn.Name = "CalendarBtn";
            this.CalendarBtn.Size = new System.Drawing.Size(175, 40);
            this.CalendarBtn.TabIndex = 2;
            this.CalendarBtn.Text = "일정 관리";
            this.CalendarBtn.UseVisualStyleBackColor = true;
            this.CalendarBtn.Click += new System.EventHandler(this.CalendarBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Noto Sans KR SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.HomeBtn.Size = new System.Drawing.Size(175, 120);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "홈";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // SideCloseCheck
            // 
            this.SideCloseCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.SideCloseCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideCloseCheck.FlatAppearance.BorderSize = 0;
            this.SideCloseCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideCloseCheck.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SideCloseCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideCloseCheck.Location = new System.Drawing.Point(0, 546);
            this.SideCloseCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideCloseCheck.Name = "SideCloseCheck";
            this.SideCloseCheck.Size = new System.Drawing.Size(175, 40);
            this.SideCloseCheck.TabIndex = 1;
            this.SideCloseCheck.Text = "<";
            this.SideCloseCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideCloseCheck.UseVisualStyleBackColor = true;
            this.SideCloseCheck.CheckedChanged += new System.EventHandler(this.SideCloseCheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.username);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(18, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 80);
            this.panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(15, 46);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(66, 18);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "로그아웃";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Font = new System.Drawing.Font("Noto Sans KR SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.username.Location = new System.Drawing.Point(3, 10);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(98, 21);
            this.username.TabIndex = 23;
            this.username.Text = "여기다가 이름";
            // 
            // Sliding
            // 
            this.Sliding.Interval = 10;
            this.Sliding.Tick += new System.EventHandler(this.Sliding_Tick);
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(193, 60);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(919, 586);
            this.childFormPanel.TabIndex = 1;
            // 
            // DesignForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.SideMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DesignForm1";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "TimeManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesignForm1_FormClosing);
            this.Load += new System.EventHandler(this.DesignForm1_Load);
            this.SideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label username;
        private Button logoutBtn;
    }
}
