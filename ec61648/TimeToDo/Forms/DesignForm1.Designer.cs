namespace TimeToDo.Forms
{
    partial class DesignForm1
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
            this.SideMenu = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.SideCloseCheck = new System.Windows.Forms.CheckBox();
            this.Sliding = new System.Windows.Forms.Timer(this.components);
            this.CalendarBtn = new System.Windows.Forms.Button();
            this.TodoBtn = new System.Windows.Forms.Button();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.SideMenu.Size = new System.Drawing.Size(200, 587);
            this.SideMenu.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(200, 40);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "홈";
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // SideCloseCheck
            // 
            this.SideCloseCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.SideCloseCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideCloseCheck.FlatAppearance.BorderSize = 0;
            this.SideCloseCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SideCloseCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.SideCloseCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideCloseCheck.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SideCloseCheck.Location = new System.Drawing.Point(0, 537);
            this.SideCloseCheck.Name = "SideCloseCheck";
            this.SideCloseCheck.Size = new System.Drawing.Size(200, 50);
            this.SideCloseCheck.TabIndex = 1;
            this.SideCloseCheck.Text = "<";
            this.SideCloseCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SideCloseCheck.UseVisualStyleBackColor = true;
            this.SideCloseCheck.CheckedChanged += new System.EventHandler(this.SideCloseCheck_CheckedChanged);
            // 
            // Sliding
            // 
            this.Sliding.Interval = 10;
            this.Sliding.Tick += new System.EventHandler(this.Sliding_Tick);
            // 
            // CalendarBtn
            // 
            this.CalendarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalendarBtn.FlatAppearance.BorderSize = 0;
            this.CalendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CalendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarBtn.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalendarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalendarBtn.Location = new System.Drawing.Point(0, 40);
            this.CalendarBtn.Name = "CalendarBtn";
            this.CalendarBtn.Size = new System.Drawing.Size(200, 40);
            this.CalendarBtn.TabIndex = 2;
            this.CalendarBtn.Text = "일정 관리";
            this.CalendarBtn.UseVisualStyleBackColor = true;
            // 
            // TodoBtn
            // 
            this.TodoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TodoBtn.FlatAppearance.BorderSize = 0;
            this.TodoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.TodoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.TodoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoBtn.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TodoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TodoBtn.Location = new System.Drawing.Point(0, 80);
            this.TodoBtn.Name = "TodoBtn";
            this.TodoBtn.Size = new System.Drawing.Size(200, 40);
            this.TodoBtn.TabIndex = 3;
            this.TodoBtn.Text = "할 일 관리";
            this.TodoBtn.UseVisualStyleBackColor = true;
            // 
            // DesignForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 587);
            this.Controls.Add(this.SideMenu);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "DesignForm1";
            this.Text = "<";
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.CheckBox SideCloseCheck;
        private System.Windows.Forms.Timer Sliding;
        private System.Windows.Forms.Button TodoBtn;
        private System.Windows.Forms.Button CalendarBtn;
    }
}