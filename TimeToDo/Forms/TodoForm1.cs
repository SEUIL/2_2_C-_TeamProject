using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class TodoForm1 : MetroFramework.Forms.MetroForm
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
            listView.ItemChecked += listView_ItemChecked;

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

                string query = "SELECT ID, Task, Category, Priority, TodoDate, Deadline FROM Todolist WHERE USERID = :UserId ORDER BY TodoDate ASC";

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
            calenderForm1 calenderForm1 = new calenderForm1();
            calenderForm1.Show();
            this.Hide();
            
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

        private void 공적일정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
{
    // ListView 초기화
    listView.Items.Clear();

    // DateTimePicker에서 선택된 날짜 가져오기
    DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

    // Query 작성 (Category가 '공적 일정'이고 선택된 날짜 이후의 항목만 가져오기)
    string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline 
                     FROM Todolist 
                     WHERE USERID = :UserId AND Category = :Category AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

    // Parameter 추가
    var parameters = new Dictionary<string, object>
    {
        { ":UserId", Session.LoggedInUserId },
        { ":Category", "공적 일정" },
        { ":SelectedDate", selectedDate }
    };

    // 데이터베이스에서 데이터 가져오기
    DBClass dbClass = new DBClass();
    DataSet dataSet = dbClass.DB_Open(query, parameters);

    if (dataSet.Tables[0].Rows.Count == 0)
    {
        MessageBox.Show("선택한 날짜 이후의 '공적 일정' 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
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
    MessageBox.Show($"공적 일정을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
}

        }

        private void 사적일정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

                // Query 작성 (Category가 '사적 일정'이고 선택된 날짜 이후의 항목만 가져오기)
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline 
                     FROM Todolist 
                     WHERE USERID = :UserId AND Category = :Category AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                // Parameter 추가
                var parameters = new Dictionary<string, object>
    {
        { ":UserId", Session.LoggedInUserId },
        { ":Category", "사적 일정" },
        { ":SelectedDate", selectedDate }
    };

                // 데이터베이스에서 데이터 가져오기
                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("선택한 날짜 이후의 '사적 일정' 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                MessageBox.Show($"사적 일정을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 자기개발ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

                // Query 작성 (Category가 '자기 개발'이고 선택된 날짜 이후의 항목만 가져오기)
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline 
                     FROM Todolist 
                     WHERE USERID = :UserId AND Category = :Category AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                // Parameter 추가
                var parameters = new Dictionary<string, object>
    {
        { ":UserId", Session.LoggedInUserId },
        { ":Category", "자기 개발" },
        { ":SelectedDate", selectedDate }
    };

                // 데이터베이스에서 데이터 가져오기
                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("선택한 날짜 이후의 '자기 개발' 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                MessageBox.Show($"자기 개발을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 취미생활ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

                // Query 작성 (Category가 '취미 생활'이고 선택된 날짜 이후의 항목만 가져오기)
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline 
                     FROM Todolist 
                     WHERE USERID = :UserId AND Category = :Category AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                // Parameter 추가
                var parameters = new Dictionary<string, object>
    {
        { ":UserId", Session.LoggedInUserId },
        { ":Category", "취미 생활" },
        { ":SelectedDate", selectedDate }
    };

                // 데이터베이스에서 데이터 가져오기
                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("선택한 날짜 이후의 '취미 생활' 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                MessageBox.Show($"취미 생활을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 일반ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredDataByPriority("일반");
        }

        private void LoadFilteredDataByPriority(string priority)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

                // Query 작성 (Priority와 선택된 날짜 이후 필터링)
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline 
                     FROM Todolist 
                     WHERE USERID = :UserId AND Priority = :Priority AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                // Parameter 추가
                var parameters = new Dictionary<string, object>
    {
        { ":UserId", Session.LoggedInUserId },
        { ":Priority", priority }, // 전달된 Priority 값
        { ":SelectedDate", selectedDate } // 선택된 날짜
    };

                // 데이터베이스에서 데이터 가져오기
                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show($"{priority} 중요도 및 선택된 날짜 이후의 데이터가 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                MessageBox.Show($"데이터를 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 중요ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFilteredDataByPriority("중요");
        }

        private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (e.Item.Tag == null || !int.TryParse(e.Item.Tag.ToString(), out int todoId))
                {
                    MessageBox.Show("ID 값이 잘못되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 체크 상태에 따라 is_completed 값 설정
                int isCompleted = e.Item.Checked ? 1 : 0;

                // 데이터베이스 업데이트 쿼리
                string query = "UPDATE Todolist SET IS_COMPLETED = :IsCompleted WHERE ID = :Id";
                var parameters = new Dictionary<string, object>
        {
            { ":IsCompleted", isCompleted },
            { ":Id", todoId }
        };

                dbClass.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"완료 상태를 업데이트하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 완료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

                // 완료된 항목 중 선택된 날짜 이후의 데이터만 가져오기
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline, IS_COMPLETED 
                         FROM Todolist 
                         WHERE USERID = :UserId AND IS_COMPLETED = 1 AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId },
            { ":SelectedDate", selectedDate }
        };

                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("선택한 날짜 이후 완료된 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                    item.Checked = true; // 완료 상태로 설정
                    item.Tag = row["ID"] != DBNull.Value ? row["ID"].ToString() : null;

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"완료 항목을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 미완료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value.Date; // 시간 값 0시 0분으로 고정

                // 완료된 항목 중 선택된 날짜 이후의 데이터만 가져오기
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline, IS_COMPLETED 
                         FROM Todolist 
                         WHERE USERID = :UserId AND IS_COMPLETED = 0 AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId },
            { ":SelectedDate", selectedDate }
        };

                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("선택한 날짜 이후 미완료된 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(""); // ID 추가
                    item.SubItems.Add(row["Task"] != DBNull.Value ? row["Task"].ToString() : "");
                    item.SubItems.Add(row["Category"] != DBNull.Value ? row["Category"].ToString() : "");
                    item.SubItems.Add(row["Priority"] != DBNull.Value ? row["Priority"].ToString() : "");
                    item.SubItems.Add(row["TodoDate"] != DBNull.Value ? Convert.ToDateTime(row["TodoDate"]).ToString("yyyy-MM-dd") : "");
                    item.SubItems.Add(row["Deadline"] != DBNull.Value ? Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd") : "");
                    item.Checked = false;
                    item.Tag = row["ID"] != DBNull.Value ? row["ID"].ToString() : null;
                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"미완료 항목을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TodoForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 애플리케이션 종료
        }

        private void TodoForm1_Load(object sender, EventArgs e)
        {
            // DateTimePicker의 초기 값 설정
            dateTimePicker1.Value = DateTime.Today;

            // 초기 값 기준으로 투두 리스트 로드
            LoadTodoList();

        }
        private void LoadTodoList()
        {
            try
            {
                // ListView 초기화
                listView.Items.Clear();

                // DateTimePicker1에서 선택된 날짜 가져오기
                DateTime selectedDate = dateTimePicker1.Value;

                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline, IS_COMPLETED 
                     FROM Todolist 
                     WHERE USERID = :UserId AND TodoDate >= :SelectedDate ORDER BY TodoDate ASC";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId },
                    { ":SelectedDate", selectedDate }
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

                    if (row["IS_COMPLETED"] != DBNull.Value && Convert.ToInt32(row["IS_COMPLETED"]) == 1)
                    {
                        item.Checked = true; // 완료된 항목
                    }
                    else
                    {
                        item.Checked = false; // 미완료 항목
                    }

                    item.Tag = row["ID"] != DBNull.Value ? row["ID"].ToString() : null;

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"투두리스트 데이터를 로드하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadTodoList();
        }
    }
}
