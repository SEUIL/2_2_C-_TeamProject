using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToDo.Forms
{
   

    public partial class DesignForm1 : MetroFramework.Forms.MetroForm
    {
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 200;
        const int MIN_SLIDING_WIDTH = 50;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 200;
        public DesignForm1()
        {
            InitializeComponent();
        }

        private void SideCloseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SideCloseCheck.Checked == true)
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
            
                HomeBtn.Text = "홈";
                CalendarBtn.Text = "일정";
                TodoBtn.Text = "할 일";
                SideCloseCheck.Text = ">";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                HomeBtn.Text = "홈";
                CalendarBtn.Text = "일정 관리";
                TodoBtn.Text = "할 일 관리";
                SideCloseCheck.Text = "<";
            }

            //타이머 시작
            Sliding.Start();
        }

        private void Sliding_Tick(object sender, EventArgs e)
        {
            if (SideCloseCheck.Checked == true)
            {
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding -= STEP_SLIDING;
                if (_posSliding <= MIN_SLIDING_WIDTH)
                    Sliding.Stop();
            }
            else
            {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding += STEP_SLIDING;
                if (_posSliding >= MAX_SLIDING_WIDTH)
                    Sliding.Stop();
            }

            SideMenu.Width = _posSliding;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
