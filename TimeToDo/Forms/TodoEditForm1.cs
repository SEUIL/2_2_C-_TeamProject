using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TimeToDo.Forms
{
    public partial class TodoEditForm1 : MetroFramework.Forms.MetroForm
    {
        private readonly string _todoId; // 업데이트할 할 일의 ID
        private readonly OracleConnection _oracleConnection; // Oracle 연결

        private readonly TodoForm1 _todoForm; // TodoForm1 참조
        private readonly HomeForm1 _homeForm; // HomeForm1 참조

        public TodoEditForm1(string todoId, string task, string category, string priority, DateTime todoDate, DateTime deadline, TodoForm1 todoForm)
        {
            InitializeComponent();
            _todoId = todoId;
            _todoForm = todoForm;
            _oracleConnection = new OracleConnection("User Id=Calendar; Password=1234; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))");

            InitializeFields(task, category, priority, todoDate, deadline);
        }

        public TodoEditForm1(string todoId, string task, string category, string priority, DateTime todoDate, DateTime deadline, HomeForm1 homeForm)
        {
            InitializeComponent();
            _todoId = todoId;
            _homeForm = homeForm;
            _oracleConnection = new OracleConnection("User Id=Calendar; Password=1234; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))");

            InitializeFields(task, category, priority, todoDate, deadline);
        }

        private void InitializeFields(string task, string category, string priority, DateTime todoDate, DateTime deadline)
        {
            textBox1.Text = task;
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

                    string updatedTask = textBox1.Text.Trim();
                    string updatedCategory = listBox1.SelectedItem?.ToString() ?? "";
                    string updatedPriority = comboBox1.SelectedItem?.ToString() ?? "";
                    DateTime updatedTodoDate = dateTimePicker1.Value;
                    DateTime updatedDeadline = dateTimePicker2.Value;

                    string query = @"UPDATE Todolist 
                                     SET Task = :Task, Category = :Category, Priority = :Priority, 
                                         TodoDate = :TodoDate, Deadline = :Deadline 
                                     WHERE ID = :Id";

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
                            RefreshParentListView(updatedTask, updatedCategory, updatedPriority, updatedTodoDate, updatedDeadline, 0);
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
                    MessageBox.Show($"데이터베이스 작업 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (_oracleConnection != null && _oracleConnection.State == ConnectionState.Open)
                    {
                        _oracleConnection.Close();
                    }
                }
            }
        }

        private void RefreshParentListView(string task, string category, string priority, DateTime todoDate, DateTime deadline, int isCompleted)
        {
            if (_todoForm != null)
            {
                _todoForm.UpdateListViewItem(_todoId, task, category, priority, todoDate, deadline, isCompleted == 1);
            }
            else if (_homeForm != null)
            {
                _homeForm.UpdateListViewItem(_todoId, task, category, priority, todoDate, deadline, isCompleted == 1);
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

            if (dateTimePicker2.Value < dateTimePicker1.Value)
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
