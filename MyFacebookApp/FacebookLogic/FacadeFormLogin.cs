using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookLogic;

namespace FacebookUI
{
    public class FacadeFormLogin
    {
        private readonly AppLogic r_AppLogic = AppLogic.Instance;

        public void Login()
        {
            r_AppLogic.Login();
        }

        public bool IsLoggedIn
        {
            get
            {
                return r_AppLogic.LoggedInUser != null;
            }
        }

        public void UpdateRememberMeSettings(bool i_RememberMe)
        {
            r_AppLogic.Settings.RememberUser = i_RememberMe;
        }

    }
}
