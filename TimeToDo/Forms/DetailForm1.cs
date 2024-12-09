using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static TimeToDo.LoginForm1;

namespace TimeToDo.Forms
{
    public partial class DetailForm1 : MetroFramework.Forms.MetroForm
    {
        private int selectedId;
        private string selectedCategory;
        private string selectedTime;
        private string selectedDescription;
        private string selectedRepeats;

        private DBClass dbClass = new DBClass();

        public DetailForm1(int id, string category, string time, string description, string repeats)
        {
            InitializeComponent();

            selectedId = id;
            selectedCategory = category;
            selectedTime = time;
            selectedDescription = description;
            selectedRepeats = repeats;

            comboCategory_detailForm.Text = selectedCategory;
            date_detailForm.Value = DateTime.Parse(selectedTime);
            txtDescription_detailForm.Text = selectedDescription;
            txtRepeats_detailForm.Text = selectedRepeats;

        }

        private void DetailForm1_Load(object sender, EventArgs e)
        {
            
        }

        //수정눌렀을때 DB에 수정내용보내고 편집창 닫히면서 수정내용 최신화
        private void btnEdit_detailForm_Click(object sender, EventArgs e) 
        {
            editForm1 editForm = new editForm1(selectedId, selectedCategory, selectedTime, selectedDescription, selectedRepeats);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                string query = @"
                    SELECT Category, Time, Description, Repeats
                    FROM Calendar 
                    WHERE USERSID = :UserId
                        AND ID = :Id";

                var parameters = new Dictionary<string, object>
                {
                    { ":UserId", Session.LoggedInUserId },
                    { ":Id", selectedId }
                };

                DataSet dataSet = dbClass.DB_Open(query, parameters);

                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataSet.Tables[0].Rows[0];
                    comboCategory_detailForm.Text = row["Category"].ToString();
                    date_detailForm.Value = DateTime.Parse(row["Time"].ToString());
                    txtDescription_detailForm.Text = row["Description"].ToString();
                    txtRepeats_detailForm.Text = row["Repeats"].ToString();
                }
                else
                {
                    MessageBox.Show("수정된 데이터를 가져오지 못했습니다.");
                }
            }
        }

        private void btnDelete_detailForm_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show("일정이 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClose_detailForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // 성공적인 업데이트 표시
            
        }

        private void DetailForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK; // 성공적인 업데이트 표시
            
        }
    }
}
