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
using Oracle.DataAccess.Types;

namespace TimeToDo.Forms
{
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
            InitializeListView();
            LoadDataFromDatabase();
        }

        private void InitializeListView()
        {
            // ListView 설정
            listView1.CheckBoxes = true;
            listView1.View = View.Details;
        }

        private void LoadDataFromDatabase()
        {
            // 데이터베이스 연결 문자열
            string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = " +
                                      "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
                                      "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)))";

            // 조인 쿼리
            string commandString = "SELECT T.ID, T.TODO, C.CATEGORY, T.PRIORITY, T.START_DATE, T.END_DATE " +
                                   "FROM TODO_TABLE T INNER JOIN CATEGORY_TABLE C ON T.CATEGORY_ID = C.ID";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(commandString, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // ListView 초기화
                            listView1.Items.Clear();

                            // 데이터 읽어서 ListView에 추가
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                                item.SubItems.Add(reader["TODO"].ToString());
                                item.SubItems.Add(reader["CATEGORY"].ToString());
                                item.SubItems.Add(reader["PRIORITY"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["START_DATE"]).ToString("yyyy-MM-dd"));
                                item.SubItems.Add(Convert.ToDateTime(reader["END_DATE"]).ToString("yyyy-MM-dd"));
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (OracleException oe)
            {
                MessageBox.Show($"Oracle 데이터베이스 오류: {oe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"일반 오류 발생: {ex.Message}");
            }
        }
}}
