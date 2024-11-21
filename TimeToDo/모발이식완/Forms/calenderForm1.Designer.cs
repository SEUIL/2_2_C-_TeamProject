namespace TimeToDo
{
    partial class calenderForm1
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventCalendar = new System.Windows.Forms.Label();
            this.addEvent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calendar.Font = new System.Drawing.Font("굴림", 9F);
            this.calendar.Location = new System.Drawing.Point(18, 38);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "달력";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.time,
            this.descriptionEvent,
            this.repeats});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 269);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 227);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // category
            // 
            this.category.Text = "카테고리";
            this.category.Width = 76;
            // 
            // time
            // 
            this.time.Text = "시간";
            this.time.Width = 99;
            // 
            // descriptionEvent
            // 
            this.descriptionEvent.Text = "일정 상세";
            this.descriptionEvent.Width = 193;
            // 
            // repeats
            // 
            this.repeats.Text = "일정 반복";
            this.repeats.Width = 86;
            // 
            // eventCalendar
            // 
            this.eventCalendar.AutoSize = true;
            this.eventCalendar.Font = new System.Drawing.Font("굴림", 15F);
            this.eventCalendar.Location = new System.Drawing.Point(315, 246);
            this.eventCalendar.Name = "eventCalendar";
            this.eventCalendar.Size = new System.Drawing.Size(49, 20);
            this.eventCalendar.TabIndex = 3;
            this.eventCalendar.Text = "일정";
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(15, 502);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(81, 37);
            this.addEvent.TabIndex = 4;
            this.addEvent.Text = "일정 추가";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "일정 편집";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "일정 삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(276, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "반복 설정";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "일정 검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightCoral;
            this.BtnExit.Location = new System.Drawing.Point(581, 502);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(105, 37);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "프로그램 종료";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(609, 234);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 32);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // calenderForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 556);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.eventCalendar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar);
            this.Name = "calenderForm1";
            this.Text = "calenderForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label eventCalendar;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader descriptionEvent;
        private System.Windows.Forms.ColumnHeader repeats;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnRefresh;
    }
}