using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TimeToDo.Forms
{
    public partial class TodoEditForm1 : Form
    {
        private int _todoId; // 업데이트할 할 일의 ID
        private readonly OracleConnection _oracleConnection; // Oracle 연결
        private readonly TodoForm1 _parentForm; // 부모 폼 참조

        public TodoEditForm1(int todoId, string task, string category, string priority, DateTime todoDate, DateTime deadline, TodoForm1 parentForm)
        {
            InitializeComponent();

            // 매개변수 초기화
            _todoId = todoId;
            _parentForm = parentForm;
            _oracleConnection = new OracleConnection("User Id=Calendar; Password=1234; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))");

            // 기존 데이터를 UI에 로드
            textBox1.Text = task;
            listBox1.Items.AddRange(new string[] { "공적 일정", "사적 일정", "자기 개발", "취미 생활" });
            comboBox1.Items.AddRange(new string[] { "높음", "중간", "낮음" });
            listBox1.SelectedItem = category;
            comboBox1.SelectedItem = priority;
            dateTimePicker1.Value = todoDate;
            dateTimePicker2.Value = deadline;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    _oracleConnection.Open();

                    // 수정된 데이터 가져오기
                    string updatedTask = textBox1.Text.Trim();
                    string updatedCategory = listBox1.SelectedItem.ToString();
                    string updatedPriority = comboBox1.SelectedItem.ToString();
                    DateTime updatedTodoDate = dateTimePicker1.Value;
                    DateTime updatedDeadline = dateTimePicker2.Value;

                    // Oracle SQL 쿼리 작성
                    string query = "UPDATE Todolist SET Task = :Task, Category = :Category, Priority = :Priority, TodoDate = :TodoDate, Deadline = :Deadline WHERE ID = :Id";

                    using (OracleCommand command = new OracleCommand(query, _oracleConnection))
                    {
                        command.Parameters.Add(":Task", updatedTask);
                        command.Parameters.Add(":Category", updatedCategory);
                        command.Parameters.Add(":Priority", updatedPriority);
                        command.Parameters.Add(":TodoDate", updatedTodoDate);
                        command.Parameters.Add(":Deadline", updatedDeadline);
                        command.Parameters.Add(":Id", _todoId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 부모 폼의 ListView 새로고침
                            _parentForm.RefreshListView(); // 새로고침 메서드 호출

                            MessageBox.Show("할 일이 성공적으로 업데이트되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("업데이트 실패: 데이터가 수정되지 않았습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"할 일을 업데이트하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _oracleConnection.Close();
                }
            }
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("할 일 제목을 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (listBox1.SelectedIndex == -1 || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("카테고리와 우선순위를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                MessageBox.Show("마감일은 시작일 이후여야 합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}