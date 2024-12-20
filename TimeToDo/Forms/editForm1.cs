﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeToDo.Forms
{
    public partial class editForm1 : MetroFramework.Forms.MetroForm
    {
        private int selectedId;
        private string selectedCategory;
        private string selectedTime;
        private string selectedDescription;
        private string selectedRepeats;

        private DBClass dbClass = new DBClass();

        public editForm1(int id, string category, string time, string description, string repeats)
        {
            InitializeComponent();

            selectedId = id;
            selectedCategory = category;
            selectedTime = time;
            selectedDescription = description;
            selectedRepeats = repeats;

            // 초기 데이터 설정
            comboCategory_editForm.Text = selectedCategory;
            date_editForm.Value = DateTime.Parse(selectedTime);
            txtDescription_editForm.Text = selectedDescription;
            comboRepeats_editForm.Text = selectedRepeats;
        }

        private void btnSummit_addForm_Click(object sender, EventArgs e)
        {
            try
            {
                // 업데이트된 데이터 가져오기
                string updatedCategory = comboCategory_editForm.Text;
                DateTime updatedTime = date_editForm.Value;
                string updatedDescription = txtDescription_editForm.Text;
                string updatedRepeats = comboRepeats_editForm.Text;

                // DB 업데이트 쿼리
                string updateQuery = "UPDATE Calendar SET Category = :Category, Time = :Time, Description = :Description, Repeats = :Repeats WHERE Id = :Id";

                var parameters = new Dictionary<string, object>
                {
                    { ":Category", updatedCategory },
                    { ":Time", updatedTime },
                    { ":Description", updatedDescription },
                    { ":Repeats", updatedRepeats },
                    { ":Id", selectedId }
                };

                dbClass.ExecuteNonQuery(updateQuery, parameters);

                MessageBox.Show("일정이 성공적으로 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK; // 성공적인 업데이트 표시
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("일정을 수정하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
