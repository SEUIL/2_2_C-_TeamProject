using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeToDo.Forms;
using static TimeToDo.LoginForm1;

namespace TimeToDo
{

    public partial class calenderForm1 : Form
    {
        public ListView getListView1
        {
            get { return listView1; }
        }

        public calenderForm1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            AddForm1 addForm1 = new AddForm1(this);
            addForm1.ShowDialog();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // 종료 확인 메시지
            var result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // 애플리케이션 종료
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();

                // 로그인한 사용자의 캘린더 데이터 조회
                string query = "SELECT Category, Time, Description, Repeats FROM Calendar WHERE UserId = :UserId";
                DBClass db = new DBClass();
                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId }
                };

                DataSet dataSet = db.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["Time"]).ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(row["Description"].ToString());
                    item.SubItems.Add(row["Repeats"] != DBNull.Value ? row["Repeats"].ToString() : "Null");

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("새로고침 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
