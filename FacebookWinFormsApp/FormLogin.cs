using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private readonly FacebookManager r_FacebookManager;

        public FormLogin()
        {
            InitializeComponent();
            r_FacebookManager = new FacebookManager("512641717928096");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isLoggedIn = r_FacebookManager.Initialize();

                if (isLoggedIn && string.IsNullOrEmpty(r_FacebookManager.LoginResult.ErrorMessage))
                {
                    FormMain formMain = new FormMain(r_FacebookManager);
                    formMain.FormClosed += (s, args) => this.Show();
                    this.Visible = false;
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show(r_FacebookManager.LoginResult?.ErrorMessage ?? "Login Failed", "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                Application.Exit();
            }
            base.OnFormClosing(e);
        }
    }
}
