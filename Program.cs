using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRace
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
            Form1 MyForm = new Form1();
            MyForm.Click += new EventHandler((sender, eventArgs) =>
            {
                Application.Exit();
            });
            Application.Run(mainForm: MyForm);
            MyForm.Dispose();
        }
    }
}
