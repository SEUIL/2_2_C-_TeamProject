using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TimeToDo.LoginForm1;

namespace TimeToDo
{
    public partial class SearchForm1 : MetroFramework.Forms.MetroForm
    {

        private string userId; // 현재 로그인된 사용자 ID
        private DBClass dbClass; // DB 클래스 객체 초기화

        public SearchForm1()
        {
            InitializeComponent();
            dbClass = new DBClass();
        }

        private void SearchForm1_Load(object sender, EventArgs e)
        {
            userId = Session.LoggedInUserId;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 검색어 가져오기
            string searchKeyword = txtSearch.Text.Trim();

            // 날짜 가져오기
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            // 유효성 검사
            if (startDate > endDate)
            {
                MessageBox.Show("시작 날짜는 끝 날짜보다 이전이어야 합니다.", "유효성 검사 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 데이터베이스에서 데이터 가져오기
            DataTable results = dbClass.GetSearchResults(userId, searchKeyword, startDate, endDate);


            // listView1 초기화
            listView1.Items.Clear();

            // 결과 표시
            foreach (DataRow row in results.Rows)
            {
                ListViewItem item = new ListViewItem(row["category"].ToString()); // 카테고리
                item.SubItems.Add(row["time"].ToString()); // 시간
                item.SubItems.Add(row["description"].ToString()); // 일정 상세
                item.SubItems.Add(row["repeats"].ToString()); // 일정 반복 여부
                listView1.Items.Add(item);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
