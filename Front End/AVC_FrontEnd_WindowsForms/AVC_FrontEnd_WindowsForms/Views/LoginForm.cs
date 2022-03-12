using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVC_FrontEnd_WindowsForms.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblUserWarning.Visible = false;
            lblPasswordWarning.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string User     = txtbUser.Text;
            string Password = txtbPassword.Text;

            lblUserWarning.Visible     = false;
            lblPasswordWarning.Visible = false;

            if (User.Equals(""))
            {
                lblUserWarning.Text = "Please, introduce your Full Name or Email";
                lblUserWarning.ForeColor = Color.Red;
                lblUserWarning.Visible = true;
            }

            if (Password.Equals(""))
            {
                lblPasswordWarning.Text = "Please, introduce your password";
                lblPasswordWarning.ForeColor = Color.Red;
                lblPasswordWarning.Visible = true;
            }

            if (!User.Equals("") && !Password.Equals(""))
            {

            }
        }
    }
}
