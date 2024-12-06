using Oracle.DataAccess.Client;
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
    public partial class AddForm1 : MetroFramework.Forms.MetroForm
    {
        private calenderForm1 calenderForm;
        private DBClass dbClass = new DBClass();

        public AddForm1(calenderForm1 form)
        {
            InitializeComponent();
            calenderForm = form;
        }

        private void btnSummit_addForm_Click(object sender, EventArgs e)
        {
            try
            {
                string category = comboCategory_addForm.Text;
                DateTime time = date_addForm.Value;
                string description = txtDescription_addForm.Text;

                // 입력 값 검증
                if (string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("카테고리와 일정 상세를 입력해야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // DB에 값 삽입
                string insertQuery = "INSERT INTO Calendar (ID, USERSID, Category, Time, Description, Repeats) " +
                                     "VALUES (SEQ_CALENDAR.NEXTVAL, :UserId, :Category, :Time, :Description, NULL) RETURNING ID INTO :InsertedID";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId },
            { ":Category", category },
            { ":Time", time },
            { ":Description", description }
        };

                // 삽입된 ID 가져오기
                DBClass dbClass = new DBClass();
                int insertedId = dbClass.ExecuteNonQueryWithReturn(insertQuery, parameters);

                if (insertedId > 0)
                {
                    // ListView에 항목 추가
                    ListViewItem item = new ListViewItem(category); // 첫 번째 열: 빈 칸
                    item.SubItems.Add(time.ToString("yyyy-MM-dd HH:mm:ss")); // 두 번째 열: 카테고리
                    item.SubItems.Add(description); // 세 번째 열: 시간
                    item.SubItems.Add("Null"); // 네 번째 열: 일정 상세
                                               // 다섯 번째 열: 일정 반복 (Null 값)

                    // 삽입된 ID를 태그로 저장
                    item.Tag = insertedId;

                    // 캘린더 폼의 ListView에 추가
                    calenderForm.getListView1.Items.Add(item);

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


    }
}
