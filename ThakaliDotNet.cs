using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThakaliDotNet
{
    public partial class ThakaliDotNet_Form : Form
    {
        public ThakaliDotNet_Form()
        {
            InitializeComponent();
        }

        private void ThakaliDotNet_Form_Load(object sender, EventArgs e)
        {
            btnRegister.Visible = true;
            btnSignIn.Visible = true;
            btn_Login.Visible = false;
            txt_SignInPassword.Visible = false;
            txt_SignInUserName.Visible = false;
            lbl_SignInPassword.Visible = false;
            lbl_SignInUserName.Visible = false;
            lbl_RegisterUserName.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnRegister.Visible = false;
            btnSignIn.Visible = false;
            btn_Login.Visible = true;
            txt_SignInPassword.Visible = true;
            txt_SignInUserName.Visible = true;
            lbl_SignInPassword.Visible = true;
            lbl_SignInUserName.Visible = true;
        }
    }
}
