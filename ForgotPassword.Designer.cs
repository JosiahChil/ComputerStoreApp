namespace CompSoftwareMastery
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnConfirmUser = new System.Windows.Forms.Button();
            this.tbxFirstQuestion = new System.Windows.Forms.TextBox();
            this.tbxSecondQuestion = new System.Windows.Forms.TextBox();
            this.tbxThirdQuestion = new System.Windows.Forms.TextBox();
            this.tbxFirstAnswer = new System.Windows.Forms.TextBox();
            this.tbxSecondAnswer = new System.Windows.Forms.TextBox();
            this.tbxThirdAnswer = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbxVerifyPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmAnswers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordRequirement = new System.Windows.Forms.CheckedListBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpForgotPassword = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please insert your username";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(393, 49);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(226, 31);
            this.tbxUsername.TabIndex = 1;
            // 
            // btnConfirmUser
            // 
            this.btnConfirmUser.Location = new System.Drawing.Point(625, 49);
            this.btnConfirmUser.Name = "btnConfirmUser";
            this.btnConfirmUser.Size = new System.Drawing.Size(212, 31);
            this.btnConfirmUser.TabIndex = 2;
            this.btnConfirmUser.Text = "Confirm Username";
            this.btnConfirmUser.UseVisualStyleBackColor = true;
            this.btnConfirmUser.Click += new System.EventHandler(this.btnConfirmUser_Click);
            // 
            // tbxFirstQuestion
            // 
            this.tbxFirstQuestion.Location = new System.Drawing.Point(12, 201);
            this.tbxFirstQuestion.Name = "tbxFirstQuestion";
            this.tbxFirstQuestion.ReadOnly = true;
            this.tbxFirstQuestion.Size = new System.Drawing.Size(316, 31);
            this.tbxFirstQuestion.TabIndex = 3;
            this.tbxFirstQuestion.TabStop = false;
            // 
            // tbxSecondQuestion
            // 
            this.tbxSecondQuestion.Location = new System.Drawing.Point(349, 201);
            this.tbxSecondQuestion.Name = "tbxSecondQuestion";
            this.tbxSecondQuestion.ReadOnly = true;
            this.tbxSecondQuestion.Size = new System.Drawing.Size(316, 31);
            this.tbxSecondQuestion.TabIndex = 4;
            this.tbxSecondQuestion.TabStop = false;
            // 
            // tbxThirdQuestion
            // 
            this.tbxThirdQuestion.Location = new System.Drawing.Point(678, 201);
            this.tbxThirdQuestion.Name = "tbxThirdQuestion";
            this.tbxThirdQuestion.ReadOnly = true;
            this.tbxThirdQuestion.Size = new System.Drawing.Size(316, 31);
            this.tbxThirdQuestion.TabIndex = 5;
            this.tbxThirdQuestion.TabStop = false;
            // 
            // tbxFirstAnswer
            // 
            this.tbxFirstAnswer.Enabled = false;
            this.tbxFirstAnswer.Location = new System.Drawing.Point(12, 297);
            this.tbxFirstAnswer.Name = "tbxFirstAnswer";
            this.tbxFirstAnswer.Size = new System.Drawing.Size(316, 31);
            this.tbxFirstAnswer.TabIndex = 6;
            // 
            // tbxSecondAnswer
            // 
            this.tbxSecondAnswer.Enabled = false;
            this.tbxSecondAnswer.Location = new System.Drawing.Point(349, 297);
            this.tbxSecondAnswer.Name = "tbxSecondAnswer";
            this.tbxSecondAnswer.Size = new System.Drawing.Size(316, 31);
            this.tbxSecondAnswer.TabIndex = 7;
            // 
            // tbxThirdAnswer
            // 
            this.tbxThirdAnswer.Enabled = false;
            this.tbxThirdAnswer.Location = new System.Drawing.Point(678, 297);
            this.tbxThirdAnswer.Name = "tbxThirdAnswer";
            this.tbxThirdAnswer.Size = new System.Drawing.Size(316, 31);
            this.tbxThirdAnswer.TabIndex = 8;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Enabled = false;
            this.tbxNewPassword.Location = new System.Drawing.Point(305, 429);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(226, 31);
            this.tbxNewPassword.TabIndex = 10;
            this.tbxNewPassword.TextChanged += new System.EventHandler(this.tbxNewPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Insert your new password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Location = new System.Drawing.Point(305, 526);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(212, 39);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "Reset password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbxVerifyPassword
            // 
            this.tbxVerifyPassword.Enabled = false;
            this.tbxVerifyPassword.Location = new System.Drawing.Point(305, 484);
            this.tbxVerifyPassword.Name = "tbxVerifyPassword";
            this.tbxVerifyPassword.Size = new System.Drawing.Size(226, 31);
            this.tbxVerifyPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Verify your new password";
            // 
            // btnConfirmAnswers
            // 
            this.btnConfirmAnswers.Enabled = false;
            this.btnConfirmAnswers.Location = new System.Drawing.Point(376, 371);
            this.btnConfirmAnswers.Name = "btnConfirmAnswers";
            this.btnConfirmAnswers.Size = new System.Drawing.Size(226, 31);
            this.btnConfirmAnswers.TabIndex = 15;
            this.btnConfirmAnswers.Text = "Confirm Answers";
            this.btnConfirmAnswers.UseVisualStyleBackColor = true;
            this.btnConfirmAnswers.Click += new System.EventHandler(this.btnConfirmAnswers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(535, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Please answer these questions to reset your password";
            // 
            // passwordRequirement
            // 
            this.passwordRequirement.Enabled = false;
            this.passwordRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRequirement.FormattingEnabled = true;
            this.passwordRequirement.Items.AddRange(new object[] {
            "Password Cannot be less than 8 characters long",
            "Password Cannot be more than 20 charaters long",
            "Must have atleast 3 of the 4 following conditions. ",
            "Upper case characters (A through Z)",
            "Lower case characters (a through z)",
            "Numbers (0 through 9)",
            "Special characters ()!@#$%^&* No spaces allowed\"",
            "Both password fields must be the same"});
            this.passwordRequirement.Location = new System.Drawing.Point(608, 409);
            this.passwordRequirement.Name = "passwordRequirement";
            this.passwordRequirement.Size = new System.Drawing.Size(369, 156);
            this.passwordRequirement.TabIndex = 17;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(854, 362);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(114, 41);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpForgotPassword
            // 
            this.hlpForgotPassword.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\ForgotPassword.chm";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(31, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back to Login Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(999, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.passwordRequirement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConfirmAnswers);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbxVerifyPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxThirdAnswer);
            this.Controls.Add(this.tbxSecondAnswer);
            this.Controls.Add(this.tbxFirstAnswer);
            this.Controls.Add(this.tbxThirdQuestion);
            this.Controls.Add(this.tbxSecondQuestion);
            this.Controls.Add(this.tbxFirstQuestion);
            this.Controls.Add(this.btnConfirmUser);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmForgotPassword_FormClosed);
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnConfirmUser;
        private System.Windows.Forms.TextBox tbxFirstQuestion;
        private System.Windows.Forms.TextBox tbxSecondQuestion;
        private System.Windows.Forms.TextBox tbxThirdQuestion;
        private System.Windows.Forms.TextBox tbxFirstAnswer;
        private System.Windows.Forms.TextBox tbxSecondAnswer;
        private System.Windows.Forms.TextBox tbxThirdAnswer;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbxVerifyPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmAnswers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox passwordRequirement;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpForgotPassword;
        private System.Windows.Forms.Button button1;
    }
}