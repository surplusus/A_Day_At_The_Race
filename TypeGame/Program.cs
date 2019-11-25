using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeGame
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var myForm = new Form1();
            myForm.KeyDown += new KeyEventHandler((sender,e)=>
            {
                if (e.KeyCode == Keys.Escape)
                    Application.Exit();
            });
            Application.Run(myForm);
        }
    }
}
