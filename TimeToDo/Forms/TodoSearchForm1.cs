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
                    return;
                }

                // SQL 쿼리 작성 (Task 열에서 키워드 검색)
                string query = "SELECT ID, Task, Category, Priority, TodoDate, Deadline, IS_COMPLETED FROM Todolist WHERE USERID = :UserId AND Task LIKE :Keyword";

                

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", userId }, // 문자열로 처리
                    { ":Keyword", $"%{keyword}%" } // 키워드 포함 검색
                };

                // 데이터베이스에서 검색 결과 가져오기
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("검색 결과가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PopulateListView(DataTable searchResults)
        {
            listView2.Items.Clear(); // 기존 항목 제거

            foreach (DataRow row in searchResults.Rows)
            {
                // 첫 번째 열은 비워두고, 데이터를 두 번째 열부터 추가
                ListViewItem item = new ListViewItem(""); // 첫 번째 열 비우기
                item.SubItems.Add(row["Task"] != DBNull.Value ? row["Task"].ToString() : ""); // 두 번째 열
                item.SubItems.Add(row["Category"] != DBNull.Value ? row["Category"].ToString() : ""); // 세 번째 열
                item.SubItems.Add(row["Priority"] != DBNull.Value ? row["Priority"].ToString() : ""); // 네 번째 열
                item.SubItems.Add(row["TodoDate"] != DBNull.Value ? Convert.ToDateTime(row["TodoDate"]).ToString("yyyy-MM-dd") : ""); // 다섯 번째 열
                item.SubItems.Add(row["Deadline"] != DBNull.Value ? Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd") : ""); // 여섯 번째 열

                if (row["IS_COMPLETED"] != DBNull.Value && Convert.ToInt32(row["IS_COMPLETED"]) == 1)
                {
                    item.Checked = true; // 완료된 항목
                }
                else
                {
                    item.Checked = false; // 미완료 항목
                }

                listView2.Items.Add(item); // ListView에 항목 추가
            }
        }
    }
}
