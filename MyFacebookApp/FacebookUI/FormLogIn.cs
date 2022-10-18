using System;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookUI
{
    public partial class FormLogin : Form
    {
        FacadeFormLogin m_FacadeLogin = new FacadeFormLogin();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            new Thread (login).Start();
        }

        private void login()
        {
            try
            {
                m_FacadeLogin.Login();
                if (!m_FacadeLogin.IsLoggedIn)
                {
                    MessageBox.Show("Login Failed", "Oops!");
                }
                else
                {
                    Invoke(new Action(this.Close));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!");
                //MessageBox.Show("An error has been occurred!", "Oops!");
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_FacadeLogin.UpdateRememberMeSettings(checkBoxRememberMe.Checked);
            checkBoxRememberMe.Checked = false;
        }
    }
}
