namespace CompSoftwareMastery
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnPasswordHideShow = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblForgotPass = new System.Windows.Forms.LinkLabel();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpLogin = new System.Windows.Forms.HelpProvider();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(92, 61);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(206, 26);
            this.tbxUsername.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(11, 61);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 18);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(11, 130);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 18);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // btnPasswordHideShow
            // 
            this.btnPasswordHideShow.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordHideShow.Image")));
            this.btnPasswordHideShow.Location = new System.Drawing.Point(304, 119);
            this.btnPasswordHideShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasswordHideShow.Name = "btnPasswordHideShow";
            this.btnPasswordHideShow.Size = new System.Drawing.Size(55, 41);
            this.btnPasswordHideShow.TabIndex = 3;
            this.btnPasswordHideShow.UseVisualStyleBackColor = true;
            this.btnPasswordHideShow.Click += new System.EventHandler(this.btnPasswordHideShow_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(197, 159);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(238, 2);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(131, 29);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.Location = new System.Drawing.Point(89, 168);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(92, 13);
            this.lblForgotPass.TabIndex = 6;
            this.lblForgotPass.TabStop = true;
            this.lblForgotPass.Text = "Forgot Password?";
            this.lblForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPass_LinkClicked);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(92, 126);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(206, 26);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(197, 202);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(101, 30);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpLogin
            // 
            this.hlpLogin.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\Login.chm";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(54, 202);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(127, 30);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse Items";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(373, 285);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnPasswordHideShow);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnPasswordHideShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.LinkLabel lblForgotPass;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpLogin;
        private System.Windows.Forms.Button btnBrowse;
    }
}

