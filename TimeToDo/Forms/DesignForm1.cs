using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class DesignForm1 : MetroFramework.Forms.MetroForm
    {
        private void DesignForm1_Load(object sender, EventArgs e)
        {
            // 로그인된 사용자 이름 설정
            username.Text = $"환영합니다 {Session.LoggedInUserId}!";
            LoadChildControl(new HomeForm1());
        }


        //사이드메뉴 열고닫고
        private const int MAX_SLIDING_WIDTH = 200;
        private const int MIN_SLIDING_WIDTH = 50;
        private const int STEP_SLIDING = 10;
        private int _posSliding = 200; // 초기 폭 크기
        private bool _isMenuExpanded = true; // 메뉴 상태

        public DesignForm1()
        {
            InitializeComponent(); // Designer.cs에서 정의된 구성 요소를 초기화합니다.
        }

        // 사이드 메뉴 슬라이딩 이벤트
        private void SideCloseCheck_CheckedChanged(object sender, EventArgs e)
        {
            // 메뉴 상태 전환
            _isMenuExpanded = !_isMenuExpanded;
            Sliding.Start(); // 타이머 시작
        }

        private void Sliding_Tick(object sender, EventArgs e)
        {
            // 메뉴 확장 또는 축소 동작
            if (_isMenuExpanded)
            {
                // 메뉴를 펼치는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                {
                    _posSliding = MAX_SLIDING_WIDTH;
                    Sliding.Stop();
                    SideCloseCheck.Text = "<"; // 접기 상태 표시
                    TodoBtn.Text = "할 일 관리";
                    CalendarBtn.Text = "일정 관리";
                    panel1.Visible = true;
                    panel1.Size = new System.Drawing.Size(200, 80);
                }
            }
            else
            {
                // 메뉴를 접는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                {
                    _posSliding = MIN_SLIDING_WIDTH;
                    Sliding.Stop();
                    SideCloseCheck.Text = ">"; // 펼치기 상태 표시
                    TodoBtn.Text = "할 일";
                    CalendarBtn.Text = "일정";
                    panel1.Visible = false;

                }
            }

            // SideMenu 폭 업데이트
            SideMenu.Width = _posSliding;
        }

        // 자식 폼 로드 메서드
        private void LoadChildControl(Control childControl)
        {
            childFormPanel.Controls.Clear();

            childControl.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childControl);
        }


        //자식 폼 로드
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LoadChildControl(new HomeForm1());
        }
        
        private void TodoBtn_Click(object sender, EventArgs e)
        {
            LoadChildControl(new TodoForm1());
        }

        private void CalendarBtn_Click(object sender, EventArgs e)
        {
            LoadChildControl(new calenderForm1());
        }

        // 애플리케이션 종료
        private void DesignForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
            this.Close(); 
        }
    }
}
