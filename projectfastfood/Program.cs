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
         ///<เรื่มต้นการทำงานโปรเเกรม>
         /// จุดเริ่มต้นของการเขียนเเอพพิเคชั่น
         ///</จบการทำงานโปรเเกรม>
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
