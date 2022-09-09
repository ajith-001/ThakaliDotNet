using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ThakaliDotNet
{
    public partial class ThakaliDotNet_Form : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
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
            txt_SignInEmpID.Visible = false;
            lbl_SignInPassword.Visible = false;
            lbl_SignInEmpID.Visible = false;
            lbl_RegisterUserName.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnRegister.Visible = false;
            btnSignIn.Visible = false;
            btn_Login.Visible = true;
            txt_SignInPassword.Visible = true;
            txt_SignInEmpID.Visible = true;
            lbl_SignInPassword.Visible = true;
            lbl_SignInEmpID.Visible = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_SignInEmpID.Text != "" && txt_SignInPassword.Text != "")
            {
                try
                {
                    conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ThakaliDotNet.Properties.Settings.TDN_DBConnectionString"].ConnectionString);
                    conn.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            } else
            {

            }
        
        }
    }
}
