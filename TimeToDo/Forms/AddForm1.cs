using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class AddForm1 : MetroFramework.Forms.MetroForm
    {
        private calenderForm1 _calendarForm; // 캘린더 폼 참조
        private HomeForm1 _homeForm;         // 홈 폼 참조
        private DBClass dbClass = new DBClass();

        // 생성자: 캘린더 폼에서 호출
        public AddForm1(calenderForm1 calendarForm)
        {
            InitializeComponent();
            _calendarForm = calendarForm; // 캘린더 폼 참조 저장
        }

        // 생성자: 홈 폼에서 호출
        public AddForm1(HomeForm1 homeForm)
        {
            InitializeComponent();
            _homeForm = homeForm; // 홈 폼 참조 저장
        }

        private void btnSummit_addForm_Click(object sender, EventArgs e)
        {
            try
            {
                string category = comboCategory_addForm.Text;
                DateTime time = date_detailForm.Value;
                string description = txtDescription_addForm.Text;
                string repeats = txtRepeats_detailForm.Text;

                // 입력 값 검증
                if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("카테고리와 일정 상세를 입력해야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // DB에 값 삽입
                string insertQuery = "INSERT INTO Calendar (ID, USERSID, Category, Time, Description, Repeats) " +
                                     "VALUES (SEQ_CALENDAR.NEXTVAL, :UserId, :Category, :Time, :Description, :Repeats) RETURNING ID INTO :InsertedID";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId },
                    { ":Category", category },
                    { ":Time", time },
                    { ":Description", description },
                    { ":Repeats", repeats }
                };

                int insertedId = dbClass.ExecuteNonQueryWithReturn(insertQuery, parameters);

                if (insertedId > 0)
                {
                    // ListView에 항목 추가
                    ListViewItem item = new ListViewItem(category); // 첫 번째 열: 카테고리
                    item.SubItems.Add(time.ToString("yyyy-MM-dd")); // 두 번째 열: 날짜
                    item.SubItems.Add(description); // 세 번째 열: 설명
                    item.SubItems.Add(repeats); // 네 번째 열: 일정 반복
                    item.Tag = insertedId; // 삽입된 ID를 태그로 저장

                    // 부모 폼의 ListView에 항목 추가
                    AddItemToParentListView(item, time);

                    MessageBox.Show("일정이 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("일정 추가에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // 현재 창 닫기
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 추가하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void AddItemToParentListView(ListViewItem item, DateTime itemDate)
        {
            if (_calendarForm != null)
            {
                // 캘린더 폼의 ListView에 추가
                _calendarForm.getListView1.Items.Add(item);
            }
            else if (_homeForm != null)
            {
                // 현재 날짜 가져오기
                DateTime today = DateTime.Today;

                if (itemDate.Date == today)
                {
                    // 오늘 날짜는 getListView1에 추가
                    _homeForm.getListView1.Items.Add(item);
                }
                else if (itemDate.Date > today)
                {
                    // 오늘 이후 날짜는 getListView2에 추가
                    _homeForm.getListView2.Items.Add(item);
                }
            }
        }

    }
}
