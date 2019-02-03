using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain formMain = new FormMain();
            formMain.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(formMain);
        }
    }
}
