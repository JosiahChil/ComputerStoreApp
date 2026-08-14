using System;
using System.IO;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    public partial class frmUserModify : Form
    {
        public static string name = "";
        public static string firstName = "";
        public static string lastName = "";
        public int validInput = 0;
        public string logonName = "";
        public frmUserModify()
        {
            InitializeComponent();
        }




        /// <summary>
        /// This function passes a group of objects from the form to a function in a different class to complete the registration
        /// then hides the current form and shows the manager form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAccount_Click(object sender, EventArgs e)
        {




            clsSQL.UserEdit(tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress,
                tbxSecondAddress, tbxCity, tbxZipcode, cbState, tbxEmail,
                tbxPhoneNumber, tbxSecondaryPhoneNumber, tbxUsername
                , tbxPassword, cbFirstQuestion, tbxFirstAnswer, cbSecondQuestion,
                tbxSecondAnswer, cbThirdQuestion, tbxThirdAnswer, cbDelete, cbDisable, cbPosition);
            frmManager manager = new frmManager();
            manager.Show();
            this.Hide();





        }


        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AllowedKeys(e, tbxPassword);
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.UserNameAllowedKeys(e, tbxUsername);
        }

        /// <summary>
        /// This function simply adds multiple textboxes to the same event handler, as well as passes 3 objects to a function to load data to them and sets an item in the checkedlistbox to true
        /// It also loads all information of the selected customer whos information the user is editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserModify_Load(object sender, EventArgs e)
        {
            checkedListBox.SetItemChecked(13, true);
            clsSQL.Load(cbFirstQuestion, cbSecondQuestion, cbThirdQuestion);




            tbxFirstName.TextChanged += new EventHandler(textbox_TextChanged);
            tbxLastName.TextChanged += new EventHandler(textbox_TextChanged);
            tbxAddress.TextChanged += new EventHandler(textbox_TextChanged);
            tbxCity.TextChanged += new EventHandler(textbox_TextChanged);
            tbxZipcode.TextChanged += new EventHandler(textbox_TextChanged);
            cbState.TextChanged += new EventHandler(textbox_TextChanged);
            tbxEmail.TextChanged += new EventHandler(textbox_TextChanged);
            tbxPhoneNumber.TextChanged += new EventHandler(textbox_TextChanged);
            cbFirstQuestion.TextChanged += new EventHandler(textbox_TextChanged);
            cbSecondQuestion.TextChanged += new EventHandler(textbox_TextChanged);
            cbThirdQuestion.TextChanged += new EventHandler(textbox_TextChanged);
            tbxFirstAnswer.TextChanged += new EventHandler(textbox_TextChanged);
            tbxSecondAnswer.TextChanged += new EventHandler(textbox_TextChanged);
            tbxThirdAnswer.TextChanged += new EventHandler(textbox_TextChanged);

            clsSQL.getPersonInfoAll(name, tbxTitle, tbxFirstName, tbxMiddleName, tbxLastName, tbxSuffix, tbxAddress,
                tbxSecondAddress, tbxCity, tbxZipcode, cbState, tbxEmail,
                tbxPhoneNumber, tbxSecondaryPhoneNumber, tbxUsername
                , tbxPassword, cbFirstQuestion, tbxFirstAnswer, cbSecondQuestion,
                tbxSecondAnswer, cbThirdQuestion, tbxThirdAnswer, cbPosition, cbDisable, cbDelete);

            tbxUsername.TextChanged += new EventHandler(tbxUsername_TextChanged);
            tbxPassword.TextChanged += new EventHandler(tbxPassword_TextChanged);
            tbxUsername.TextChanged += new EventHandler(textbox_TextChanged);
            tbxPassword.TextChanged += new EventHandler(textbox_TextChanged);
            firstName = tbxFirstName.Text;
            lastName = tbxLastName.Text;
            logonName = tbxUsername.Text;
            usernameCheck();
            passwordCheck();
            requirements();

        }

        private void frmModifyUser_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }
        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.PhoneNumberValidate(e, tbxPhoneNumber);
        }
        private void tbxSecondaryPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.PhoneNumberValidate(e, tbxSecondaryPhoneNumber);
        }

        private void tbxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.TitleSuffixVerify(e, tbxTitle);
        }

        private void tbxSuffix_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.TitleSuffixVerify(e, tbxSuffix);
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.NameValidation(e, tbxFirstName);
        }

        private void tbxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.NameValidation(e, tbxMiddleName);

        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.NameValidation(e, tbxLastName);

        }

        private void tbxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.CityValidation(e, tbxCity);

        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.EmailValidation(e, tbxEmail);

        }

        private void tbxZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ZipValidation(e, tbxZipcode);

        }

        private void tbxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AddressValidation(e, tbxAddress);
        }

        private void tbxSecondAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AddressValidation(e, tbxSecondAddress);

        }

        private void tbxFirstAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AnswerValidation(e, tbxFirstAnswer);
        }

        private void tbxZipcode_Leave(object sender, EventArgs e)
        {
            clsValidation.FinalZipCheck(e, tbxZipcode);
        }

        /// <summary>
        /// This function checks a textbox for validation then sets an image to either checkmark or x mark depending on whether the validation returns true or false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {


            if (clsValidation.FinalEmailCheck(tbxEmail))
            {
                checkedListBox.SetItemChecked(20, true);
                string fullPath = Path.GetFullPath("GreenCheck.png");
                emailBox.Image = Properties.Resources.GreenCheck;
            }
            else
            {
                checkedListBox.SetItemChecked(20, false);
                string fullPath = Path.GetFullPath("XMark.png");
                emailBox.Image = Properties.Resources.XMark;
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

            passwordCheck();


        }

        /// <summary>
        /// This function checks a textbox for validation then sets an image to either checkmark or x mark depending on whether the validation returns true or false
        /// </summary>
        private void passwordCheck()
        {
            if (clsValidation.PasswordHasComplexity(tbxPassword.Text, checkedListBox, 6))
            {
                passwordBox.Image = Properties.Resources.GreenCheck;
                checkedListBox.SetItemChecked(8, true);
            }
            else
            {
                passwordBox.Image = Properties.Resources.XMark;
                checkedListBox.SetItemChecked(8, false);
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
            requirements();
        }

        private void requirements()
        {
            int x = 0;
            int y = 0;
            bool checks = true;
            int passwordCheck = 0;
            for (x = 0; x <= checkedListBox.CheckedItems.Count; x++)
            {

            }
            for (y = 0; y <= checkedListBox.Items.Count; y++)
            {

                if ((y <= 8 || y >= 13) && y < checkedListBox.Items.Count)
                {

                    if (checks == false)
                    {

                    }
                    else
                    {
                        if (checkedListBox.GetItemCheckState(y).ToString() == "Checked")
                        {
                            checks = true;
                        }
                        else
                        {
                            checks = false;
                        }
                    }
                }


                if ((y > 8 || y < 13) && y < checkedListBox.Items.Count)
                {
                    if (checkedListBox.GetItemCheckState(y).ToString() == "Checked")
                    {
                        passwordCheck++;
                    }
                }
            }
            // Console.WriteLine(checks);
            if (x >= (y - 1) && checks && passwordCheck >= 3)
            {
                btnEditAccount.Enabled = true;
            }
            else
            {
                btnEditAccount.Enabled = false;

            }
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {


            usernameCheck();


        }

        /// <summary>
        /// This function takes the username and runs various checks to determine if the username is both unique and complex enough.
        /// If it is the image next to the textbox is changed to a checkmark, if not then the image is a X mark
        /// </summary>
        private void usernameCheck()
        {

            int uniqueCheck = 0;
            int complexCheck = 0;
            if (clsSQL.UsernameUniqueEditing(tbxUsername.Text, logonName))
            {
                checkedListBox.SetItemChecked(0, true);
                uniqueCheck = 1;
            }
            else
            {
                checkedListBox.SetItemChecked(0, false);
                uniqueCheck = 0;
            }
            if (clsValidation.UsernameHasComplexity(tbxUsername.Text, checkedListBox))
            {
                complexCheck = 1;
            }
            else
            {
                complexCheck = 0;
            }
            if (uniqueCheck == 1 && complexCheck == 1)
            {
                usernameBox.Image = Properties.Resources.GreenCheck;
            }
            else
            {
                usernameBox.Image = Properties.Resources.XMark;
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                checkedListBox.SetItemChecked(14, false);
                fNameBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(14, true);
                fNameBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLastName.Text))
            {
                checkedListBox.SetItemChecked(15, false);
                lNameBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(15, true);
                lNameBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                checkedListBox.SetItemChecked(16, false);
                addressBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(16, true);
                addressBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCity.Text))
            {
                checkedListBox.SetItemChecked(17, false);
                cityBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(17, true);
                cityBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void tbxZipcode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxZipcode.Text) || tbxZipcode.Text.Length < 5 || tbxZipcode.Text.Length > 10)
            {
                checkedListBox.SetItemChecked(18, false);
                zipccodeBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(18, true);
                zipccodeBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbState.Text))
            {
                checkedListBox.SetItemChecked(19, false);
                stateBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(19, true);
                stateBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void tbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPhoneNumber.Text) || tbxPhoneNumber.Text.Length != 10)
            {
                checkedListBox.SetItemChecked(21, false);
                phoneBox.Image = Properties.Resources.XMark;
            }
            else
            {
                checkedListBox.SetItemChecked(21, true);
                phoneBox.Image = Properties.Resources.GreenCheck;
            }
        }

        private void cbFirstQuestion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFirstQuestion.Text) || string.IsNullOrEmpty(cbSecondQuestion.Text) || string.IsNullOrEmpty(cbThirdQuestion.Text))
            {
                checkedListBox.SetItemChecked(22, false);
            }
            else
            {
                checkedListBox.SetItemChecked(22, true);
            }
        }

        private void cbSecondQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFirstQuestion.Text) || string.IsNullOrEmpty(cbSecondQuestion.Text) || string.IsNullOrEmpty(cbThirdQuestion.Text))
            {
                checkedListBox.SetItemChecked(22, false);
            }
            else
            {
                checkedListBox.SetItemChecked(22, true);
            }
        }

        private void cbThirdQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFirstQuestion.Text) || string.IsNullOrEmpty(cbSecondQuestion.Text) || string.IsNullOrEmpty(cbThirdQuestion.Text))
            {
                checkedListBox.SetItemChecked(22, false);
            }
            else
            {
                checkedListBox.SetItemChecked(22, true);
            }
        }

        private void tbxFirstAnswer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstAnswer.Text) || string.IsNullOrEmpty(tbxSecondAnswer.Text) || string.IsNullOrEmpty(tbxThirdAnswer.Text))
            {
                checkedListBox.SetItemChecked(23, false);
            }
            else
            {
                checkedListBox.SetItemChecked(23, true);
            }
        }

        private void tbxSecondAnswer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstAnswer.Text) || string.IsNullOrEmpty(tbxSecondAnswer.Text) || string.IsNullOrEmpty(tbxThirdAnswer.Text))
            {
                checkedListBox.SetItemChecked(23, false);
            }
            else
            {
                checkedListBox.SetItemChecked(23, true);
            }
        }

        private void tbxThirdAnswer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstAnswer.Text) || string.IsNullOrEmpty(tbxSecondAnswer.Text) || string.IsNullOrEmpty(tbxThirdAnswer.Text))
            {
                checkedListBox.SetItemChecked(23, false);
            }
            else
            {
                checkedListBox.SetItemChecked(23, true);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, hlpUserModify.HelpNamespace);

        }


    }
}

