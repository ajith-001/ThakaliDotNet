namespace ThakaliDotNet
{
    partial class ThakaliDotNet_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThakaliDotNet_Form));
            this.lbl_SignInEmpID = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbl_RegisterUserName = new System.Windows.Forms.Label();
            this.lbl_SignInPassword = new System.Windows.Forms.Label();
            this.txt_SignInPassword = new System.Windows.Forms.TextBox();
            this.txt_SignInEmpID = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SignInEmpID
            // 
            this.lbl_SignInEmpID.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.lbl_SignInEmpID, "lbl_SignInEmpID");
            this.lbl_SignInEmpID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_SignInEmpID.Name = "lbl_SignInEmpID";
            this.lbl_SignInEmpID.UseWaitCursor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.btnSignIn, "btnSignIn");
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lbl_RegisterUserName
            // 
            this.lbl_RegisterUserName.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.lbl_RegisterUserName, "lbl_RegisterUserName");
            this.lbl_RegisterUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_RegisterUserName.Name = "lbl_RegisterUserName";
            // 
            // lbl_SignInPassword
            // 
            this.lbl_SignInPassword.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.lbl_SignInPassword, "lbl_SignInPassword");
            this.lbl_SignInPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_SignInPassword.Name = "lbl_SignInPassword";
            // 
            // txt_SignInPassword
            // 
            this.txt_SignInPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txt_SignInPassword, "txt_SignInPassword");
            this.txt_SignInPassword.Name = "txt_SignInPassword";
            // 
            // txt_SignInEmpID
            // 
            this.txt_SignInEmpID.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.txt_SignInEmpID, "txt_SignInEmpID");
            this.txt_SignInEmpID.Name = "txt_SignInEmpID";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ThakaliDotNet.Properties.Resources.greg_rosenke_6QnEf_b47eA_unsplash__2_;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ThakaliDotNet_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.txt_SignInEmpID);
            this.Controls.Add(this.txt_SignInPassword);
            this.Controls.Add(this.lbl_RegisterUserName);
            this.Controls.Add(this.lbl_SignInPassword);
            this.Controls.Add(this.lbl_SignInEmpID);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ThakaliDotNet_Form";
            this.Load += new System.EventHandler(this.ThakaliDotNet_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SignInEmpID;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lbl_RegisterUserName;
        private System.Windows.Forms.Label lbl_SignInPassword;
        private System.Windows.Forms.TextBox txt_SignInPassword;
        private System.Windows.Forms.TextBox txt_SignInEmpID;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

