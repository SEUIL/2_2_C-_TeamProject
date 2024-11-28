using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class TodoForm1 : Form
    {
        private DBClass dbClass;
        public void AddItemToListView(ListViewItem item)
        {
            listView.Items.Add(item);
        }
        public TodoForm1()
        {
            InitializeComponent();
            dbClass = new DBClass(); // DBClass 객체 초기화
            InitializeListView();


        }

        private void InitializeListView()
        {
            // ListView 설정
            listView.CheckBoxes = true;
            listView.View = View.Details;

            // 열 헤더 추가
            
            listView.Columns.Add("Task", 200);
            listView.Columns.Add("Category", 100);
            listView.Columns.Add("Priority", 100);
            listView.Columns.Add("Todo Date", 120);
            listView.Columns.Add("Deadline", 120);
        }



        


        private void btnLoadTodoList_Click(object sender, EventArgs e)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                string query = "SELECT ID, Task, Category, Priority, TodoDate, Deadline FROM Todolist WHERE USERID = :UserId";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId }
        };

                // 데이터베이스에서 데이터 가져오기
                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    
                    return; // 데이터가 없으면 로직 종료
                }




                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // ListView에 항목 추가
                    ListViewItem item = new ListViewItem(""); // ID 추가
                    item.SubItems.Add(row["Task"] != DBNull.Value ? row["Task"].ToString() : "");
                    item.SubItems.Add(row["Category"] != DBNull.Value ? row["Category"].ToString() : "");
                    item.SubItems.Add(row["Priority"] != DBNull.Value ? row["Priority"].ToString() : "");
                    item.SubItems.Add(row["TodoDate"] != DBNull.Value ? Convert.ToDateTime(row["TodoDate"]).ToString("yyyy-MM-dd") : "");
                    item.SubItems.Add(row["Deadline"] != DBNull.Value ? Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd") : "");

                    item.Tag = row["ID"] != DBNull.Value ? row["ID"].ToString() : null;

                    listView.Items.Add(item);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"투두리스트 데이터를 로드하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // 날짜 변환 메서드
        private string ConvertToDateString(object dateObj)
        {
            if (dateObj != DBNull.Value)
            {
                return Convert.ToDateTime(dateObj).ToString("yyyy-MM-dd");
            }
            return ""; // 값이 없으면 빈 문자열 반환
        }

        public void RefreshListView()
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                string query = "SELECT ID, Task, Category, Priority, TodoDate, Deadline FROM Todolist WHERE USERID = :UserId";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId }
        };

                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    // ID 값을 태그로 설정하여 ListViewItem 생성
                    ListViewItem item = new ListViewItem();
                    item.Tag = row["ID"].ToString(); // ID를 태그로 설정
                    item.SubItems.Add(row["Task"] != DBNull.Value ? row["Task"].ToString() : "");
                    item.SubItems.Add(row["Category"] != DBNull.Value ? row["Category"].ToString() : "");
                    item.SubItems.Add(row["Priority"] != DBNull.Value ? row["Priority"].ToString() : "");
                    item.SubItems.Add(row["TodoDate"] != DBNull.Value ? Convert.ToDateTime(row["TodoDate"]).ToString("yyyy-MM-dd") : "");
                    item.SubItems.Add(row["Deadline"] != DBNull.Value ? Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd") : "");

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"리스트를 새로고침하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            TodoAddForm1 todoaddForm1 = new TodoAddForm1(this);
            todoaddForm1.ShowDialog();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 체크된 항목 가져오기
                var checkedItems = listView.Items.Cast<ListViewItem>().Where(item => item.Checked).ToList();

                if (checkedItems.Count == 0)
                {
                    MessageBox.Show("삭제할 항목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var selectedItem in checkedItems)
                {
                    // Tag 속성에서 ID 가져오기
                    if (selectedItem.Tag == null || !int.TryParse(selectedItem.Tag.ToString(), out int id))
                    {
                        MessageBox.Show("ID 값이 잘못되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // DB에서 삭제
                    string deleteQuery = "DELETE FROM Todolist WHERE ID = :Id";
                    var parameters = new Dictionary<string, object>
            {
                { ":Id", id }
            };

                    dbClass.ExecuteNonQuery(deleteQuery, parameters);

                    // 리스트뷰에서 항목 제거
                    listView.Items.Remove(selectedItem);
                }

                MessageBox.Show("선택된 항목이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("항목을 삭제하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            TodoSearchForm1 todoSearchForm1 = new TodoSearchForm1(Session.LoggedInUserId);
            todoSearchForm1.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 항목을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 선택된 항목 가져오기
            ListViewItem selectedItem = listView.SelectedItems[0];

            // 선택된 항목의 ID를 Tag 속성에서 가져오기
            if (selectedItem.Tag == null || !int.TryParse(selectedItem.Tag.ToString(), out int todoId))
            {
                MessageBox.Show("유효하지 않은 ID입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Task, Category, Priority 추출
            string task = selectedItem.SubItems[1].Text;
            string category = selectedItem.SubItems[2].Text;
            string priority = selectedItem.SubItems[3].Text;

            MessageBox.Show($"TodoDate 값: {selectedItem.SubItems[4].Text}, Deadline 값: {selectedItem.SubItems[5].Text}");


            // TodoDate와 Deadline 값 검증 후 변환
            DateTime todoDate;
            DateTime deadline;

            if (!DateTime.TryParse(selectedItem.SubItems[4].Text, out todoDate))
            {
                MessageBox.Show("유효하지 않은 시작 날짜 형식입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(selectedItem.SubItems[5].Text, out deadline))
            {
                MessageBox.Show("유효하지 않은 마감 날짜 형식입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TodoEditForm1 열기
            TodoEditForm1 editForm = new TodoEditForm1(todoId, task, category, priority, todoDate, deadline, this);
            editForm.ShowDialog();
        }


    }
}
