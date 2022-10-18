using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookUI
{
  public class ApplicationManagement
    {
        private readonly AppLogic r_AppLogic = AppLogic.Instance;

        private readonly FormLogin r_FormLogin = new FormLogin();
        private FormMain m_FormMain;

        public void RunApp()
        {
            r_FormLogin.ShowDialog();
            if(r_AppLogic.LoggedIn)
            {
                m_FormMain = new FormMain();
                m_FormMain.ShowDialog();

                if(!r_AppLogic.LoggedIn)
                {
                    RunApp();
                }
                else
                {
                    MessageBox.Show("See you next time! :)", "Bye bye!");
                }
            }
        }
    }
}
