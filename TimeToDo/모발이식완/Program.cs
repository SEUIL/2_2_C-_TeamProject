using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeToDo.Forms;

namespace TimeToDo
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //<<둘 중에 하나 주석처리하기>>


            //로그인폼부터 시작하기!
            //Application.Run(new LoginForm1());
            //할일폼 보기
            Application.Run(new TodoForm1());
        }
    }
}
