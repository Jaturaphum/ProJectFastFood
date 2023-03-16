using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfastfood
{
    internal static class Program
    {
         ///<บทสรุป>
         /// จุดเริ่มต้นของการเขียนเเอพพิเคชั่น
         ///</สรุป>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            Application.Run(new Formlogin());
        }
    }
}
