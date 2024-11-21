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

            // 컬럼 추가
            listView1.Columns.Add("번호", 50);
            listView1.Columns.Add("할일", 200);
            listView1.Columns.Add("카테고리", 100);
            listView1.Columns.Add("우선순위", 100);
            listView1.Columns.Add("날짜", 100);
            listView1.Columns.Add("마감일", 100);

            // 샘플 데이터 추가
            ListViewItem item1 = new ListViewItem("1");
            item1.SubItems.Add("코딩하기");
            item1.SubItems.Add("개발");
            item1.SubItems.Add("높음");
            item1.SubItems.Add("2024-11-21");
            item1.SubItems.Add("2024-11-30");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("2");
            item2.SubItems.Add("문서 작성");
            item2.SubItems.Add("기획");
            item2.SubItems.Add("중간");
            item2.SubItems.Add("2024-11-21");
            item2.SubItems.Add("2024-12-05");
            listView1.Items.Add(item2);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
