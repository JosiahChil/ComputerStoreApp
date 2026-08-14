using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    public partial class frmForgotPassword : Form
    {
        /// <summary>
        /// This class performs the operation to replace an existing users password
        /// </summary>
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function enables multiple objects, and disables some, in the application upon successful verifacation of the inserted username to progress the operation.
        /// Upon failiure of verifacation it tells the user something went wrong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmUser_Click(object sender, EventArgs e)
        {
            if (clsSQL.CheckUsername(tbxUsername.Text))
            {
                btnConfirmUser.Enabled = false;
                tbxUsername.Enabled = false;
                tbxFirstAnswer.Enabled = true;
                tbxSecondAnswer.Enabled = true;
                tbxThirdAnswer.Enabled = true;
                btnConfirmAnswers.Enabled = true;
                clsSQL.WriteQuestions(tbxUsername.Text, tbxFirstQuestion, tbxSecondQuestion, tbxThirdQuestion);
            }
            else
            {
                MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// This function enables multiple objects, and disables some, in the application upon successful verifacation of the inserted security answers being correct to progress the operation.
        /// Upon failiure of verifacation it tells the user something went wrong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmAnswers_Click(object sender, EventArgs e)
        {
            if (clsSQL.SecurityAnswers(tbxUsername.Text, tbxFirstAnswer.Text, tbxSecondAnswer.Text, tbxThirdAnswer.Text))
            {
                tbxFirstAnswer.Enabled = false;
                tbxSecondAnswer.Enabled = false;
                tbxThirdAnswer.Enabled = false;
                btnConfirmAnswers.Enabled = false;
                tbxNewPassword.Enabled = true;
                tbxVerifyPassword.Enabled = true;


            }
        }

        /// <summary>
        /// This function passes the username and password to another function to update the password in the database, then hides the form and returns the user
        /// to the login form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {


            clsSQL.UpdatePassword(tbxUsername.Text, tbxNewPassword.Text);
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        private void frmForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        /// <summary>
        /// This function passes parameters to a function to check its complexity.
        /// If the check returns true then it checks off the box corresponding to the password in the checkedlistbox
        /// If it returns false, it sets the check to false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.PasswordHasComplexity(tbxNewPassword.Text, passwordRequirement, 0))
            {
                passwordRequirement.SetItemChecked(2, true);

            }
            else
            {
                passwordRequirement.SetItemChecked(2, false);
            }
        }

        /// <summary>
        /// This function is attached to a group of textboxes. 
        /// It runs a loop that checks each item in the checklistbox, which would be altered depending on what the user has entered into the program
        /// If the user successfully completed all information, the loop will complete ending with setting the checks variable to true as well.
        /// If the boolean checks true and the other requirements it will enable the button to create the account
        /// If false the button remains disabled or disables itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (tbxNewPassword.Text.Equals(tbxVerifyPassword.Text))
            {
                passwordRequirement.SetItemChecked(7, true);
            }
            else
            {
                passwordRequirement.SetItemChecked(7, false);
            }

            int x = 0;
            int y = 0;
            for (x = 0; x <= passwordRequirement.CheckedItems.Count; x++)
            {

            }
            for (y = 0; y <= passwordRequirement.Items.Count; y++)
            {

            }
            if (x >= (y - 1))
            {
                btnChangePassword.Enabled = true;
            }
            else
            {
                btnChangePassword.Enabled = false;
                Console.WriteLine("hi");
            }
            if (!passwordRequirement.GetItemChecked(7))
            {
                btnChangePassword.Enabled = false;
            }
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            tbxNewPassword.TextChanged += new EventHandler(textbox_TextChanged);
            tbxVerifyPassword.TextChanged += new EventHandler(textbox_TextChanged);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, hlpForgotPassword.HelpNamespace);
        }


        /// <summary>
        /// This function hides the current form and opens the login form back up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        
    }
}
