using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToDo.Forms
{
    public partial class TodoSearchForm1 : Form
    {
        private TodoForm1 todoForm; // 부모 폼 참조
        private DBClass dbClass = new DBClass(); // DB 클래스 객체 초기화

        public TodoSearchForm1(TodoForm1 form)
        {
            InitializeComponent();
            todoForm = form; // 부모 폼 참조 저장
        }
    }
}
