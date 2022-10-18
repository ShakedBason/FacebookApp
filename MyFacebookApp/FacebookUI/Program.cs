using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookUI
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationManagement applicationManagement = new ApplicationManagement();
            applicationManagement.RunApp();
        }
    }
}
