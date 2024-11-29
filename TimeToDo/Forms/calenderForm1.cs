using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            this.Load += new System.EventHandler(this.CalendarForm1_Load);
        }
        private void CalendarForm1_Load(object sender, EventArgs e)
        {
            // 로그인된 사용자 이름 설정
            username.Text = $"{Session.LoggedInUserId}";
        }
        private void addEvent_Click(object sender, EventArgs e)
        {
            AddForm1 addForm1 = new AddForm1(this);
            addForm1.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 선택된 항목이 있는지 확인
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 선택된 항목 가져오기
            ListViewItem selectedItem = listView1.SelectedItems[0];
            int selectedId = int.Parse(selectedItem.Tag.ToString()); // Tag에 저장된 Primary Key 사용
            string category = selectedItem.SubItems[0].Text;
            string time = selectedItem.SubItems[1].Text;
            string description = selectedItem.SubItems[2].Text;

            // repeats 값 처리
            string repeats = selectedItem.SubItems[3].Text;
            if (string.IsNullOrEmpty(repeats) || repeats.Equals("Null", StringComparison.OrdinalIgnoreCase))
            {
                repeats = "반복 없음"; // 기본값 설정
            }

            // 이후 작업 진행
            try
            {
                // 다음 작업 로직 작성
                MessageBox.Show($"선택된 항목: {selectedId}, {category}, {time}, {description}, {repeats}", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 예: 반복 작업 전달
                // YourLogicToProcess(selectedId, category, time, description, repeats);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"처리 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // editForm1 호출
            editForm1 editForm = new editForm1(selectedId, category, time, description, repeats);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // 리스트 새로고침
                btnRefresh_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 선택된 항목 확인
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("삭제할 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. 선택된 항목 가져오기
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Tag.ToString()); // Tag에 저장된 Primary Key 사용

                // 3. 사용자 확인
                var confirmResult = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // 4. DB에서 삭제
                    string deleteQuery = "DELETE FROM Calendar WHERE Id = :Id";
                    var parameters = new Dictionary<string, object>
            {
                { ":Id", selectedId }
            };

                    DBClass dbClass = new DBClass();
                    dbClass.DB_Open(deleteQuery, parameters);

                    // 5. 리스트에서 삭제
                    listView1.Items.Remove(selectedItem);

                    MessageBox.Show("일정이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 삭제하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                string query = "SELECT Id, Category, Time, Description, Repeats FROM Calendar WHERE USERSID = :UserId";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId }
                };

                DBClass dbClass = new DBClass(); // DBClass 인스턴스 생성
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["Time"]).ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(row["Description"].ToString());
                    item.SubItems.Add(row["Repeats"] != DBNull.Value ? row["Repeats"].ToString() : "Null");
                    item.Tag = row["Id"].ToString(); // Primary Key 저장

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("새로고침 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                // 선택된 날짜 가져오기
                DateTime selectedDate = calendar.SelectionRange.Start;

                // listView1 초기화
                listView1.Items.Clear();

                // 데이터베이스에서 해당 날짜에 해당하는 일정 불러오기 : userId로 불러오는 기능!!

                string query = "SELECT Id, Category, Time, Description, Repeats FROM Calendar " +
                               "WHERE USERSID = :UserId AND TRUNC(Time) = TRUNC(:SelectedDate)";
                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId },
                    { ":SelectedDate", selectedDate }
                };

                DBClass db = new DBClass();
                DataSet dataSet = db.DB_Open(query, parameters);

                // 가져온 데이터를 listView1에 추가
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["Time"]).ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(row["Description"].ToString());
                    item.SubItems.Add(row["Repeats"] != DBNull.Value ? row["Repeats"].ToString() : "Null");
                    item.Tag = row["Id"].ToString(); // Primary Key 저장

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("날짜에 해당하는 일정을 불러오는 중 오류가 발생했습니다: " + ex.Message,
                                "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoForm1 todoForm1 = new TodoForm1();
            todoForm1.Show();
            this.Hide();
        }


        private void calenderForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit(); // 애플리케이션 종료
        }

    }
}
