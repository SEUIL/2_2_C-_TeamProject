using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class HomeForm1 : MetroFramework.Controls.MetroUserControl
    {
        public ListView getListView1
        {
            get { return listView2; } // listView1은 홈 폼에서 사용하는 ListView의 이름
        }
        public ListView getListView2
        {
            get { return listView1; } // listView1은 홈 폼에서 사용하는 ListView의 이름
        }

        public HomeForm1()
        {
            InitializeComponent();
        }
        private void InitializeListView()
        {
            listView.CheckBoxes = true;
            listView.View = View.Details;
           
            listView.ItemChecked += listView_ItemChecked;
        }
            private void HomeForm1_Load(object sender, EventArgs e)
        {
            InitializeListView();
            LoadTodayEvents(); // 오늘의 일정 로드
            LoadUpcomingEventsFromTomorrow();
            LoadUncompletedTodos();
        }

        private void LoadTodayEvents()
        {
            try
            {
                listView2.Items.Clear();

                string query = @"
                SELECT Id, Category, Time, Description, Repeats
                FROM Calendar
                WHERE USERSID = :UserId
                AND TRUNC(Time) = TRUNC(SYSDATE)
                ORDER BY Time ASC";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId }
                };

                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString())
                    {
                        Tag = row["Id"].ToString() // ID를 Tag로 저장
                    };
                    item.SubItems.Add(Convert.ToDateTime(row["Time"]).ToString("yyyy-MM-dd HH:mm"));
                    item.SubItems.Add(row["Description"].ToString());
                    item.SubItems.Add(row["Repeats"]?.ToString() ?? "반복 없음");
                    listView2.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오늘의 일정을 불러오는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUpcomingEventsFromTomorrow()
        {
            try
            {
                listView1.Items.Clear();

                string query = @"
                SELECT Id, Category, Time, Description, Repeats
                FROM Calendar
                WHERE USERSID = :UserId
                AND TRUNC(Time) > TRUNC(SYSDATE)
                ORDER BY Time ASC";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId }
                };

                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Category"].ToString())
                    {
                        Tag = row["Id"].ToString() // ID를 Tag로 저장
                    };
                    item.SubItems.Add(Convert.ToDateTime(row["Time"]).ToString("yyyy-MM-dd HH:mm"));
                    item.SubItems.Add(row["Description"].ToString());
                    item.SubItems.Add(row["Repeats"]?.ToString() ?? "반복 없음");
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("내일부터의 일정을 불러오는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUncompletedTodos()
        {
            try
            {
                listView.Items.Clear();

                string query = @"
                SELECT ID, Task, Category, Priority, TodoDate, Deadline
                FROM Todolist
                WHERE USERID = :UserId
                AND IS_COMPLETED = 0
                ORDER BY TodoDate ASC";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId }
                };

                DBClass dbClass = new DBClass();
                DataSet dataSet = dbClass.DB_Open(query, parameters);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem(""); // ID는 화면에 표시하지 않음
                    item.SubItems.Add(row["Task"]?.ToString() ?? "");
                    item.SubItems.Add(row["Category"]?.ToString() ?? "");
                    item.SubItems.Add(row["Priority"]?.ToString() ?? "");
                    item.SubItems.Add(row["TodoDate"] != DBNull.Value ? Convert.ToDateTime(row["TodoDate"]).ToString("yyyy-MM-dd") : "");
                    item.SubItems.Add(row["Deadline"] != DBNull.Value ? Convert.ToDateTime(row["Deadline"]).ToString("yyyy-MM-dd") : "");
                    item.Tag = row["ID"]?.ToString(); // ID를 Tag로 저장
                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("미완료된 할 일을 불러오는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 항목 체크 시 DB 업데이트
        private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (e.Item.Tag == null || !int.TryParse(e.Item.Tag.ToString(), out int todoId))
                {
                    MessageBox.Show("ID 값이 잘못되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int isCompleted = e.Item.Checked ? 1 : 0;

                string query = "UPDATE Todolist SET IS_COMPLETED = :IsCompleted WHERE ID = :Id";
                var parameters = new Dictionary<string, object>
                {
                    { ":IsCompleted", isCompleted },
                    { ":Id", todoId }
                };

                DBClass dbClass = new DBClass();
                dbClass.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"완료 상태 업데이트 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("삭제할 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem selectedItem = listView2.SelectedItems[0];
                if (selectedItem.Tag == null || !int.TryParse(selectedItem.Tag.ToString(), out int selectedId))
                {
                    MessageBox.Show("선택된 일정의 ID가 잘못되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM Calendar WHERE Id = :Id";
                    var parameters = new Dictionary<string, object>
                    {
                        { ":Id", selectedId }
                    };

                    DBClass dbClass = new DBClass();
                    dbClass.ExecuteNonQuery(deleteQuery, parameters);

                    listView2.Items.Remove(selectedItem);
                    MessageBox.Show("일정이 삭제되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"일정 삭제 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click1(object sender, EventArgs e) // listView 리로드
        {
            try
            {
                listView2.Items.Clear();

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
                    listView2.Items.Add(item); // ListView에 항목 추가
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("새로고침 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUpcomingEvents1()//앞으로의 일정(listView2) 불러오기기능
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
        private void button4_Click(object sender, EventArgs e)
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

                    btnRefresh_Click2(sender, e);
                    LoadUpcomingEvents2(); //listView2 최신화
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 삭제하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click2(object sender, EventArgs e) // listView 리로드
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
        private void LoadUpcomingEvents2()//앞으로의 일정(listView2) 불러오기기능
        {
            try
            {
                // "앞으로의 일정"을 표시하는 ListView 초기화
                listView1.Items.Clear();

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

                    listView1.Items.Add(item); // ListView에 항목 추가
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 불러오는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                int deletedCount = 0;

                foreach (var selectedItem in checkedItems)
                {
                    try
                    {
                        // Tag 속성에서 ID 가져오기
                        if (selectedItem.Tag == null || !int.TryParse(selectedItem.Tag.ToString(), out int id))
                        {
                            MessageBox.Show($"항목의 ID가 유효하지 않습니다. Tag 값: {selectedItem.Tag}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        // DB에서 삭제
                        string deleteQuery = "DELETE FROM Todolist WHERE ID = :Id";
                        var parameters = new Dictionary<string, object>
                {
                    { ":Id", id }
                };
                        DBClass dbClass = new DBClass();
                        dbClass.DB_Open(deleteQuery, parameters);
                        dbClass.ExecuteNonQuery(deleteQuery, parameters);

                        // 리스트뷰에서 항목 제거
                        listView.Items.Remove(selectedItem);
                        deletedCount++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"항목(ID: {selectedItem.Tag})을 삭제하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // 삭제 결과 메시지
                if (deletedCount > 0)
                {
                    MessageBox.Show($"{deletedCount}개의 항목이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("삭제된 항목이 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("항목을 삭제하는 중 예외가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            TodoAddForm1 todoaddForm1 = new TodoAddForm1(this);
            todoaddForm1.ShowDialog();

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

            // 선택된 항목의 ID를 Tag에서 가져오기
            if (selectedItem.Tag == null)
            {
                MessageBox.Show("유효하지 않은 ID입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string todoId = selectedItem.Tag.ToString(); // 문자열로 처리

            string task = selectedItem.SubItems[1].Text;
            string category = selectedItem.SubItems[2].Text;
            string priority = selectedItem.SubItems[3].Text;

            if (!DateTime.TryParse(selectedItem.SubItems[4].Text, out DateTime todoDate))
            {
                MessageBox.Show("유효하지 않은 시작 날짜 형식입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(selectedItem.SubItems[5].Text, out DateTime deadline))
            {
                MessageBox.Show("유효하지 않은 마감 날짜 형식입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TodoEditForm1 열기
            TodoEditForm1 editForm = new TodoEditForm1(todoId, task, category, priority, todoDate, deadline, this);
            editForm.ShowDialog();
        }
        internal void AddItemToListView(ListViewItem item)
        {
            listView.Items.Add(item);
        }

        internal void UpdateListViewItem(string todoId, string task, string category, string priority, DateTime todoDate, DateTime deadline, bool isCompleted)
        {
            try
            {
                // ListView에서 특정 ID를 가진 항목 찾기
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.Tag != null && item.Tag.ToString() == todoId)
                    {
                        // 해당 항목의 데이터를 업데이트
                        item.SubItems[1].Text = task;        // Task
                        item.SubItems[2].Text = category;    // Category
                        item.SubItems[3].Text = priority;    // Priority
                        item.SubItems[4].Text = todoDate.ToString("yyyy-MM-dd"); // TodoDate
                        item.SubItems[5].Text = deadline.ToString("yyyy-MM-dd"); // Deadline
                        item.Checked = isCompleted;         // 완료 여부

                        // 업데이트 완료 후 종료
                        return;
                    }
                }

                // 항목을 찾지 못한 경우
                MessageBox.Show($"ID가 {todoId}인 항목을 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"항목 업데이트 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                AddForm1 addForm1 = new AddForm1(this);
                addForm1.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddForm1 addForm1 = new AddForm1(this);
            addForm1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 선택된 항목이 있는지 확인
                if (listView2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("수정할 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 선택된 항목 가져오기
                ListViewItem selectedItem = listView2.SelectedItems[0];
                if (selectedItem.Tag == null || !int.TryParse(selectedItem.Tag.ToString(), out int selectedId))
                {
                    MessageBox.Show("선택된 항목에 유효한 ID가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string category = selectedItem.SubItems[0].Text;
                string time = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;
                string repeats = selectedItem.SubItems[3].Text;

                // editForm1 호출
                editForm1 editForm = new editForm1(selectedId, category, time, description, repeats);

                // 수정 창을 모달로 표시
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 수정 후 ListView 리프레시
                    LoadTodayEvents(); // 오늘의 일정 새로고침
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"일정 수정 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 선택된 항목이 있는지 확인
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("수정할 일정을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 선택된 항목 가져오기
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (selectedItem.Tag == null || !int.TryParse(selectedItem.Tag.ToString(), out int selectedId))
                {
                    MessageBox.Show("선택된 항목에 유효한 ID가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string category = selectedItem.SubItems[0].Text;
                string time = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;
                string repeats = selectedItem.SubItems[3].Text;

                // editForm1 호출
                editForm1 editForm = new editForm1(selectedId, category, time, description, repeats);

                // 수정 창을 모달로 표시
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 수정 후 ListView 리프레시
                    LoadUpcomingEventsFromTomorrow(); // 오늘의 일정 새로고침
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"일정 수정 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
