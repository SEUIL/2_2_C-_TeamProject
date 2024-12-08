using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeToDo.Forms
{
    public partial class TodoSearchForm1 : MetroFramework.Forms.MetroForm
    {
        private string userId; // 현재 로그인된 사용자 ID
        private DBClass dbClass; // DB 클래스 객체 초기화

        public TodoSearchForm1(string loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId; // 사용자 ID 저장
            dbClass = new DBClass();
            InitializeListView(); // ListView 초기화
        }

        private void InitializeListView()
        {
            // ListView 설정
            listView2.CheckBoxes = true; // 체크박스 비활성화
            listView2.View = View.Details; // 자세히 보기 모드

            // 열 헤더 추가
            listView2.Columns.Add("할 일", 300);
            listView2.Columns.Add("카테고리", 100);
            listView2.Columns.Add("우선순위", 100);
            listView2.Columns.Add("날짜", 120);
            listView2.Columns.Add("마감일", 120);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = textBox1.Text.Trim(); // 검색어 가져오기

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    MessageBox.Show("검색어를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listView2.Items.Clear();
                    return;
                }

                // DateTimePicker에서 선택한 날짜 가져오기
                DateTime startDate = dateTimePicker1.Value.Date; // 시작 날짜
                DateTime endDate = dateTimePicker2.Value.Date; // 종료 날짜

                if (startDate > endDate)
                {
                    MessageBox.Show("시작 날짜는 종료 날짜보다 앞서야 합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listView2.Items.Clear();
                    return;
                }

                // SQL 쿼리 작성 (Task 열에서 키워드 검색 + 날짜 범위 조건)
                string query = @"SELECT ID, Task, Category, Priority, TodoDate, Deadline, IS_COMPLETED 
                 FROM Todolist 
                 WHERE USERID = :UserId 
                   AND Task LIKE :Keyword 
                   AND TodoDate BETWEEN :StartDate AND :EndDate
                   ORDER BY TodoDate ASC";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", userId }, // 유저 ID
            { ":Keyword", $"%{keyword}%" }, // 키워드 포함 검색
            { ":StartDate", startDate }, // 시작 날짜
            { ":EndDate", endDate } // 종료 날짜
        };

                // 데이터베이스에서 검색 결과 가져오기
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("검색 결과가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView2.Items.Clear();
                    return;
                }

                // 검색 결과를 ListView에 표시
                PopulateListView(dataSet.Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"검색 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateListView(DataTable dataTable)
        {
            listView2.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(row["Task"].ToString());
                item.SubItems.Add(row["Category"].ToString());
                item.SubItems.Add(row["Priority"].ToString());
                item.SubItems.Add(row["TodoDate"].ToString());
                item.SubItems.Add(row["Deadline"].ToString());
                item.Checked = row["IS_COMPLETED"].ToString() == "1"; // 완료 상태 설정
                item.Tag = row["ID"]; // ID 값 저장
                listView2.Items.Add(item);
            }
        }

        private void listView2_ItemChecked(object sender, ItemCheckedEventArgs e)
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

        // 폼 초기화 시 이벤트 핸들러 연결
        

    }
}
