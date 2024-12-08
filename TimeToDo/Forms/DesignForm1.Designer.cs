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
            this.SideCloseCheck = new System.Windows.Forms.CheckBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.Sliding = new System.Windows.Forms.Timer(this.components);
            this.childFormPanel = new System.Windows.Forms.Panel();

            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.SideMenu.Controls.Add(this.TodoBtn);
            this.SideMenu.Controls.Add(this.CalendarBtn);
            this.SideMenu.Controls.Add(this.SideCloseCheck);
            this.SideMenu.Controls.Add(this.HomeBtn);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(200, 600);
            this.SideMenu.TabIndex = 0;
            // SideMenu 설정
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Width = 200;
            this.SideMenu.Controls.Add(this.SideCloseCheck);

            // 
            // TodoBtn
            // 
            this.TodoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TodoBtn.FlatAppearance.BorderSize = 0;
            this.TodoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoBtn.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TodoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TodoBtn.Location = new System.Drawing.Point(0, 100);
            this.TodoBtn.Name = "TodoBtn";
            this.TodoBtn.Size = new System.Drawing.Size(200, 50);
            this.TodoBtn.TabIndex = 3;
            this.TodoBtn.Text = "할 일 관리";
            this.TodoBtn.UseVisualStyleBackColor = true;

            // 
            // CalendarBtn
            // 
            this.CalendarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarBtn.FlatAppearance.BorderSize = 0;
            this.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarBtn.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalendarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalendarBtn.Location = new System.Drawing.Point(0, 50);
            this.CalendarBtn.Name = "CalendarBtn";
            this.CalendarBtn.Size = new System.Drawing.Size(200, 50);
            this.CalendarBtn.TabIndex = 2;
            this.CalendarBtn.Text = "일정 관리";
            this.CalendarBtn.UseVisualStyleBackColor = true;

            // 
            // SideCloseCheck
            // 
            this.SideCloseCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.SideCloseCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideCloseCheck.FlatAppearance.BorderSize = 0;
            this.SideCloseCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideCloseCheck.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SideCloseCheck.Location = new System.Drawing.Point(0, 550);
            this.SideCloseCheck.Name = "SideCloseCheck";
            this.SideCloseCheck.Size = new System.Drawing.Size(200, 50);
            this.SideCloseCheck.TabIndex = 1;
            this.SideCloseCheck.Text = "<";
            this.SideCloseCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideCloseCheck.UseVisualStyleBackColor = true;
            // SideCloseCheck 설정
            this.SideCloseCheck.Text = "<";
            this.SideCloseCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideCloseCheck.CheckedChanged += new System.EventHandler(this.SideCloseCheck_CheckedChanged);

            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(200, 50);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "홈";
            this.HomeBtn.UseVisualStyleBackColor = true;

            // 
            // Sliding
            // 
            // Sliding 타이머 설정
            this.Sliding.Interval = 10;
            this.Sliding.Tick += new System.EventHandler(this.Sliding_Tick);

            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(200, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(600, 600);
            this.childFormPanel.TabIndex = 1;

            // 
            // DesignForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.SideMenu);
            this.Name = "DesignForm1";
            this.Text = "TimeManager";
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
