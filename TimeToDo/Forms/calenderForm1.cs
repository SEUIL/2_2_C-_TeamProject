using System;
using System.Collections;
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

    public partial class calenderForm1 : MetroFramework.Forms.MetroForm
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

            listView1.ColumnClick += new ColumnClickEventHandler(listView1_ColumnClick); // ColumnClick 이벤트 연결
            listView2.ColumnClick += new ColumnClickEventHandler(listView2_ColumnClick);
        }

        private void CalendarForm1_Load(object sender, EventArgs e)//캘린더 폼 로드
        {
            // 로그인된 사용자 이름 설정
            username.Text = $"접속한 사용자 : {Session.LoggedInUserId}";

            // 폼 로드 시 "앞으로의 일정"에 전체 일정 표시
            btnRefresh_Click(sender, e);
            LoadUpcomingEvents();
        }

        private void addEvent_Click(object sender, EventArgs e)//일정추가
        {
            AddForm1 addForm1 = new AddForm1(this);
            addForm1.ShowDialog();

            btnRefresh_Click(sender, e); // 추가되면 한번 리로드
            LoadUpcomingEvents(); //listView2 최신화

        }

        private void btnEdit_Click(object sender, EventArgs e)//일정편집
        {
            // 선택된 항목이 있는지 확인
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 선택된 항목 가져오기
            ListViewItem selectedItem = listView1.SelectedItems[0];
            if (selectedItem.Tag == null)
            {
                MessageBox.Show("선택된 항목에 유효한 ID가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedId = int.Parse(selectedItem.Tag.ToString()); // Tag에 저장된 Primary Key 사용
            string category = selectedItem.SubItems[0].Text;
            string time = selectedItem.SubItems[1].Text;
            string description = selectedItem.SubItems[2].Text;
            string repeats = selectedItem.SubItems[3].Text;
            

            /*// 이후 작업 진행
            try
            {
                // 다음 작업 로직 작성
                MessageBox.Show($"선택된 항목: {selectedId}, {category}, {time}, {description}, {repeats}", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 예: 반복 작업 전달
                //YourLogicToProcess(selectedId, category, time, description, repeats);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"처리 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


            // editForm1 호출
            editForm1 editForm = new editForm1(selectedId, category, time, description, repeats);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // 리스트 새로고침
                btnRefresh_Click(sender, e);
                LoadUpcomingEvents(); //listView2 최신화
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//일정삭제
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

                    btnRefresh_Click(sender, e);
                    LoadUpcomingEvents(); //listView2 최신화
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 삭제하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) // listView 리로드
        {
            try
            {
                listView1.Items.Clear();

                string query = @"
            SELECT Id, Category, Time, Description, Repeats
            FROM Calendar 
            WHERE USERSID = :UserId
            ORDER BY Time ASC"; // 전체 일정을 시간 순으로 정렬

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId }
        };

                DBClass dbClass = new DBClass(); // DBClass 인스턴스 생성
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString());
                    DateTime startTime = Convert.ToDateTime(row["Time"]);
                    string repeats = row["Repeats"].ToString();

                    // 반복 여부에 따라 날짜 계산
                    DateTime currentDate = DateTime.Now;

                    // 반복이 없는 일정
                    if (repeats == "반복없음")
                    {
                        item.SubItems.Add(startTime.ToString("yyyy-MM-dd")); // 날짜만 추가
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add("반복 없음"); // "반복 없음" 명시적으로 추가
                    }
                    else if (repeats == "매일")
                    {
                        // 매일 반복: 오늘 날짜의 일정만 표시
                        item.SubItems.Add(startTime.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add("매일");
                    }
                    else if (repeats == "매주")
                    {
                        // 매주 반복: 이번 주의 동일한 요일에 맞는 일정
                        int daysToAdd = (int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek;
                        if (daysToAdd < 0) daysToAdd += 7; // 이번 주 일요일 이후

                        DateTime nextWeekDate = currentDate.AddDays(daysToAdd);
                        item.SubItems.Add(nextWeekDate.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add("매주");
                    }
                    else if (repeats == "매달")
                    {
                        // 매월 반복: 이번 달의 같은 날짜
                        DateTime nextMonthDate = new DateTime(currentDate.Year, currentDate.Month, startTime.Day);
                        if (nextMonthDate >= currentDate)
                        {
                            item.SubItems.Add(nextMonthDate.ToString("yyyy-MM-dd"));
                            item.SubItems.Add(row["Description"].ToString());
                            item.SubItems.Add("매달");
                        }
                    }
                    else if (repeats == "매년")
                    {
                        // 매년 반복: 이번 년도에 같은 날짜
                        DateTime nextYearDate = new DateTime(currentDate.Year, startTime.Month, startTime.Day);
                        if (nextYearDate >= currentDate)
                        {
                            item.SubItems.Add(nextYearDate.ToString("yyyy-MM-dd"));
                            item.SubItems.Add(row["Description"].ToString());
                            item.SubItems.Add("매년");
                        }
                    }
                    item.Tag = row["Id"].ToString();
                    listView1.Items.Add(item); // ListView에 항목 추가
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("새로고침 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUpcomingEvents()//앞으로의 일정(listView2) 불러오기기능
        {
            try
            {
                // "앞으로의 일정"을 표시하는 ListView 초기화
                listView2.Items.Clear();

                // 반복 일정에 대해 가장 가까운 날짜만 조회하는 쿼리
                string query = @"
                    SELECT Category, Time, Description, Repeats
                    FROM Calendar 
                    WHERE USERSID = :UserId 
                    AND Time >= SYSDATE-1
                    AND (
                        Repeats IS NULL 
                        OR (Repeats IS NOT NULL AND Time <= SYSDATE + INTERVAL '1' YEAR)
                    )
                    ORDER BY Time ASC";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId }
        };

                DBClass dbClass = new DBClass(); // DBClass 인스턴스 생성
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString());
                    DateTime startTime = Convert.ToDateTime(row["Time"]);
                    string repeats = row["Repeats"].ToString();

                    // 반복 여부에 따라 날짜 계산
                    DateTime currentDate = DateTime.Now;

                    // 반복이 없는 일정
                    if (repeats == "반복없음")
                    {
                        item.SubItems.Add(startTime.ToString("yyyy-MM-dd")); // 날짜만 추가
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add("반복 없음"); // "반복 없음" 명시적으로 추가
                    }
                    else if (repeats == "매일")
                    {
                        // 매일 반복: 오늘 날짜의 일정만 표시
                        item.SubItems.Add(startTime.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add("매일");
                    }
                    else if (repeats == "매주")
                    {
                        // 매주 반복: 이번 주의 동일한 요일에 맞는 일정
                        int daysToAdd = (int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek;
                        if (daysToAdd < 0) daysToAdd += 7; // 이번 주 일요일 이후

                        DateTime nextWeekDate = currentDate.AddDays(daysToAdd);
                        item.SubItems.Add(nextWeekDate.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add("매주");
                    }
                    else if (repeats == "매달")
                    {
                        // 매월 반복: 이번 달의 같은 날짜
                        DateTime nextMonthDate = new DateTime(currentDate.Year, currentDate.Month, startTime.Day);
                        if (nextMonthDate >= currentDate)
                        {
                            item.SubItems.Add(nextMonthDate.ToString("yyyy-MM-dd"));
                            item.SubItems.Add(row["Description"].ToString());
                            item.SubItems.Add("매달");
                        }
                    }
                    else if (repeats == "매년")
                    {
                        // 매년 반복: 이번 년도에 같은 날짜
                        DateTime nextYearDate = new DateTime(currentDate.Year, startTime.Month, startTime.Day);
                        if (nextYearDate >= currentDate)
                        {
                            item.SubItems.Add(nextYearDate.ToString("yyyy-MM-dd"));
                            item.SubItems.Add(row["Description"].ToString());
                            item.SubItems.Add("매년");
                        }
                    }

                    listView2.Items.Add(item); // ListView에 항목 추가
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 불러오는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)//캘린더에서 선택된 날짜 가져오기
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
                    item.SubItems.Add(Convert.ToDateTime(row["Time"]).ToString("yyyy-MM-dd"));
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

        private void btnSearch_Click(object sender, EventArgs e) //캘린더 검색기능
        {
            SearchForm1 searchForm1 = new SearchForm1();
            searchForm1.ShowDialog();

        }

        private void moveTodolist_Click(object sender, EventArgs e)//todolist이동
        {
            TodoForm1 todoForm1 = new TodoForm1();
            todoForm1.Show();
            this.Hide();
        }

        private void calenderForm1_FormClosing(object sender, FormClosingEventArgs e)//프로그램 종료기능
        {
            // 프로그램 종료
            Application.Exit();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)//열 정렬기능
        {
            // 클릭한 열 번호를 가져옴
            int columnIndex = e.Column;

            // 카테고리 열을 클릭했을 때 (0번 열: 카테고리)
            if (columnIndex == 0)
            {
                // 카테고리 기준으로 정렬
                listView1.ListViewItemSorter = new ListViewItemComparer(0, SortOrder.Ascending);
            }
            // 시간 열을 클릭했을 때 (1번 열: 시간)
            else if (columnIndex == 1)
            {
                // 시간 기준으로 정렬
                listView1.ListViewItemSorter = new ListViewItemComparer(1, SortOrder.Ascending);
            }

            // 정렬 실행
            listView1.Sort();
        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)//열 정렬기능
        {
            // 클릭한 열 번호를 가져옴
            int columnIndex = e.Column;

            // 카테고리 열을 클릭했을 때 (0번 열: 카테고리)
            if (columnIndex == 0)
            {
                // 카테고리 기준으로 정렬
                listView2.ListViewItemSorter = new ListViewItemComparer(0, SortOrder.Ascending);
            }
            // 시간 열을 클릭했을 때 (1번 열: 시간)
            else if (columnIndex == 1)
            {
                // 시간 기준으로 정렬
                listView2.ListViewItemSorter = new ListViewItemComparer(1, SortOrder.Ascending);
            }

            // 정렬 실행
            listView2.Sort();
        }

        //열 정렬기능 비지니스로직
        public class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;

            public ListViewItemComparer(int column, SortOrder order)
            {
                this.col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                ListViewItem itemX = (ListViewItem)x;
                ListViewItem itemY = (ListViewItem)y;

                int compareResult = 0;

                // 열 인덱스에 따라 비교
                if (col == 0) // 카테고리 비교
                {
                    compareResult = string.Compare(itemX.SubItems[col].Text, itemY.SubItems[col].Text);
                }
                else if (col == 1) // 시간 비교
                {
                    DateTime timeX = DateTime.Parse(itemX.SubItems[col].Text);
                    DateTime timeY = DateTime.Parse(itemY.SubItems[col].Text);
                    compareResult = timeX.CompareTo(timeY);
                }

                // 정렬 방향 처리
                if (order == SortOrder.Descending)
                    compareResult = -compareResult;

                return compareResult;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)//일정 자세히보기
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("자세히 볼 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (selectedItem.Tag == null)
                {
                    MessageBox.Show("선택된 항목에 유효한 ID가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedId = int.Parse(selectedItem.Tag.ToString()); // Tag에 저장된 Primary Key 사용
                string category = selectedItem.SubItems[0].Text;
                string time = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;
                string repeats = selectedItem.SubItems[3].Text;

                // editForm1 호출
                DetailForm1 editForm = new DetailForm1(selectedId, category, time, description, repeats);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 리스트 새로고침
                    btnRefresh_Click(sender, e);
                    LoadUpcomingEvents(); //listView2 최신화
                }
            }
        }

        private void btnLogout_CalendarForm_Click(object sender, EventArgs e)
        {
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
            this.Hide();
        }
    }
}
