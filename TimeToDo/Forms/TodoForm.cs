using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace TimeToDo.Forms
{
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
        }

        private void InitializeListView()
        {
            // 체크박스 활성화
            listView1.CheckBoxes = true;

            // Details 모드 설정
            listView1.View = View.Details;

            // 컬럼 추가 (체크박스는 첫 번째 컬럼과 자동 연동)
            listView1.Columns.Add("번호", 50);
            listView1.Columns.Add("할 일", 200);
            listView1.Columns.Add("카테고리", 100);
            listView1.Columns.Add("우선순위", 100);
            listView1.Columns.Add("날짜", 100);
            listView1.Columns.Add("마감일", 100);

            // 예시 데이터 추가
            AddListViewItem("1", "코딩하기", "개발", "높음", "2024-11-21", "2024-11-30");
            AddListViewItem("2", "문서 작성", "기획", "중간", "2024-11-21", "2024-12-05");
            AddListViewItem("3", "회의 준비", "기획", "높음", "2024-11-22", "2024-11-25");
            AddListViewItem("4", "디자인 검토", "디자인", "낮음", "2024-11-23", "2024-12-01");
        }

        // 데이터를 추가하는 메서드
        private void AddListViewItem(string 번호, string 할일, string 카테고리, string 우선순위, string 날짜, string 마감일)
        {
            ListViewItem item = new ListViewItem(번호); // 첫 번째 컬럼 데이터
            item.SubItems.Add(할일);
            item.SubItems.Add(카테고리);
            item.SubItems.Add(우선순위);
            item.SubItems.Add(날짜);
            item.SubItems.Add(마감일);
            listView1.Items.Add(item);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
