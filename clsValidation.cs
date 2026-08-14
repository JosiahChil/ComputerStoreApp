using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class handles validation of various objects, mostly related to account creation
    /// </summary>
    internal class clsValidation
    {
        public static bool isBackspace = true;
        public static int emailCheckForAtSign = 0;
        public static int emailCheckForPeriods = 0;
        public static int AtSignPosition = 0;
        public static int PeriodPosition = 0;
        public static bool handle = true;
        public static bool isEmailValid = true;

        /// <summary>
        /// This function takes a string of symbols and sets up a limitation, only allowing letters, digits, control actions, or the set symbols
        /// to be used in the passed textbox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tbxPassword"></param>
        internal static void AllowedKeys(KeyPressEventArgs e, System.Windows.Forms.TextBox tbxPassword)
        {

            string strAllowedKeys = "!@#$%^&*()";

            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || strAllowedKeys.Contains(e.KeyChar.ToString()))
            {
                e.Handled = false;


            }
            else
            {
                e.Handled = true;


            }




        }


        /// <summary>
        /// This function checks for password complexity. A group of requirements are required to check
        /// off all the password related checks in the checklistbox before the password is acceptable
        /// </summary>
        /// <param name="str"></param>
        /// <param name="checkedListBox"></param>
        /// <param name="x">Checked List Box index</param>
        /// <returns></returns>
        internal static bool PasswordHasComplexity(string str, CheckedListBox checkedListBox, int x)
        {

            int intComplexityCounter = 0;
            bool bolHasSpecial = false;
            string strAllowedKeys = "!@#$%^&*()";


            if (str.Length >= 8 && str.Length <= 20)
            {
                checkedListBox.SetItemChecked(x, true);
                checkedListBox.SetItemChecked((x + 1), true);
                intComplexityCounter++;
            }
            else
            {
                if (str.Length < 8)
                {
                    checkedListBox.SetItemChecked(x, false);
                }
                if (str.Length > 20)
                {
                    checkedListBox.SetItemChecked((x + 1), false);
                }
                return false;
            }

            if (str.Any(char.IsUpper))
            {
                checkedListBox.SetItemChecked((x + 3), true);
                intComplexityCounter++;
            }
            else if (!str.Any(char.IsUpper))
            {
                checkedListBox.SetItemChecked((x + 3), false);
            }

            if (str.Any(char.IsLower))
            {
                checkedListBox.SetItemChecked((x + 4), true);
                intComplexityCounter++;
            }
            else
            {
                checkedListBox.SetItemChecked((x + 4), false);
            }

            if (str.Any(char.IsDigit))
            {
                checkedListBox.SetItemChecked((x + 5), true);
                intComplexityCounter++;
            }
            else if (!str.Any(char.IsDigit))
            {
                checkedListBox.SetItemChecked((x + 5), false);
            }

            foreach (char chLetter in str)
            {
                if (strAllowedKeys.Contains(chLetter.ToString()))
                {

                    bolHasSpecial = true;
                }
            }

            if (bolHasSpecial)
            {
                checkedListBox.SetItemChecked((x + 6), true);
                intComplexityCounter++;
            }
            else
            {
                checkedListBox.SetItemChecked((x + 6), false);
            }


            return intComplexityCounter >= 4;








        }


       /// <summary>
       /// This function sets restrictions for the username, only allowing letters, digits, or control actions.
       /// After setting that, it checks for the length of the username and ensuring the first character of the
       /// username is not a number
       /// </summary>
       /// <param name="e"></param>
       /// <param name="tbxUsername"></param>
        internal static void UserNameAllowedKeys(KeyPressEventArgs e, System.Windows.Forms.TextBox tbxUsername)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (tbxUsername.Text.Length == 0)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (tbxUsername.Text.Length > 0)
            {

                if (char.IsDigit(tbxUsername.Text[0]))
                {
                    for (int i = 0; i < tbxUsername.Text.Length; i++)
                    {


                        if (char.IsDigit(tbxUsername.Text[0]))
                        {

                            tbxUsername.Text = tbxUsername.Text.Substring(1);
                        }
                    }
                }
            }




        }



        /// <summary>
        /// This function checks the username for complexity, using several checks for a handfull of conditions to ensure the
        /// username is complex enough to be used
        /// </summary>
        /// <param name="str">Username text</param>
        /// <param name="checkedListBox"></param>
        /// <returns></returns>
        internal static bool UsernameHasComplexity(string str, CheckedListBox checkedListBox)
        {
            if (str == null || str == "")
            {
                checkedListBox.SetItemChecked(1, false);
                return false;
            }
            string strAllowedKeys = "!@#$%^&*()";
            char noDigit = str[0];

            if (str.Length < 8 || str.Length > 20)
            {
                if (str.Length < 8)
                {
                    checkedListBox.SetItemChecked(2, false);
                }
                if (str.Length > 20)
                {
                    checkedListBox.SetItemChecked(3, false);
                }
                return false;
            }

            foreach (char chLetter in str)
            {
                if (strAllowedKeys.Contains(chLetter.ToString()))
                {
                    checkedListBox.SetItemChecked(4, false);
                    return false;
                }
            }
            if (char.IsDigit(noDigit))
            {
                checkedListBox.SetItemChecked(1, false);
                return false;
            }


            // Console.WriteLine(str.Length);
            checkedListBox.SetItemChecked(1, true);
            checkedListBox.SetItemChecked(2, true);
            checkedListBox.SetItemChecked(3, true);
            checkedListBox.SetItemChecked(4, true);
            checkedListBox.SetItemChecked(5, true);
            return true;

        }

        /// <summary>
        /// This function ensures the phone number only contains numgers and is less than or equal to 10 numbers long
        /// </summary>
        /// <param name="e"></param>
        /// <param name="num">Phone number</param>
        internal static void PhoneNumberValidate(KeyPressEventArgs e, System.Windows.Forms.TextBox num)
        {
            if (char.IsDigit(e.KeyChar) && num.Text.Length < 10)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

        }

        /// <summary>
        /// This function is to set limitations on what can be entered into the title or suffix textboxes
        /// It ensures they are only letters, and less than or equal to 10 letters, as well as allowing control actions
        /// </summary>
        /// <param name="e"></param>
        /// <param name="text">Title or suffix</param>
        internal static void TitleSuffixVerify(KeyPressEventArgs e, System.Windows.Forms.TextBox text)
        {
            if ((char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) && text.Text.Length < 10)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// This function is to validate the first, middle, and last names.
        /// It ensures they only have letters and is less than or equal to 20 characters long
        /// and allows control operations
        /// </summary>
        /// <param name="e"></param>
        /// <param name="text">First, Middle, and Last names</param>
        internal static void NameValidation(KeyPressEventArgs e, System.Windows.Forms.TextBox text)
        {
            if (char.IsLetter(e.KeyChar) && text.Text.Length < 20)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }


        /// <summary>
        /// This function validates the zipcode, ensuring it only contains numbers, its no more than 10 digits long,
        /// is atleast 5 digits long, and allows control operations
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tbxZipcode"></param>
        internal static void ZipValidation(KeyPressEventArgs e, System.Windows.Forms.TextBox tbxZipcode)
        {

            if ((char.IsDigit(e.KeyChar)) && tbxZipcode.Text.Length < 10)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (tbxZipcode.Text.Length == 5)
            {
                if ("-".Contains(e.KeyChar) || char.IsControl(e.KeyChar))
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }


        }

        /// <summary>
        /// This function is to validate the addresses.
        /// It ensures they only have letters and is less than or equal to 30 characters long
        /// and allows control operations
        /// </summary>
        /// <param name="e"></param>
        /// <param name="text"></param>
        internal static void AddressValidation(KeyPressEventArgs e, System.Windows.Forms.TextBox text)
        {
            if ((char.IsLetterOrDigit(e.KeyChar) || " ".Contains(e.KeyChar)) && text.Text.Length < 30)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// This function is to validate the answers.
        /// It ensures they only have letters and is less than or equal to 20 characters long
        /// and allows control operations
        /// </summary>
        /// <param name="e"></param>
        /// <param name="text">Answers</param>
        internal static void AnswerValidation(KeyPressEventArgs e, System.Windows.Forms.TextBox text)
        {
            if ((char.IsLetterOrDigit(e.KeyChar) || " ".Contains(e.KeyChar)) && text.Text.Length < 20)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        /// <summary>city.
        /// It ensures they only have letters and is less than or equal to 20 characters long
        /// and allows control operations
        /// </summary>
        /// <param name="e"></param>
        /// <param name="text">City text</param>
        internal static void CityValidation(KeyPressEventArgs e, System.Windows.Forms.TextBox text)
        {
            if ((char.IsLetter(e.KeyChar) || " ".Contains(e.KeyChar)) && text.Text.Length < 20)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// This function is a final zipcode check, ensuring if the last thing entered is the dash then the zipcode is replaces with what the zipcode was
        /// but removing the dash
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tbxZipcode"></param>
        internal static void FinalZipCheck(EventArgs e, System.Windows.Forms.TextBox tbxZipcode)
        {
            char text = '\0';
            string textReplace = "";
            for (int i = 0; i < tbxZipcode.Text.Length; i++)
            {
                text = tbxZipcode.Text[i];
            }

            if (text == '-')
            {
                for (int i = 0; i < tbxZipcode.Text.Length - 1; i++)
                {
                    textReplace += tbxZipcode.Text[i];
                }
                tbxZipcode.Text = textReplace;
            }






        }
        
        /// <summary>
        /// This function is a final email check, ensuring the email is only letters and numbers, the only special
        /// characters are a previously specified set that is allowed, the length is no more than 40, and once again
        /// matches a set of specified strings. Then using a group of checks it ensures the email is acceptable,
        /// the period and at sign arent too close together, and checks that the email is atleast 5 characters long, and includes
        /// a period and at sign
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if the email is acceptable, false otherwise</returns>
        internal static bool FinalEmailCheck(System.Windows.Forms.TextBox email)
        {
            int emailCheckForAtSign = 0;
            int emailCheckForPeriods = 0;
            int AtSignPosition = 0;
            int PeriodPosition = 0;
            string EnglishChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string substring = "";
            byte[] asciiBytes;



            for (int i = 0; i < email.Text.Length - 1; i++)
            {
                bool match = Regex.IsMatch(email.Text, "^[a-zA-Z0-9]*$");


                if (!(char.IsLetterOrDigit(email.Text[i]) || "@.-_".Contains(email.Text[i])
                    || email.Text.Length > 40 || EnglishChar.Contains(email.Text[i]) || match))
                {


                    return false;
                }
                if (!(char.IsLetterOrDigit(email.Text[0]) || "_".Contains(email.Text[0])))
                {
                    Console.WriteLine("First letter");
                    return false;
                }
                if ("@".Contains(email.Text[i]))
                {
                    emailCheckForAtSign++;
                    AtSignPosition = i;

                    //  Console.WriteLine(AtSignPosition);
                }
                if (emailCheckForAtSign > 1)
                {
                    Console.WriteLine("At sign");
                    return false;
                }
                if (".".Contains(email.Text[i]))
                {
                    emailCheckForPeriods++;
                    PeriodPosition = i;
                    //  Console.WriteLine(PeriodPosition);
                }
                if (PeriodPosition > 0)
                {
                    if (".".Contains(email.Text[PeriodPosition]) && ".".Contains(email.Text[PeriodPosition + 1]))
                    {
                        Console.WriteLine("Bad Again");
                        return false;
                    }
                }
                if (!char.IsLetterOrDigit(email.Text[AtSignPosition]))
                {
                    // Console.WriteLine("At sign + 1");
                    // return false;
                }

                if ((AtSignPosition + 1) == PeriodPosition || (PeriodPosition + 1) == AtSignPosition || "-".Contains(email.Text[AtSignPosition + 1]))
                {
                    Console.WriteLine("Too close");
                    return false;
                }
            }

            asciiBytes = Encoding.ASCII.GetBytes(email.Text);


            for (int x = 0; asciiBytes.Length > x; x++)
            {


                if ((asciiBytes[x] < 64 || asciiBytes[x] > 122) && !(asciiBytes[x] == 45) && !(asciiBytes[x] == 46) && !(asciiBytes[x] == 151))
                {

                    Console.WriteLine("Non allowed charaters");
                    return false;

                }

            }



            if (emailCheckForAtSign > 0)
            {
                substring = email.Text.Substring(AtSignPosition + 1);
                IPAddress ip;
                bool ValidateIP = IPAddress.TryParse(substring, out ip);
                bool isAttemptedIp = true;
                for (int x = 0; x < substring.Length - 1; x++)
                {

                    if (!(char.IsDigit(substring[x]) || ".".Contains(substring[x])))
                    {

                        isAttemptedIp = false;

                    }
                }
                if (isAttemptedIp)
                {
                    if (!ValidateIP)
                    {
                        Console.WriteLine("Invalid IP Attempt");
                        return false;
                    }
                }

            }
            if (email.Text.Length > 0)
            {
                if ("@".Contains(email.Text[email.Text.Length - 1]))
                {


                }
            }
            //Console.WriteLine(emailCheckForAtSign);

            email.KeyPress += Email_Handled;
            if (emailCheckForAtSign == 1 && emailCheckForPeriods >= 1 && email.Text.Length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        /// <summary>
        /// This handles the initial email validadtion ensuring the email is only letters and numbers, the only special
        /// characters are a previously specified set that is allowed, the length is no more than 40.
        /// Then using a group of checks it ensures the email is acceptable, checks for an at sign and period
        /// 
        /// a period and at sign
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tbxEmail"></param>
        internal static void EmailValidation(KeyPressEventArgs e, System.Windows.Forms.TextBox tbxEmail)
        {


            //"-" "_" valid

            if ((char.IsLetterOrDigit(e.KeyChar) || "@.-_".Contains(e.KeyChar)) && tbxEmail.Text.Length < 40 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                Console.WriteLine("false");
            }
            else
            {
                e.Handled = true;
                Console.WriteLine("true");
            }
            if (tbxEmail.Text.Length < 1 && "@.".Contains(e.KeyChar))
            {
                e.Handled = true;
                Console.WriteLine("true");
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                Console.WriteLine("false");
            }
            //   Console.WriteLine(tbxEmail.Text.Length + "\nSplit" + PeriodPosition);





            if ((tbxEmail.Text.Length - 1) > 0)
            {


                if ("@".Contains(tbxEmail.Text[tbxEmail.Text.Length - 1]))
                {
                    if (!char.IsLetterOrDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                //period stuff
                if (".".Contains(tbxEmail.Text[tbxEmail.Text.Length - 1]))
                {
                    emailCheckForPeriods = 1;
                    if (PeriodPosition == 0)
                    {
                        PeriodPosition = tbxEmail.Text.Length - 1;

                    }
                    //  Console.WriteLine(PeriodPosition);
                }



            }
            if (PeriodPosition > 0)
            {

                if (".".Contains(e.KeyChar))
                {
                    if (PeriodPosition == tbxEmail.Text.Length - 1)
                    {
                        e.Handled = true;
                    }
                }
            }

            if (tbxEmail.Text.Contains("@"))
            {

                emailCheckForAtSign = 1;


            }
            else
            {
                emailCheckForAtSign = 0;
            }

            //@ sign finished work on periods and the rest


            if (!tbxEmail.Text.Contains("."))
            {

                emailCheckForPeriods = 0;
                PeriodPosition = 0;

            }
            if ("@".Contains(e.KeyChar) && emailCheckForAtSign > 0)
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
            {
                isBackspace = true;
            }
            else
            {
                isBackspace = false;
            }
        }
        internal static void Email_Handled(object sender, KeyPressEventArgs e)
        {

        }


    }
}