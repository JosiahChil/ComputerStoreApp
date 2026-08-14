using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class allows the user to login, between employee, manager, and customer. If the user is a customer, and fulfills a set of requirements,
    /// it also allows the user to register for the rewards system
    /// </summary>
    public partial class frmLogin : Form
    {

        public static bool guest = false;
        public static string username = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        int visibility = 0;



        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AllowedKeys(e, tbxPassword);
        }

        /// <summary>
        /// This function simply changes the visibility of the password textbox depending on how many times the reveal button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPasswordHideShow_Click(object sender, EventArgs e)
        {

            visibility++;
            if (visibility == 1)
            {
                tbxPassword.UseSystemPasswordChar = false;
                visibility = -1;
            }
            if (visibility == 0)
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }




        /// <summary>
        /// This function hides the current form and opens the forgot password form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmForgotPassword forgot = new frmForgotPassword();
            forgot.Show();
            this.Hide();

        }

        /// <summary>
        /// This function hides the current form and opens the create form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount create = new frmCreateAccount();
            create.Show();
            this.Hide();
        }

        /// <summary>
        /// This function takes the username and password entered and runs it through another function. It returns a number depending on the customers position in the company.
        /// If the user is a manager it welcomes the user as a manager and sends the user to the manager form, 
        /// while also saving the users username by sending the text to that class's global variable.
        /// If the user is an employee, it does the same as the manager except it sends the user to the employee form.
        /// If the user is a customer, it first welcomes the user. Then once they are welcomed it takes the users username and password and passes it through another function.
        /// The function returns an ID which is saved to a global variable in another form along with the username. Then the id and username is passed through yet another function,
        /// and the function returns a true or false value, checking if the user is registered in the rewards system already.
        /// If the value is true and the login id is not -1, the application will prompt the user to enroll in the rewards program.
        /// If the user selects yes the program passes the login id and username through another program checking to see if they were a previous user since before the reward program
        /// was created. If so the user gets an initial boost in points when they register, if not then the user would start with 0 points.
        /// Once the initial points is calculated, the user is sent to the rewards form, along with the logon id username and point amount, where the user will accept the terms
        /// and register. 
        /// If the user denied joining the rewards, then the user is simply sent to the customer form.
        /// Additionally, if the user is already in the rewards, they are simply sent to the customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            guest = false;
            username = tbxUsername.Text;


            int login = clsSQL.Login(tbxUsername.Text, tbxPassword.Text);
            switch (login)
            {
                case 1:
                    MessageBox.Show("Welcome Manager!", "Welcome",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //gets 

                    frmManager.managerID = clsSQL.GetUserID(username);
                    frmManager manager = new frmManager();
                    manager.Show();
                    this.Hide();
                    break;

                case 2:
                    MessageBox.Show("Welcome Employee!", "Welcome",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManager.managerID = clsSQL.GetUserID(username);
                    frmManager manager2 = new frmManager();
                    manager2.Show();
                    this.Hide();
                    break;

                case 3:
                    DialogResult enrollment = DialogResult.No;
                    MessageBox.Show("Welcome Customer!", "Welcome",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int logonID = clsSQL.GetLogonID(username, tbxPassword.Text);
                    frmShoppingCart.LogonID = logonID;
                    frmShoppingCart.LogonName = username;
                    bool notInRewards = clsSQL.CheckInRewards(logonID, username);

                    if (!notInRewards && logonID != -1)
                    {
                        enrollment = MessageBox.Show("Welcome existing customer! It has been detected that you are qualified " +
                            "to enroll in our rewards program! Proceed to the rewards page?", "Rewards program enrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (enrollment == DialogResult.Yes)
                        {
                            bool oldUser = clsSQL.CheckUserDate(logonID, username);

                            if (oldUser)
                            {
                                //500 points automatically for old users
                                //make sure they dont get the points every time
                                frmRewards.LogonID = logonID;
                                frmRewards.LogonName = username;
                                frmRewards.points = 500;

                            }
                            else
                            {
                                frmRewards.LogonID = logonID;
                                frmRewards.LogonName = username;
                                frmRewards.points = 0;

                            }
                            frmRewards rewards = new frmRewards();
                            rewards.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmCustomer.hasAccount = true;
                            frmCustomer Customer = new frmCustomer();
                            Customer.Show();
                            this.Hide();
                            break;
                        }

                    }
                    else
                    {
                        frmCustomer.hasAccount = true;
                        frmCustomer Customer = new frmCustomer();
                        Customer.Show();
                        this.Hide();
                        break;
                    }

                    break;

                case -1:
                    MessageBox.Show("Your username or password is incorrect", "Invalid Credentials",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }





        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            string fullPath;
            fullPath = Path.GetFullPath("Help\\Login.chm");
            Help.ShowHelp(this, hlpLogin.HelpNamespace);
            Console.WriteLine(hlpLogin.HelpNamespace);
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            //does nothing for now
        }


        /// <summary>
        /// This function hides the current form and opens the customer form as a guest, not allowing the user to actually purchase anything
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            guest = true;
            frmCustomer Customer = new frmCustomer();
            Customer.Show();
            this.Hide();
        }






/// <summary>
/// Ignore this function i use this for testing various things. This function is not bound to anything and is not called at all
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {


            string dbFileName = "JosiahChildressCompStore.db";
        // Get the full path by combining the current directory with the filename
         string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "JosiahChildressCompStore.db");
        // Connection string using the full path
         string SQLiteConn = $"Data Source={dbPath}";
            Console.WriteLine(SQLiteConn);
        var sql = "SELECT * FROM testsecurity";
            var id = 2;
            var SetId = 1;
            var question = "Test Question2222";
            var logonID = 1;
            var logonName = "example222";
            var points = 500;
            try
            {
                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();


                    sql = "INSERT INTO testPerson (PersonID, Title,NameFirst,NameMiddle,NameLast,Suffix,Address1,Address2,City,Zipcode" +
                       ",State,Email,PhonePrimary,PhoneSecondary,Image,PositionID,PersonDeleted)" +
                       " VALUES (@id, @title,@first,@middle,@last,@suffix,@address1,@address2,@city,@zip,@state,@email,@phoneprimary" +
                       ",@phonesecondary,@image,@pos,@persondel)";



                    //somethings broken here
                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        Console.WriteLine(sql);
                        cmd.Parameters.AddWithValue("id", 0);

                        cmd.Parameters.AddWithValue("@title", "Test");

                        cmd.Parameters.AddWithValue("@first", "Test");

                        cmd.Parameters.AddWithValue("@middle", "Test");

                        cmd.Parameters.AddWithValue("@last", "Test");

                        cmd.Parameters.AddWithValue("@suffix", "Test");

                        cmd.Parameters.AddWithValue("@address1", "Test");

                        cmd.Parameters.AddWithValue("@address2", "Test");

                        cmd.Parameters.AddWithValue("@city", "Test");

                        cmd.Parameters.AddWithValue("@zip", "55555");

                        cmd.Parameters.AddWithValue("@state", "TX");

                        cmd.Parameters.AddWithValue("@email", "Test");

                        cmd.Parameters.AddWithValue("@phoneprimary", "4444444444");

                        cmd.Parameters.AddWithValue("@phonesecondary", "4444444444");

                        cmd.Parameters.AddWithValue("@image", DBNull.Value);

                        cmd.Parameters.AddWithValue("@pos", "1000");

                        cmd.Parameters.AddWithValue("@persondel", "09");

                       // cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error insert into rewards", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

