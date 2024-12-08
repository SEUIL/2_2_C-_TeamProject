using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class TodoAddForm1 : Form
    {
        private TodoForm1 todoForm; // 부모 폼 참조
        private DBClass dbClass = new DBClass(); // DB 클래스 객체 초기화

        public TodoAddForm1(TodoForm1 form)
        {
            InitializeComponent();
            todoForm = form; // 부모 폼 참조 저장
        }

        private void btnSummit_addForm_Click(object sender, EventArgs e)
        {
            try
            {
                // 입력 값 가져오기
                string task = textBox1.Text.Trim();
                string category = listBox1.Text.Trim();
                string priority = comboBox1.Text.Trim();
                DateTime todoDate = dateTimePicker1.Value.Date;
                DateTime deadline = dateTimePicker2.Value.Date;

                // 입력 값 검증
                if (string.IsNullOrEmpty(task) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(priority))
                {
                    MessageBox.Show("모든 필드를 입력해야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (todoDate > deadline)
                {
                    MessageBox.Show("시작 날짜는 마감 날짜보다 이전이어야 합니다.", "날짜 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // DB에 값 삽입
                string insertQuery = "INSERT INTO Todolist (ID, USERID, Task, Category, Priority, TodoDate, Deadline) " +
                                     "VALUES (SEQ_TODOLIST.NEXTVAL, :UserId, :Task, :Category, :Priority, :TodoDate, :Deadline) " +
                                     "RETURNING ID INTO :InsertedID";

                var parameters = new Dictionary<string, object>
        {
            { ":UserId", Session.LoggedInUserId }, // 문자열로 처리
            { ":Task", task },
            { ":Category", category },
            { ":Priority", priority },
            { ":TodoDate", todoDate },
            { ":Deadline", deadline }
        };

                // ExecuteNonQueryWithReturn 호출
                DBClass dbClass = new DBClass();
                int insertedId = dbClass.ExecuteNonQueryWithReturn(insertQuery, parameters);

                if (insertedId > 0)
                {
                    // 리스트뷰에 새 항목 추가
                    ListViewItem item = new ListViewItem(); // 첫 번째 열: ID
                    item.Tag = insertedId;
                    item.SubItems.Add(task);
                    item.SubItems.Add(category);
                    item.SubItems.Add(priority);
                    item.SubItems.Add(todoDate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(deadline.ToString("yyyy-MM-dd"));



                    todoForm.AddItemToListView(item);

                    MessageBox.Show("할 일이 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("할 일 추가에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // 현재 창 닫기
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("할 일을 추가하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
