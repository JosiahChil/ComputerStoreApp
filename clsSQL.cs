using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This is the class for all of the SQLite items
    /// </summary>
    internal class clsSQL
    {
   
        /// <summary>
        /// This is the connection string to the database
        /// </summary>
        public static string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "JosiahChildressCompStore.db");
        public static string SQLiteConn = $"Data Source={dbPath}";




        /// <summary>
        /// This function ccesses database to load various questions into a set of comboboxes that load into the application
        /// </summary>
        /// <param name="cbFirstQuestion"></param>
        /// <param name="cbSecondQuestion"></param>
        /// <param name="cbThirdQuestion"></param>
        internal static void Load(ComboBox cbFirstQuestion, ComboBox cbSecondQuestion, ComboBox cbThirdQuestion)
        {


            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT QuestionPrompt FROM SecurityQuestions WHERE SetID = 1";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbFirstQuestion.Items.Add(reader.GetString(0));
                        }

                    }
                    command.CommandText = "SELECT QuestionPrompt FROM SecurityQuestions WHERE SetID = 2";


                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            cbSecondQuestion.Items.Add(reader.GetString(0));
                        }
                    command.CommandText = "SELECT QuestionPrompt FROM SecurityQuestions WHERE SetID = 3";


                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            cbThirdQuestion.Items.Add(reader.GetString(0));
                        }






                }
            }
        }


        /// <summary>
        /// This function takes a handful of variables taken from the application and inserts then into various tables all at once, as well as verifying the data is acceptable
        /// </summary>
        /// <param name="tbxTitle"></param>
        /// <param name="tbxFirstName"></param>
        /// <param name="tbxMiddleName"></param>
        /// <param name="tbxLastName"></param>
        /// <param name="tbxSuffix"></param>
        /// <param name="tbxAddress"></param>
        /// <param name="tbxSecondAddress"></param>
        /// <param name="tbxCity"></param>
        /// <param name="tbxZipcode"></param>
        /// <param name="cbState"></param>
        /// <param name="tbxEmail"></param>
        /// <param name="tbxPhoneNumber"></param>
        /// <param name="tbxSecondaryPhoneNumber"></param>
        /// <param name="tbxUsername"></param>
        /// <param name="tbxPassword"></param>
        /// <param name="cbFirstQuestion"></param>
        /// <param name="tbxFirstAnswer"></param>
        /// <param name="cbSecondQuestion"></param>
        /// <param name="tbxSecondAnswer"></param>
        /// <param name="cbThirdQuestion"></param>
        /// <param name="tbxThirdAnswer"></param>
        /// <param name="position"></param>
        /// <param name="deleted"></param>
        /// <param name="disabled"></param>
        internal static void Register(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName,
            TextBox tbxSuffix, TextBox tbxAddress, TextBox tbxSecondAddress, TextBox tbxCity, TextBox tbxZipcode, ComboBox cbState,
            TextBox tbxEmail, TextBox tbxPhoneNumber, TextBox tbxSecondaryPhoneNumber, TextBox tbxUsername, TextBox tbxPassword,
            ComboBox cbFirstQuestion, TextBox tbxFirstAnswer, ComboBox cbSecondQuestion, TextBox tbxSecondAnswer, ComboBox cbThirdQuestion, TextBox tbxThirdAnswer,
            string position, string deleted, string disabled)
        {

            //SqlCommand cmd;
            string sql = "";
            int posID;


            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();


                try
                {
                    posID = 0;
                    sql = "SELECT PositionID FROM Position WHERE PositionTitle = '" + position + "'";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                posID = (reader.GetInt32(0));
                            }
                        }
                    }







                    sql = "INSERT INTO Person (Title,NameFirst,NameMiddle,NameLast,Suffix,Address1,Address2,City,Zipcode" +
                       ",State,Email,PhonePrimary,PhoneSecondary,Image,PositionID,PersonDeleted)" +
                       " VALUES (@title,@first,@middle,@last,@suffix,@address1,@address2,@city,@zip,@state,@email,@phoneprimary" +
                       ",@phonesecondary,@image,@pos,@persondel)";



                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("@title",
                                                string.IsNullOrEmpty(tbxTitle.Text) ? (object)DBNull.Value : tbxTitle.Text);

                        cmd.Parameters.AddWithValue("@first", tbxFirstName.Text);

                        cmd.Parameters.AddWithValue("@middle",
                       string.IsNullOrEmpty(tbxMiddleName.Text) ? (object)DBNull.Value : tbxMiddleName.Text);

                        cmd.Parameters.AddWithValue("@last", tbxLastName.Text);

                        cmd.Parameters.AddWithValue("@suffix",
                       string.IsNullOrEmpty(tbxSuffix.Text) ? (object)DBNull.Value : tbxSuffix.Text);

                        cmd.Parameters.AddWithValue("@address1", tbxAddress.Text);

                        cmd.Parameters.AddWithValue("@address2",
                       string.IsNullOrEmpty(tbxSecondAddress.Text) ? (object)DBNull.Value : tbxSecondAddress.Text);

                        cmd.Parameters.AddWithValue("@city", tbxCity.Text);

                        cmd.Parameters.AddWithValue("@zip", tbxZipcode.Text);

                        cmd.Parameters.AddWithValue("@state", cbState.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue("@email",
                            string.IsNullOrEmpty(tbxEmail.Text) ? (object)DBNull.Value : tbxEmail.Text);

                        cmd.Parameters.AddWithValue("@phoneprimary",
                            string.IsNullOrEmpty(tbxPhoneNumber.Text) ? (object)DBNull.Value : tbxPhoneNumber.Text);

                        cmd.Parameters.AddWithValue("@phonesecondary",
                       string.IsNullOrEmpty(tbxSecondaryPhoneNumber.Text) ? (object)DBNull.Value : tbxSecondaryPhoneNumber.Text);

                        cmd.Parameters.AddWithValue("@image", DBNull.Value);

                        cmd.Parameters.AddWithValue("@pos", posID);

                        cmd.Parameters.AddWithValue("@persondel", deleted);

                        cmd.ExecuteNonQuery();

                    }


                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine(ex.Message, "SQLite Error create customer 1st part", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                int personID = 0;
                sql = "SELECT PersonID FROM Person WHERE NameFirst = '" + tbxFirstName.Text + "' and NameLast = '" + tbxLastName.Text + "'";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personID = (reader.GetInt32(0));
                        }
                    }
                }

                int firstQuestionID = 0;
                int secondQuestionID = 0;
                int thirdQuestionID = 0;
                int count = 0;
                sql = "SELECT QuestionID FROM SecurityQuestions WHERE QuestionPrompt = '" + cbFirstQuestion.SelectedItem.ToString() + "' or " +
                    "QuestionPrompt = '" + cbSecondQuestion.SelectedItem.ToString() + "' or QuestionPrompt = '" + cbThirdQuestion.SelectedItem.ToString() + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (count == 0)
                            {
                                firstQuestionID = (reader.GetInt32(0));
                            }
                            if (count == 1)
                            {
                                secondQuestionID = (reader.GetInt32(0));
                            }
                            if (count == 2)
                            {
                                thirdQuestionID = (reader.GetInt32(0));
                            }

                            count++;
                        }

                }




                posID = 0;
                sql = "SELECT PositionID FROM Person WHERE NameFirst = '" + tbxFirstName.Text + "' and NameLast = '" + tbxLastName.Text + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            posID = (reader.GetInt32(0));
                        }
                }
                string posTitle = "";
                sql = "SELECT PositionTitle FROM Position WHERE PositionID = " + posID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            posTitle = (reader.GetString(0));
                        }
                }
                try
                {

                    sql = "INSERT INTO Logon (PersonID,LogonName,Password" +
                        ",FirstChallengeQuestion,FirstChallengeAnswer,SecondChallengeQuestion,SecondChallengeAnswer" +
                        ",ThirdChallengeQuestion,ThirdChallengeAnswer,PositionTitle,AccountDisabled,AccountDeleted)" +
                        " VALUES (@person,@logonname,@password,@firstquestion,@firstanswer,@secondquestion" +
                        ",@secondanswer,@thirdquestion,@thirdanswer,@postitle,@accdisabled,@accdeleted)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {


                        cmd.Parameters.AddWithValue("@person", personID);

                        cmd.Parameters.AddWithValue("@logonname", tbxUsername.Text);

                        cmd.Parameters.AddWithValue("@password", tbxPassword.Text);

                        cmd.Parameters.AddWithValue("@firstquestion", firstQuestionID);

                        cmd.Parameters.AddWithValue("@firstanswer", tbxFirstAnswer.Text);

                        cmd.Parameters.AddWithValue("@secondquestion", secondQuestionID);

                        cmd.Parameters.AddWithValue("@secondanswer", tbxSecondAnswer.Text);

                        cmd.Parameters.AddWithValue("@thirdquestion", thirdQuestionID);

                        cmd.Parameters.AddWithValue("@thirdanswer", tbxThirdAnswer.Text);

                        cmd.Parameters.AddWithValue("@postitle", posTitle);

                        cmd.Parameters.AddWithValue("@accdisabled", disabled);

                        cmd.Parameters.AddWithValue("@accdeleted", deleted);

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message, "SQLite Error create customer 2nd part", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                MessageBox.Show("Account Created!");

            }

        }

        /// <summary>
        /// This function simply takes the username passed into it and checks it against all names in the logon table, returning true if any matches occur, otherwise returning false
        /// </summary>
        /// <param name="username"></param>
        /// <returns>true if username is in database, otherwise false</returns>
        internal static bool CheckUsername(string username)
        {
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();

                string sql = "SELECT LogonName FROM Logon";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (username == reader.GetString(0))
                            {

                                return true;
                            }
                        }
                }

            }
            return false;
        }


        /// <summary>
        /// This function retrieves questions from the database according to the username of the current user, and loads them into textboxes to display on the application
        /// </summary>
        /// <param name="username"></param>
        /// <param name="tbxFirstQuestion"></param>
        /// <param name="tbxSecondQuestion"></param>
        /// <param name="tbxThirdQuestion"></param>
        internal static void WriteQuestions(string username, TextBox tbxFirstQuestion, TextBox tbxSecondQuestion, TextBox tbxThirdQuestion)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();

                int firstQuestionID = 0;
                int secondQuestionID = 0;
                int thirdQuestionID = 0;
                string sql = "SELECT FirstChallengeQuestion,SecondChallengeQuestion,ThirdChallengeQuestion FROM Logon WHERE LogonName = '" + username + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            firstQuestionID = (reader.GetInt32(0));
                            secondQuestionID = (reader.GetInt32(1));
                            thirdQuestionID = (reader.GetInt32(2));
                        }
                }

                sql = "SELECT QuestionPrompt FROM SecurityQuestions WHERE QuestionID = " + firstQuestionID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            tbxFirstQuestion.Text = (reader.GetString(0));
                        }
                }
                sql = "SELECT QuestionPrompt FROM SecurityQuestions WHERE QuestionID = " + secondQuestionID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            tbxSecondQuestion.Text = (reader.GetString(0));
                        }
                }
                sql = "SELECT QuestionPrompt FROM SecurityQuestions WHERE QuestionID = " + thirdQuestionID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            tbxThirdQuestion.Text = (reader.GetString(0));
                        }

                }


            }
        }


        /// <summary>
        /// This function retrieves the answers to the questions in the 'WriteQuestions' function according to the username of the current user,
        /// and if the user enters the answers retrieved and they all match returns true, else returns false
        /// </summary>
        /// <param name="username"></param>
        /// <param name="answer1"></param>
        /// <param name="answer2"></param>
        /// <param name="answer3"></param>
        /// <returns>true if all three answers are found in database under username's data, otherwise false</returns>
        internal static bool SecurityAnswers(string username, string answer1, string answer2, string answer3)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();

                string sql = "SELECT FirstChallengeAnswer,SecondChallengeAnswer,ThirdChallengeAnswer FROM Logon WHERE LogonName = '" + username + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            //(reader.GetString(0))
                            if (answer1.ToUpper() == reader.GetString(0).ToUpper() && answer2.ToUpper() == reader.GetString(1).ToUpper() 
                                && answer3.ToUpper() == reader.GetString(2).ToUpper())
                            {

                                return true;
                            }
                        }
                }

                return false;
            }
        }

        /// <summary>
        /// This function updates the database, setting the password specific to the user via checking for a matching username
        /// </summary>
        /// <param name="username"></param>
        /// <param name="newPassword"></param>
        internal static void UpdatePassword(string username, string newPassword)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();


                string sql = "UPDATE Logon SET Password = '" + newPassword + "' WHERE LogonName = '" + username + "'";
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password changed!");
            }

        }


        /// <summary>
        /// This function takes the username and password of the user attempting to login and reads both of them against data in the database.
        /// If the data matches it returns the appropriate position from the database between
        /// manager, employee, or customer as well as a default response incase the username and password dont match
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>A number signifying the users access level, 1 for manager, 2 for employee, 3 for customer, -1 for not found</returns>
        internal static int Login(string username, string password)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();

                int response = -1;

                string position = "";
                string sql = "SELECT LogonName,Password,PositionTitle FROM Logon";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {


                            if (username == reader.GetString(0) && password == reader.GetString(1))
                            {
                                position = reader.GetString(2);
                            }

                        }
                }

                switch (position.ToUpper())
                {

                    case "MANAGER":
                        response = 1;
                        break;

                    case "EMPLOYEE":
                        response = 2;
                        break;

                    case "CUSTOMER":
                        response = 3;
                        break;

                    default:
                        response = -1;
                        break;





                }


                return response;
            }
        }


        /// <summary>
        /// This function takes the username of the customer registering and checks it against all usernames in the database,
        /// ensuring the username is unique and not a duplicate. If anything from the database matches the function returns false,
        /// making the registration fail, otherwise it returns true
        /// </summary>
        /// <param name="username"></param>
        /// <returns>true is the username does not match anything already in the database, else false</returns>
        internal static bool UsernameUnique(string username)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT LogonName FROM Logon";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (username.ToUpper() == reader.GetString(0).ToUpper())
                            {

                                return false;
                            }
                        }
                }
            }
            return true;
        }

        /// <summary>
        /// This function adds all items from the database to the passed list as long as they arent listed as discontinued
        /// </summary>
        /// <param name="items"></param>
        internal static void GetNumberItems(List<int> items)
        {
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT InventoryID, Discontinued FROM Inventory";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {


                            if (!reader.GetBoolean(1))
                            {

                                items.Add(reader.GetInt32(0));
                            }

                        }
                }

            }



        }

        /// <summary>
        /// This function gets all inventory ids and names and checks the inventory id on the parameter passed.
        /// If a match occurs it reassigns the variable name and returns whatever is stored in the name variable
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        internal static string GetTextName(int itemID)
        {
            string name = "";
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT InventoryID, ItemName FROM Inventory";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {

                            if (itemID == reader.GetInt32(0))
                            {
                                name = reader.GetString(1);

                            }
                        }

                }
            }

            return name;

        }



        /// <summary>
        /// This function gets all the inventory ids and prices from the database, checking each id by the passed variable and once a match is 
        /// found it reassigns the price from the database to the local price variable.
        /// Afterwards it returns whatever the local price variable is holding
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        internal static string GetTextPrice(int itemID)
        {
            string price = "";
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT InventoryID, RetailPrice FROM Inventory";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {

                            if (itemID == reader.GetInt32(0))
                            {
                                price = "$" + reader.GetDecimal(1).ToString();

                            }
                        }

                }
            }

            return price;
        }

        /// <summary>
        /// This function gets all inventory ids where the item name contains what the text parameter contains.
        /// Then it adds the id to an array as long as the item isnt marked as discontinued
        /// </summary>
        /// <param name="searchedId"></param>
        /// <param name="text">Search text</param>
        internal static void GetSomeNumberItems(int[] searchedId, string text)
        {
            int i = 0;
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT InventoryID, Discontinued FROM Inventory WHERE itemname LIKE '%" + text + "%'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (!reader.GetBoolean(1))
                            {
                                searchedId[i] = reader.GetInt32(0);

                                i++;
                            }
                        }
                }

            }





        }

        /// <summary>
        /// This function gets all inventory ids where the item name contains what the text parameter contains. 
        /// Then it adds to the integer variable as long as the item is not marked as discontinued. 
        /// If it is marked as discontinued then it subtracts from the value
        /// </summary>
        /// <param name="text">Search text</param>
        /// <returns>Number of items</returns>
        internal static int GetAmountNumberItems(string text)
        {
            int numItems = 0;

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT ItemName, Discontinued FROM Inventory WHERE itemname LIKE '%" + text + "%'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            numItems++;

                            if (reader.GetBoolean(1))
                            {
                                numItems--;
                            }
                        }

                }
            }


            return numItems;
        }

        /// <summary>
        /// This function simply adds all category names from the database to the passed combo box
        /// </summary>
        /// <param name="cbCategory"></param>
        internal static void AddItems(ComboBox cbCategory)
        {


            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT CategoryName FROM Categories";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            cbCategory.Items.Add(reader.GetString(0));
                        }

                }
            }


        }


        /// <summary>
        /// This function gets all inventory ids where the category name of the item matches the name passed in the parameter.
        /// If there is a match it will add one to a variable which is returned at the end of the function.
        /// If the item is discontinued it will subtract one instead
        /// </summary>
        /// <param name="selectedText"></param>
        /// <returns>Number of items</returns>
        internal static int GetAmountNumberItemsCategory(string selectedText)
        {
            int numItems = 0;
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT Inventory.InventoryID, Categories.CategoryName, Inventory.Discontinued FROM Inventory " +
                "INNER JOIN Categories ON Inventory.CategoryID = Categories.CategoryID " +
                "WHERE CategoryName = '" + selectedText + "' ";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            numItems++;

                            if (reader.GetBoolean(2))
                            {
                                numItems--;
                            }
                        }

                }
            }
            return numItems;

        }

        /// <summary>
        /// This function takes the parameters and gets information from the database based on the selected item text.
        /// It then inserts the category names into the passed array
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="text">Selected item</param>
        internal static void GetCategoryItems(int[] categoryId, string text)
        {
            int i = 0;

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT Inventory.InventoryID, Categories.CategoryName, Inventory.Discontinued FROM Inventory " +
            "INNER JOIN Categories ON Inventory.CategoryID = Categories.CategoryID " +
            "WHERE CategoryName = '" + text + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (!reader.GetBoolean(2))
                            {
                                categoryId[i] = reader.GetInt32(0);

                                i++;
                            }


                        }
                }
            }
        }





        /// <summary>
        /// This function gets the image from the database based on the index passed
        /// </summary>
        /// <param name="index">Image index</param>
        /// <returns>Image</returns>
        internal static System.Drawing.Image GetImage(int index)
        {

            byte[] bImage = new byte[0];
            int y = 0;
            System.Drawing.Image x = null;
            try
            {


                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql = "SELECT ItemImage FROM Inventory WHERE InventoryID = " + index;

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        byte[] bytes = (byte[])cmd.ExecuteScalar();

                        MemoryStream memory = new MemoryStream(bytes);

                        x = System.Drawing.Image.FromStream(memory);



                        //(174, 133)
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error Drawing Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            return x;
        }

        /// <summary>
        /// This function is getting a handfull of information from the daatabase based on the passed ID.
        /// It takes database information to write to a rich text box, as well as clearing and refilling the quantity combo box,
        /// and informs the user of the quantity limit via a label
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="picBox"></param>
        /// <param name="detailsText"></param>
        /// <param name="cbQuantity"></param>
        /// <param name="lbText"></param>
        internal static void GetDetails(int ID, PictureBox picBox, RichTextBox detailsText, ComboBox cbQuantity, System.Windows.Forms.Label lbText)
        {
            detailsText.Text = "";
            lbText.Text = "";
            System.Drawing.Image image = clsSQL.GetImage(ID);
            Bitmap image2 = new Bitmap(image, new Size(300, 300));
            picBox.Image = image2;
            int num = 0;
            using (SQLiteConnection sQLiteConnection = new SQLiteConnection(clsSQL.SQLiteConn))
            {
                sQLiteConnection.Open();
                string commandText = "SELECT ItemDescription, Quantity, RetailPrice FROM Inventory WHERE InventoryID = " + ID.ToString();
                using (SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand())
                {
                    sQLiteCommand.CommandText = commandText;
                    using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader())
                    {
                        while (sQLiteDataReader.Read())
                        {
                            detailsText.Text = string.Concat(new string[]
                            {
                        sQLiteDataReader.GetString(0),
                        "\nQuantity: ",
                        sQLiteDataReader.GetInt32(1).ToString(),
                        "\nPrice: $",
                        sQLiteDataReader.GetDecimal(2).ToString()
                            });
                            num = sQLiteDataReader.GetInt32(1);
                            lbText.Text = "Quantity\n Can not Exceed " + sQLiteDataReader.GetInt32(1).ToString();
                        }
                    }
                }
            }
            cbQuantity.Items.Clear();
            for (int i = 0; i <= num; i++)
            {
                cbQuantity.Items.Add(i.ToString());
            }
        }

        /// <summary>
        /// This function is for loading an array with a selection of information from the database
        /// loading it all into an array
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Quantity"></param>
        /// <returns>Array of data to add to datagridview</returns>
        internal static string[] CartData(int ID, int Quantity)
        {
            string[] strings = new string[4];
            decimal total = 0;





            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT ItemName, RetailPrice FROM Inventory WHERE InventoryID = " + ID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            strings[0] = reader.GetString(0);
                            strings[1] = "$" + reader.GetDecimal(1).ToString();
                            strings[2] = Quantity.ToString();
                            total = (reader.GetDecimal(1) * Quantity);
                            strings[3] = total.ToString("C", CultureInfo.CurrentCulture);
                        }



                }
            }





            return strings;
        }

        /// <summary>
        /// This function first sets the discount ID to null if no discount was used, then slightly edits the creditcard number before inserting
        /// the information into the database then calls another function, passing global variables and one local variable
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="discountID"></param>
        /// <param name="date"></param>
        /// <param name="creditCard"></param>
        /// <param name="creditCardDate"></param>
        /// <param name="ccv"></param>
        /// <param name="employeeID"></param>
        internal static void orders(int userID, int? discountID, string date, string creditCard, string creditCardDate, string ccv, int? employeeID)
        {
            if (discountID == 0)
            {
                discountID = null;
            }

            //  creditCardDate = creditCardDate.Replace("/", "");
            creditCard = creditCard.Replace("-", "");
            DateTime today = DateTime.Today;




            string sql;
            try
            {
                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    sql = "INSERT INTO Orders (DiscountID, PersonID, EmployeeID, OrderDate, CC_Number, ExpDate, CCV)" +
                          " VALUES (@discountID, @personID, @employeeID, @orderDate, @ccnumber, @expDate, @ccv)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@discountID",
                           string.IsNullOrEmpty(discountID.ToString()) ? (object)DBNull.Value : discountID.ToString());

                        cmd.Parameters.AddWithValue("@personID",
                               string.IsNullOrEmpty(userID.ToString()) ? (object)DBNull.Value : userID.ToString());

                        cmd.Parameters.AddWithValue("@employeeID",
                               string.IsNullOrEmpty(employeeID.ToString()) ? (object)DBNull.Value : employeeID.ToString());

                        cmd.Parameters.AddWithValue("@orderDate",
                               string.IsNullOrEmpty(today.ToString()) ? (object)DBNull.Value : today);

                        cmd.Parameters.AddWithValue("@ccnumber",
                               string.IsNullOrEmpty(creditCard) ? (object)DBNull.Value : creditCard);

                        cmd.Parameters.AddWithValue("@expDate",
                               string.IsNullOrEmpty(creditCardDate.ToString()) ? (object)DBNull.Value : creditCardDate);

                        cmd.Parameters.AddWithValue("@ccv",
                               string.IsNullOrEmpty(ccv) ? (object)DBNull.Value : ccv);



                        cmd.ExecuteNonQuery();
                    }
                }

                for (int i = 0; i < frmShoppingCart.itemIDCart.Count; i++)
                {
                    orderDetails(frmShoppingCart.itemIDCart[i], frmShoppingCart.itemQuantityCart[i], discountID);
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Sqlite Error Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }


        /// <summary>
        /// This function first retrieves the order id of the last order inserted into the database, and
        /// uses that order id with a set of passed variables to insert information into the database
        /// </summary>
        /// <param name="inventoryID"></param>
        /// <param name="quantity"></param>
        /// <param name="discountID"></param>
        internal static void orderDetails(int inventoryID, int quantity, int? discountID)
        {
            try
            {

                int orderID = 0;



                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT OrderID FROM Orders;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    orderID = reader.GetInt32(0);
                                }
                            }

                    }


                    sql = "INSERT INTO OrderDetails (OrderID, InventoryID, DiscountID, Quantity)" +
                          " VALUES (@orderID, @inventoryID, @discountID, @quantity)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {


                        cmd.Parameters.AddWithValue("@orderID",
                       string.IsNullOrEmpty(orderID.ToString()) ? (object)DBNull.Value : orderID.ToString());

                        cmd.Parameters.AddWithValue("@inventoryID",
                               string.IsNullOrEmpty(inventoryID.ToString()) ? (object)DBNull.Value : inventoryID.ToString());

                        cmd.Parameters.AddWithValue("@discountID",
                               string.IsNullOrEmpty(discountID.ToString()) ? (object)DBNull.Value : discountID.ToString());

                        cmd.Parameters.AddWithValue("@quantity",
                               string.IsNullOrEmpty(quantity.ToString()) ? (object)DBNull.Value : quantity.ToString());


                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Sqlite Error Orders details", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        /// <summary>
        /// This function retrieves data from the database and uses the data to reassign a set of global variables, as well as get the item id
        /// where the discount code is equal to the code passed
        /// </summary>
        /// <param name="code"></param>
        /// <returns>the item ID, or 0</returns>
        internal static int checkCode(string code)
        {

            //string today = DateTime.Now.ToString("yyyy-dd-MM");
            DateTime today = DateTime.Today;
            DateTime startDate;
            DateTime endDate;
            bool startValid = true;
            bool endValid = false;

            int itemID = 0;
            int type = 0;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT DiscountCode,DiscountID,DiscountPercentage,DiscountDollarAmount," +
                        "DiscountLevel,DiscountType,StartDate,ExpirationDate, InventoryID FROM Discounts WHERE DiscountCode = '" + code + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {


                                if (!reader.IsDBNull(1))
                                {
                                    frmShoppingCart.discountID = reader.GetInt32(1);
                                }
                                if (!reader.IsDBNull(2))
                                {
                                    frmShoppingCart.discountPercent = reader.GetDecimal(2);
                                }
                                if (!reader.IsDBNull(3))
                                {

                                    frmShoppingCart.discountAmount = reader.GetDecimal(3);
                                }
                                frmShoppingCart.discountLevel = reader.GetInt32(4);
                                frmShoppingCart.discountType = reader.GetInt32(5);


                                type = reader.GetInt32(5);

                                if (!reader.IsDBNull(6))
                                {
                                    startDate = reader.GetDateTime(6);

                                    if (today <= startDate)
                                    {
                                        startValid = false;
                                    }

                                }
                                endDate = reader.GetDateTime(7);

                                if (endDate >= today)
                                {
                                    endValid = true;
                                }
                                else
                                {
                                    endValid = false;
                                }
                                if (!reader.IsDBNull(8))
                                {
                                    itemID = (int)reader.GetInt32(8);
                                }


                                if (reader.GetInt32(5) == 0)
                                {
                                    frmShoppingCart.discountAmount = -1;
                                }
                                else if (reader.GetInt32(5) == 1)
                                {
                                    frmShoppingCart.discountPercent = -1;
                                }

                            }
                        if (startValid == true && endValid == true)
                        {
                            frmShoppingCart.dateValid = true;
                        }
                        else
                        {
                            frmShoppingCart.dateValid = false;
                        }


                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Sqlite checkcode", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }












            return itemID;

        }

        /// <summary>
        /// This function retrieves the item name corresponding to the ID passed
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns>Item name, or empty string</returns>
        internal static string getItemName(int itemID)
        {

            string name = "";
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT ItemName FROM Inventory WHERE InventoryID = " + itemID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            name = reader.GetString(0);
                        }


                }
            }



            return name;
        }

        /// <summary>
        /// This function retrieves the inventory id of an item corresponding to the code passed to the function
        /// and will return true or false depending on if the inventory id retrieved is equal to any ids in the cart
        /// </summary>
        /// <param name="code"></param>
        /// <returns>true if item id of the item retrieved in database is equal to an item in the cart, else returns false</returns>
        internal static bool validateItemDiscount(string code)
        {
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT InventoryID FROM Discounts WHERE DiscountCode = '" + code + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {


                                if (!reader.IsDBNull(0))
                                {

                                    for (int i = 0; i < frmShoppingCart.itemIDCart.Count; i++)
                                    {
                                        if (reader.GetInt32(0) == frmShoppingCart.itemIDCart[i])
                                        {
                                            return true;
                                        }

                                    }


                                }


                            }

                    }
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error validateItemDiscount", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            return false;
        }

        /// <summary>
        /// This function retrieves the users user id using the passed string
        /// </summary>
        /// <param name="username"></param>
        /// <returns>userID, 0 if sql fails</returns>
        internal static int GetUserID(string username)
        {
            int userID = 0;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT PersonID FROM Logon WHERE LogonName = '" + username + "';";


                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    userID = reader.GetInt32(0);
                                }
                            }




                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error GetUserID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            return userID;
        }

        /// <summary>
        /// This function updates the inventory item's quantity on completed checkout
        /// </summary>
        /// <param name="itemIDCart"></param>
        /// <param name="itemQuantityCart"></param>
        internal static void UpdateInventory(List<int> itemIDCart, List<int> itemQuantityCart)
        {
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;
                    int quantity = 0;
                    int newQuantity = 0;
                    for (int i = 0; i < itemIDCart.Count; i++)
                    {


                        sql = "SELECT Quantity FROM Inventory WHERE InventoryID = " + itemIDCart[i] + ";";



                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = sql;
                            using (var reader = command.ExecuteReader())
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        quantity = reader.GetInt32(0);
                                    }
                                }

                            newQuantity = quantity - itemQuantityCart[i];
                        }


                        sql = "UPDATE inventory SET Quantity = '" + newQuantity + "' WHERE InventoryID = " + itemIDCart[i] + ";";
                        using (var cmd = new SQLiteCommand(sql, connection))
                        {
                            cmd.ExecuteNonQuery();

                        }

                    }


                }
                //for (int x = 0; x < itemIDCart.Count; x++)
                //    {


                //    }






            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error UpdateInventory", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        /// <summary>
        /// This function retrieves the item id and quantity of an item based on the passed string, and adds 
        /// it to the passed combobox each number individually, from 1 to the quantity of the item
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cbNewQuantity"></param>
        /// <returns>item id, 0 if fails</returns>
        internal static int getAndSetInfo(string name, ComboBox cbNewQuantity)
        {
            int itemID = 0;
            int quantity = 0;
            try
            {


                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;


                    sql = "SELECT InventoryID, Quantity FROM Inventory WHERE ItemName = '" + name + "';";


                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    itemID = reader.GetInt32(0);
                                }
                                if (!reader.IsDBNull(1))
                                {
                                    quantity = reader.GetInt32(1);
                                }
                            }


                        for (int x = 0; x <= quantity; x++)
                        {
                            cbNewQuantity.Items.Add(x.ToString());
                        }

                    }
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error getAndSetInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return itemID;
        }

        /// <summary>
        /// This function gets all item names from the database and inserts them into the passed combobox
        /// </summary>
        /// <param name="cbAllNames"></param>
        internal static void getAllInventoryNames(ComboBox cbAllNames)
        {
            int userID = 0;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT ItemName FROM Inventory;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    cbAllNames.Items.Add(reader.GetString(0));
                                }
                            }

                    }
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Getting inventory names", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }



        /// <summary>
        /// This function gets all category names from the database and inserts them into the passed combobox
        /// </summary>
        /// <param name="cbCategory"></param>
        internal static void loadCategories(ComboBox cbCategory)
        {
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT CategoryName FROM Categories;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    cbCategory.Items.Add(reader.GetString(0));
                                }
                            }

                    }
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Getting category names", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// This function adds an item to the inventory table of the database with the passed information
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="categoryID"></param>
        /// <param name="price"></param>
        /// <param name="cost"></param>
        /// <param name="quantity"></param>
        /// <param name="restock"></param>
        /// <param name="fileBytes"></param>
        internal static void addItemToInventory(string name, string description, int? categoryID, string price,
            string cost, string quantity, string restock, byte[] fileBytes)
        {
            try
            {

                int orderID = 0;



                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;


                    sql = "INSERT INTO Inventory (ItemName, ItemDescription, CategoryID, RetailPrice, Cost, Quantity, RestockThreshold, ItemImage, Discounted)" +
                          " VALUES (@name, @description, @category, @price, @cost, @quantity, @restock, convert(varbinary,@image), @discontinued)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.Parameters.AddWithValue("@category", categoryID);

                        cmd.Parameters.AddWithValue("@price", price);

                        cmd.Parameters.AddWithValue("@cost", cost);

                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        cmd.Parameters.AddWithValue("@restock", restock);

                        //check this
                        var binary = cmd.Parameters.Add("@image", DbType.Binary, -1);
                        binary.Value = fileBytes;

                        cmd.Parameters.AddWithValue("@discontinued", false);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error addItemToInventory", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        /// <summary>
        /// This function retrieves all the category IDs based on the bassed string
        /// </summary>
        /// <param name="selectedItem"></param>
        /// <returns></returns>
        internal static int? getCategoryID(object selectedItem)
        {
            int? id = null;
            if (selectedItem == null)
            {
                return id;
            }
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT CategoryID FROM Categories WHERE CategoryName = '" + selectedItem.ToString() + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    id = reader.GetInt32(0);
                                }
                            }

                    }
                }


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "getCategoryID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






            return id;
        }

        /// <summary>
        /// This function marks an item as discontined in the database  based on the passed string 
        /// </summary>
        /// <param name="item"></param>
        internal static void discontinueItem(string item)
        {



            try
            {



                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "UPDATE Inventory SET Discontinued = 'true' WHERE ItemName = '" + item + "';";
                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        cmd.ExecuteNonQuery();

                    }

                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Editing Discontinued", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        /// <summary>
        /// This function
        /// </summary>
        /// <param name="tbxName"></param>
        /// <param name="rtbDescription"></param>
        /// <param name="cbCategory"></param>
        /// <param name="tbxPrice"></param>
        /// <param name="tbxCost"></param>
        /// <param name="tbxQuantity"></param>
        /// <param name="tbxRestock"></param>
        /// <param name="currentImage"></param>
        /// <param name="itemname"></param>
        /// <param name="cbItemDeleted"></param>
        internal static void loadAllInfo(TextBox tbxName, RichTextBox rtbDescription, ComboBox cbCategory,
            TextBox tbxPrice, TextBox tbxCost, TextBox tbxQuantity, TextBox tbxRestock, byte[] currentImage, string itemname, ComboBox cbItemDeleted)
        {

            int categoryID = 0;
            try
            {


                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT * FROM Inventory WHERE ItemName = '" + itemname + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(1))
                                {
                                    tbxName.Text = reader.GetString(1);
                                }
                                if (!reader.IsDBNull(2))
                                {
                                    rtbDescription.Text = reader.GetString(2);
                                }
                                if (!reader.IsDBNull(3))
                                {
                                    categoryID = reader.GetInt32(3);
                                }
                                if (!reader.IsDBNull(4))
                                {
                                    tbxPrice.Text = reader.GetDecimal(4).ToString();
                                }
                                if (!reader.IsDBNull(5))
                                {
                                    tbxCost.Text = reader.GetDecimal(5).ToString();
                                }
                                if (!reader.IsDBNull(6))
                                {
                                    tbxQuantity.Text = reader.GetInt32(6).ToString();
                                }
                                if (!reader.IsDBNull(7))
                                {
                                    tbxRestock.Text = reader.GetInt32(7).ToString();
                                }
                                if (!reader.IsDBNull(9))
                                {
                                    int TorF = reader.GetInt32(9);
                                    string TrueOrFalse = "";


                                    if (TorF == 0)
                                    {
                                        TrueOrFalse = "False";
                                    }
                                    if (TorF == 1)
                                    {
                                        TrueOrFalse = "True";
                                    }





                                    //string test = cbItemDeleted.Items[1].text;
                                    
                                        for (int i = 0; i < cbItemDeleted.Items.Count; i++)
                                    {
                                        cbItemDeleted.SelectedIndex = i;
                                        string selectedItem = cbItemDeleted.Text;

                                   if (TrueOrFalse == cbItemDeleted.Text)
                                    {
                                    cbItemDeleted.SelectedIndex = i;

                                    }
                                    }


                                }
                            }
                    }

                    sql = "SELECT CategoryName FROM Categories WHERE CategoryID = " + categoryID + ";";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    cbCategory.SelectedItem = reader.GetString(0);
                                }
                            }


                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "loadAllInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// This function allows the user to edit the image of an item in the inventory
        /// </summary>
        /// <param name="itemname"></param>
        /// <returns></returns>
        internal static byte[] GetImageEdit(string itemname)
        {
            byte[] currentImage = null;

            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;
                    sql = "SELECT ItemImage, Discontinued FROM Inventory WHERE ItemName = '" + itemname + "';";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        if (!(cmd.ExecuteScalar() is System.DBNull))
                            currentImage = (byte[])cmd.ExecuteScalar();

                    }


                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "GetImageEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            return currentImage;
        }


        /// <summary>
        /// This function uses a set of passed variables to update inventory item information in the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="categoryID"></param>
        /// <param name="price"></param>
        /// <param name="cost"></param>
        /// <param name="quantity"></param>
        /// <param name="restock"></param>
        /// <param name="discontinued"></param>
        /// <param name="currentImage"></param>
        internal static void EditInventoryItem(string name, string description, int? categoryID, string price,
            string cost, string quantity, string restock, string discontinued, byte[] currentImage)
        {
            try
            {

                bool bitDiscount = false;

                if (discontinued == "False")
                {
                    bitDiscount = false;
                }

                if (discontinued == "True")
                {
                    bitDiscount = true;
                }



                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "UPDATE Inventory " +
                          "SET ItemName = @name, ItemDescription = @description, CategoryID = @category, " +
                          "RetailPrice = @price, Cost = @cost, Quantity = @quantity, RestockThreshold = @restock, ItemImage = @image, Discontinued = @discontinued " +
                          "WHERE ItemName = '" + name + "';";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {


                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.Parameters.AddWithValue("@category", categoryID);

                        cmd.Parameters.AddWithValue("@price", double.Parse(price));

                        cmd.Parameters.AddWithValue("@cost", double.Parse(cost));

                        cmd.Parameters.AddWithValue("@quantity", Int32.Parse(quantity));

                        cmd.Parameters.AddWithValue("@restock", Int32.Parse(restock));

                        var binary = cmd.Parameters.Add("@image", DbType.Binary, -1);
                        binary.Value = currentImage;

                        cmd.Parameters.AddWithValue("@discontinued", bitDiscount);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error EditInventoryItem", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        /// <summary>
        /// This function fills a combobox with discount code names
        /// </summary>
        /// <param name="cbAllNames"></param>
        internal static void GetPromo(ComboBox cbAllNames)
        {



            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT DiscountCode FROM Discounts;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    cbAllNames.Items.Add(reader.GetString(0));
                                }
                            }
                    }
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "GetPromo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        /// <summary>
        /// This function disables a promocode in the database using the passed string
        /// </summary>
        /// <param name="promoName"></param>
        internal static void PromoDisable(string promoName)
        {
            try
            {

                DateTime today = DateTime.Today.AddYears(-1);
                DateTime todayNoTime = Convert.ToDateTime(today.ToString("yyyy-MM-dd"));



                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "UPDATE Discounts " +
                          "SET ExpirationDate = @date WHERE DiscountCode = '" + promoName + "';";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {


                        cmd.Parameters.AddWithValue("@date", todayNoTime);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Promo discontinued error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }


        /// <summary>
        /// This function lets the employee know there is a need to restock one or more items
        /// </summary>
        internal static void RestockAlert()
        {
            string restock = null;

            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT ItemName, Quantity, RestockThreshold FROM Inventory;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    if (reader.GetInt32(2) > reader.GetInt32(1))
                                    {
                                        restock += reader.GetString(0) + "\n";
                                    }
                                }
                            }

                    }
                }


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "RestockAlert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmInventoryEditMenu.restock = restock;
        }



        /// <summary>
        /// This function takes the passed information and retrieves a few more pieces of information to insert
        /// a new promo code into the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="level"></param>
        /// <param name="inventoryName"></param>
        /// <param name="type"></param>
        /// <param name="percent"></param>
        /// <param name="dollar"></param>
        /// <param name="dtpStartDate"></param>
        /// <param name="dtpEndDate"></param>
        internal static void AddPromo(string name, string description, string level, string inventoryName,
            string type, string percent, string dollar, DateTimePicker dtpStartDate, DateTimePicker dtpEndDate)
        {

            decimal? truePercent = null;
            decimal? trueDollar = null;
            int? ID = null;
            string dateStart = null;

            if (!(string.IsNullOrEmpty(dtpStartDate.Text)))
            {
                DateTime start = dtpStartDate.Value;
            }




            if (!string.IsNullOrEmpty(percent))
            {

                truePercent = Convert.ToDecimal(percent) / 100;


            }

            if (!string.IsNullOrEmpty(dollar))
            {

                decimal decimalDollar = Convert.ToDecimal(dollar);
                string convertToString = decimalDollar.ToString("C");
                trueDollar = Convert.ToDecimal(convertToString.Replace("$", ""));


            }


            dateStart = dtpStartDate.Value.ToString();

            if (dtpStartDate.Value == dtpStartDate.MinDate)
            {
                dateStart = null;
            }







            try
            {





                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;





                    sql = "SELECT InventoryID FROM Inventory WHERE ItemName = '" + inventoryName + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    ID = reader.GetInt32(0);
                                }
                            }


                    }





                    sql = "INSERT INTO Discounts (DiscountCode, Description, DiscountLevel, InventoryID, DiscountType," +
                        " DiscountPercentage, DiscountDollarAmount, StartDate, ExpirationDate)" +
                  " VALUES(@name, @description, @level, @ID, @type, @percent, @dollar, " +
                  "@start, @end)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {



                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.Parameters.AddWithValue("@level", level);

                        cmd.Parameters.AddWithValue("@ID",
                            ID == null ? (object)DBNull.Value : ID);

                        cmd.Parameters.AddWithValue("@type", type);

                        cmd.Parameters.AddWithValue("@percent",
                            truePercent == null ? (object)DBNull.Value : truePercent);

                        cmd.Parameters.AddWithValue("@dollar",
                            trueDollar == null ? (object)DBNull.Value : trueDollar);

                        cmd.Parameters.AddWithValue("@start",
                                string.IsNullOrEmpty(dateStart) ? (object)DBNull.Value : dateStart);

                        cmd.Parameters.AddWithValue("@end", dtpEndDate.Text);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error AddPromo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }








        }

        /// <summary>
        /// This function loads all the data for a promo code into various objects to show on the application for modification
        /// </summary>
        /// <param name="promocodeName"></param>
        /// <param name="tbxName"></param>
        /// <param name="rtbDescription"></param>
        /// <param name="cbLevel"></param>
        /// <param name="cbInventoryName"></param>
        /// <param name="cbType"></param>
        /// <param name="tbxPercent"></param>
        /// <param name="tbxDollar"></param>
        /// <param name="dtpStartDate"></param>
        /// <param name="dtpEndDate"></param>
        internal static void FillDiscountsInfo(string promocodeName, TextBox tbxName, RichTextBox rtbDescription,
            ComboBox cbLevel, ComboBox cbInventoryName, ComboBox cbType, TextBox tbxPercent,
            TextBox tbxDollar, DateTimePicker dtpStartDate, DateTimePicker dtpEndDate)
        {





            int? inventoryID = null;
            string inventoryName = null;



            try
            {
                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;
                    //  int i = 0;

                    sql = "SELECT * FROM Discounts WHERE DiscountCode = '" + promocodeName + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {


                                if (!reader.IsDBNull(1))
                                {

                                    tbxName.Text = reader.GetString(1);
                                }
                                if (!reader.IsDBNull(2))
                                {
                                    rtbDescription.Text = reader.GetString(2);
                                }
                                if (!reader.IsDBNull(3))
                                {
                                    cbLevel.SelectedItem = reader.GetInt32(3).ToString();
                                }
                                if (!reader.IsDBNull(4))
                                {

                                    inventoryID = reader.GetInt32(4);
                                }
                                if (!reader.IsDBNull(5))
                                {
                                    cbType.SelectedItem = reader.GetInt32(5).ToString();
                                }
                                if (!reader.IsDBNull(6))
                                {
                                    decimal percent = reader.GetDecimal(6) * 100;

                                    tbxPercent.Text = percent.ToString();
                                }
                                if (!reader.IsDBNull(7))
                                {
                                    tbxDollar.Text = reader.GetDecimal(7).ToString();
                                }
                                if (!reader.IsDBNull(8))
                                {
                                    dtpStartDate.Checked = true;

                                    dtpStartDate.Format = DateTimePickerFormat.Short;

                                    SqlDateTime sqlDate = reader.GetDateTime(8);

                                    DateTime date = Convert.ToDateTime(sqlDate.ToString());

                                    date = Convert.ToDateTime(date.ToString("MM/dd/yyyy"));

                                    dtpStartDate.Value = date;

                                }
                                else if (reader.IsDBNull(8))
                                {
                                    dtpStartDate.Checked = false;
                                    dtpStartDate.Format = DateTimePickerFormat.Custom;
                                }

                                if (!reader.IsDBNull(9))
                                {
                                    SqlDateTime sqlDate = reader.GetDateTime(9);

                                    DateTime date = Convert.ToDateTime(sqlDate.ToString());

                                    date = Convert.ToDateTime(date.ToString("MM/dd/yyyy"));

                                    dtpEndDate.Value = date;
                                }
                            }







                        if (!(inventoryID == null))
                        {
                            inventoryName = getOneInventoryID(inventoryID);
                        }


                        if (!string.IsNullOrEmpty(inventoryName))
                        {
                            cbInventoryName.SelectedItem = inventoryName;
                        }

                    }
                }


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error FillDiscountsInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        /// <summary>
        /// This function gets the item name of the inventory item in the database of the corresponding ID passed if t here is one
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>item  name, null if no results</returns>
        internal static string getOneInventoryID(int? ID)
        {

            string name = null;

            try
            {
                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;





                    sql = "SELECT ItemName FROM Inventory WHERE InventoryID = " + ID + ";";


                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    name = reader.GetString(0);
                                }
                            }



                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "getOneInventoryID", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }





            return name;
        }

        /// <summary>
        /// This function is used to use a group of information to update promo codes in the database
        /// </summary>
        /// <param name="promoName"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="level"></param>
        /// <param name="inventoryName"></param>
        /// <param name="type"></param>
        /// <param name="percent"></param>
        /// <param name="dollar"></param>
        /// <param name="dtpStartDate"></param>
        /// <param name="dtpEndDate"></param>
        internal static void ModifyPromo(string promoName, string name, string description, string level, string inventoryName,
            string type, string percent, string dollar, DateTimePicker dtpStartDate, DateTimePicker dtpEndDate)
        {
            decimal? truePercent = null;
            decimal? trueDollar = null;
            int? ID = null;
            string dateStart = null;
            string dateEnd = null;

            if (!(string.IsNullOrEmpty(dtpStartDate.Text)))
            {
                DateTime start = dtpStartDate.Value;
            }



            if (!string.IsNullOrEmpty(percent))
            {

                truePercent = Convert.ToDecimal(percent) / 100;


            }

            if (!string.IsNullOrEmpty(dollar))
            {

                decimal decimalDollar = Convert.ToDecimal(dollar);
                string convertToString = decimalDollar.ToString("C");
                trueDollar = Convert.ToDecimal(convertToString.Replace("$", ""));


            }

            dateStart = dtpStartDate.Value.ToString();

            if (dtpStartDate.Value == dtpStartDate.MinDate)
            {
                dateStart = null;
            }







            try
            {






                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;





                    sql = "SELECT InventoryID FROM Inventory WHERE ItemName = '" + inventoryName + "';";


                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    ID = reader.GetInt32(0);
                                }
                            }

                    }



                    //sql = "UPDATE Inventory " +
                    //     "SET ItemName = @name, ItemDescription = @description, CategoryID = @category, " +
                    //     "RetailPrice = @price, Cost = @cost, Quantity = @quantity, RestockThreshold = @restock, ItemImage = convert(varbinary,@image)" +
                    //     "WHERE ItemName = '" + name + "';";



                    sql = "UPDATE Discounts " +
                  "SET DiscountCode = @name, Description = @description, DiscountLevel = @level," +
                  "InventoryID = @ID,DiscountType = @type,DiscountPercentage = @percent,DiscountDollarAmount = @dollar, " +
                  "StartDate = @start,ExpirationDate = @end " +
                  "WHERE DiscountCode = '" + promoName + "';";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.Parameters.AddWithValue("@description", description);

                        cmd.Parameters.AddWithValue("@level", level);

                        cmd.Parameters.AddWithValue("@ID",
                            ID == null ? (object)DBNull.Value : ID);

                        cmd.Parameters.AddWithValue("@type", type);

                        cmd.Parameters.AddWithValue("@percent",
                            truePercent == null ? (object)DBNull.Value : truePercent);

                        cmd.Parameters.AddWithValue("@dollar",
                            trueDollar == null ? (object)DBNull.Value : trueDollar);

                        cmd.Parameters.AddWithValue("@start",
                                string.IsNullOrEmpty(dateStart) ? (object)DBNull.Value : dateStart);

                        cmd.Parameters.AddWithValue("@end", dtpEndDate.Text);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error ModifyPromo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }




        }





        /// <summary>
        /// This function uses the passed string builder to make a report using the passed variables
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="reportType"></param>
        /// <param name="requirement"></param>
        /// <param name="tableName"></param>
        /// <param name="condition"></param>
        internal static void reportsHTML(StringBuilder sb, string reportType, string requirement, string tableName, string condition)
        {

            sb.Clear();





            StringBuilder css = new StringBuilder();



            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-aling:center; font-weight:bold;" +
                "text-align: center;}");
            css.AppendLine("h1 {color: " + Color.Blue + ";}");
            css.AppendLine("</style>");


            sb.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            sb.AppendLine("<tr>");
            sb.AppendLine($"<head>{css}<title>" + reportType + " Report</title></head>");

            try
            {






                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;



                    sql = "SELECT " + requirement + " FROM " + tableName + " " + condition + ";";



                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                sb.AppendLine("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + reader.GetName(i) + "</th>");
                            }
                            while (reader.Read())
                            {
                                sb.Append("<tr>");

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    sb.Append("<td style = 'width:120px;border: 1px solid #ccc'>" + reader[i] + " </td>");
                                }


                                sb.Append("</tr>");
                            }
                        }
                    }
                }

                sb.AppendLine(reportType + " report\n");
                if (!string.IsNullOrEmpty(condition))
                {
                    sb.AppendLine("Condition of: " + condition);
                }
                sb.Append("</table>");




            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error reportsHTML", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }










        }

        /// <summary>
        /// This function retrieves all order IDs and first and last names in the database for those with orders and inserts them into the passed combobox
        /// </summary>
        /// <param name="cbPerson"></param>
        internal static void FillNames(ComboBox cbPerson)
        {
            List<string> names = new List<string>();
            List<int> IDs = new List<int>();
            List<string> cbNames = new List<string>();
            try
            {


                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT Orders.PersonID, Person.NameFirst, Person.NameLast FROM Person " +
                        "INNER JOIN Orders ON Orders.PersonID = Person.PersonID " +
                        "ORDER BY Orders.PersonID;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    IDs.Add(reader.GetInt32(0));
                                }
                                if (!reader.IsDBNull(1))
                                {
                                    names.Add(reader.GetString(1) + " " + reader.GetString(2));
                                }
                            }


                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error FillNames", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            var hs = new HashSet<string>();


            for (int i = 0; i < names.Count; i++)
            {
                hs.Add(names[i]);
            }

            cbNames = hs.ToList();

            for (int i = 0; i < cbNames.Count; i++)
            {
                cbPerson.Items.Add(cbNames[i]);
            }



            // cbNames.ForEach(Console.WriteLine);






        }

        /// <summary>
        /// This function retrieves all first and last names in the database and inserts them into the passed combobox
        /// </summary>
        /// <param name="cbAllNames"></param>
        internal static void GetPeopleNames(ComboBox cbAllNames)
        {
            try
            {


                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT NameFirst, NameLast FROM Person;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    cbAllNames.Items.Add(reader.GetString(0) + " " + reader.GetString(1));


                                }
                            }





                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "GetPeopleNames", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// This function is for setting a user as deleted using the passed string
        /// </summary>
        /// <param name="fullName"></param>
        internal static void DeactivatePerson(string fullName)
        {
            List<string> firstNameList = new List<string>();
            List<string> lastNameList = new List<string>();
            List<int> IDs = new List<int>();
            string firstName = null;
            string lastName = null;
            string fullNameFromList = null;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT NameFirst, NameLast, PersonID FROM Person;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    firstNameList.Add(reader.GetString(0));
                                    lastNameList.Add(reader.GetString(1));
                                    IDs.Add(reader.GetInt32(2));
                                }
                            }
                    }



                    for (int i = 0; i < firstNameList.Count; i++)
                    {
                        fullNameFromList = firstNameList[i] + " " + lastNameList[i];

                        if (fullNameFromList == fullName)
                        {
                            sql = "UPDATE Person SET PersonDeleted = 'true' WHERE PersonID = " + IDs[i];
                            using (var cmd = new SQLiteCommand(sql, connection))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            sql = "UPDATE Logon SET AccountDeleted = 'true', AccountDisabled = 'true' WHERE PersonID = " + IDs[i];

                            using (var cmd = new SQLiteCommand(sql, connection))
                            {
                                cmd.ExecuteNonQuery();



                            }
                        }

                    }


                }






            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "DeactivatePerson", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// This function retrieves all of a users information and inserts it into a variety of items to appear on the
        /// application for editing
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tbxTitle"></param>
        /// <param name="tbxFirstName"></param>
        /// <param name="tbxMiddleName"></param>
        /// <param name="tbxLastName"></param>
        /// <param name="tbxSuffix"></param>
        /// <param name="tbxAddress"></param>
        /// <param name="tbxSecondAddress"></param>
        /// <param name="tbxCity"></param>
        /// <param name="tbxZipcode"></param>
        /// <param name="cbState"></param>
        /// <param name="tbxEmail"></param>
        /// <param name="tbxPhoneNumber"></param>
        /// <param name="tbxSecondaryPhoneNumber"></param>
        /// <param name="tbxUsername"></param>
        /// <param name="tbxPassword"></param>
        /// <param name="cbFirstQuestion"></param>
        /// <param name="tbxFirstAnswer"></param>
        /// <param name="cbSecondQuestion"></param>
        /// <param name="tbxSecondAnswer"></param>
        /// <param name="cbThirdQuestion"></param>
        /// <param name="tbxThirdAnswer"></param>
        /// <param name="cbPosition"></param>
        /// <param name="cbDisable"></param>
        /// <param name="cbDelete"></param>
        internal static void getPersonInfoAll(string name, TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName,
            TextBox tbxLastName, TextBox tbxSuffix, TextBox tbxAddress, TextBox tbxSecondAddress, TextBox tbxCity,
            TextBox tbxZipcode, ComboBox cbState, TextBox tbxEmail, TextBox tbxPhoneNumber, TextBox tbxSecondaryPhoneNumber,
            TextBox tbxUsername, TextBox tbxPassword, ComboBox cbFirstQuestion, TextBox tbxFirstAnswer, ComboBox cbSecondQuestion,
            TextBox tbxSecondAnswer, ComboBox cbThirdQuestion, TextBox tbxThirdAnswer, ComboBox cbPosition, ComboBox cbDisable, ComboBox cbDelete)
        {





            int categoryID = 0;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;
                    List<string> firstNameList = new List<string>();
                    List<string> lastNameList = new List<string>();
                    string firstName = null;
                    string lastName = null;
                    string fullNameFromList = null;




                    sql = "SELECT NameFirst, NameLast, PersonID FROM Person;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    firstNameList.Add(reader.GetString(0));
                                    lastNameList.Add(reader.GetString(1));

                                }
                            }


                    }


                    for (int i = 0; i < firstNameList.Count; i++)
                    {
                        fullNameFromList = firstNameList[i] + " " + lastNameList[i];

                        if (fullNameFromList == name)
                        {
                            firstName = firstNameList[i];
                            lastName = lastNameList[i];
                        }


                    }










                    sql = "SELECT Title, NameFirst, NameMiddle, NameLast, Suffix, Address1, Address2, City, Zipcode, " +
                        "State, Email, PhonePrimary, PhoneSecondary, LogonName, Password,QuestionOne.QuestionPrompt, " +
                        "FirstChallengeAnswer ,QuestionTwo.QuestionPrompt, SecondChallengeAnswer, QuestionThree.QuestionPrompt, ThirdChallengeAnswer,PositionID," +
                        " PersonDeleted, AccountDisabled, AccountDeleted " +
                        "FROM Person " +
                        "FULL JOIN Logon ON Logon.PersonID = Person.PersonID " +
                        "INNER JOIN SecurityQuestions As QuestionOne ON Logon.FirstChallengeQuestion = QuestionOne.QuestionID " +
                        "INNER JOIN SecurityQuestions AS QuestionTwo ON Logon.SecondChallengeQuestion = QuestionTwo.QuestionID " +
                        "INNER JOIN SecurityQuestions AS QuestionThree ON Logon.ThirdChallengeQuestion  = QuestionThree.QuestionID " +
                        "WHERE NameFirst = '" + firstName + "' AND NameLast = '" + lastName + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    tbxTitle.Text = reader.GetString(0);
                                }
                                if (!reader.IsDBNull(1))
                                {
                                    tbxFirstName.Text = reader.GetString(1);
                                }
                                if (!reader.IsDBNull(2))
                                {
                                    tbxMiddleName.Text = reader.GetString(2);
                                }
                                if (!reader.IsDBNull(3))
                                {
                                    tbxLastName.Text = reader.GetString(3);
                                }
                                if (!reader.IsDBNull(4))
                                {
                                    tbxSuffix.Text = reader.GetString(4);
                                }
                                if (!reader.IsDBNull(5))
                                {
                                    tbxAddress.Text = reader.GetString(5);
                                }
                                if (!reader.IsDBNull(6))
                                {
                                    tbxSecondAddress.Text = reader.GetString(6);
                                }
                                if (!reader.IsDBNull(7))
                                {
                                    tbxCity.Text = reader.GetString(7);
                                }
                                if (!reader.IsDBNull(8))
                                {
                                    tbxZipcode.Text = reader.GetString(8);
                                }
                                if (!reader.IsDBNull(9))
                                {
                                    cbState.SelectedItem = reader.GetString(9);
                                }
                                if (!reader.IsDBNull(10))
                                {
                                    tbxEmail.Text = reader.GetString(10);
                                }
                                if (!reader.IsDBNull(11))
                                {
                                    tbxPhoneNumber.Text = reader.GetString(11);
                                }
                                if (!reader.IsDBNull(12))
                                {
                                    tbxSecondaryPhoneNumber.Text = reader.GetString(12);
                                }
                                if (!reader.IsDBNull(13))
                                {
                                    tbxUsername.Text = reader.GetString(13);
                                }
                                if (!reader.IsDBNull(14))
                                {
                                    tbxPassword.Text = reader.GetString(14);

                                }
                                if (!reader.IsDBNull(15))
                                {
                                    cbFirstQuestion.SelectedItem = reader.GetString(15);
                                }
                                if (!reader.IsDBNull(16))
                                {
                                    tbxFirstAnswer.Text = reader.GetString(16);
                                }
                                if (!reader.IsDBNull(17))
                                {
                                    cbSecondQuestion.SelectedItem = reader.GetString(17);
                                }
                                if (!reader.IsDBNull(18))
                                {
                                    tbxSecondAnswer.Text = reader.GetString(18);
                                }
                                if (!reader.IsDBNull(19))
                                {
                                    cbThirdQuestion.SelectedItem = reader.GetString(19);
                                }
                                if (!reader.IsDBNull(20))
                                {
                                    tbxThirdAnswer.Text = reader.GetString(20);
                                }
                                if (!reader.IsDBNull(21))
                                {
                                    cbPosition.SelectedIndex = reader.GetInt32(21) - 1000;
                                }
                                if (!reader.IsDBNull(22))
                                {
                                    bool deleted = reader.GetBoolean(22);
                                    cbDelete.SelectedItem = deleted.ToString();
                                }
                                if (!reader.IsDBNull(23))
                                {
                                    bool disabled = reader.GetBoolean(23);
                                    cbDisable.SelectedItem = disabled.ToString();
                                }



                            }




                    }
                }


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "getPersonInfoAll", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }








        }

        /// <summary>
        /// This function takes a group of variables and alters a users data in the database
        /// </summary>
        /// <param name="tbxTitle"></param>
        /// <param name="tbxFirstName"></param>
        /// <param name="tbxMiddleName"></param>
        /// <param name="tbxLastName"></param>
        /// <param name="tbxSuffix"></param>
        /// <param name="tbxAddress"></param>
        /// <param name="tbxSecondAddress"></param>
        /// <param name="tbxCity"></param>
        /// <param name="tbxZipcode"></param>
        /// <param name="cbState"></param>
        /// <param name="tbxEmail"></param>
        /// <param name="tbxPhoneNumber"></param>
        /// <param name="tbxSecondaryPhoneNumber"></param>
        /// <param name="tbxUsername"></param>
        /// <param name="tbxPassword"></param>
        /// <param name="cbFirstQuestion"></param>
        /// <param name="tbxFirstAnswer"></param>
        /// <param name="cbSecondQuestion"></param>
        /// <param name="tbxSecondAnswer"></param>
        /// <param name="cbThirdQuestion"></param>
        /// <param name="tbxThirdAnswer"></param>
        /// <param name="cbDelete"></param>
        /// <param name="cbDisable"></param>
        /// <param name="cbPosition"></param>
        internal static void UserEdit(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName,
            TextBox tbxSuffix, TextBox tbxAddress, TextBox tbxSecondAddress, TextBox tbxCity, TextBox tbxZipcode, ComboBox cbState,
            TextBox tbxEmail, TextBox tbxPhoneNumber, TextBox tbxSecondaryPhoneNumber, TextBox tbxUsername, TextBox tbxPassword,
            ComboBox cbFirstQuestion, TextBox tbxFirstAnswer, ComboBox cbSecondQuestion, TextBox tbxSecondAnswer, ComboBox cbThirdQuestion,
            TextBox tbxThirdAnswer, ComboBox cbDelete, ComboBox cbDisable, ComboBox cbPosition)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql;
                int pos = 1000;
                int personID = 0;

                if (cbPosition.SelectedItem.ToString() == "Customer")
                {
                    pos = 1000;
                }
                if (cbPosition.SelectedItem.ToString() == "Employee")
                {
                    pos = 1001;
                }
                if (cbPosition.SelectedItem.ToString() == "Manager")
                {
                    pos = 1002;
                }




                try
                {



                    sql = "SELECT PersonID FROM Person WHERE NameFirst = '" + tbxFirstName.Text + "' and NameLast = '" + tbxLastName.Text + "'";
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                personID = (reader.GetInt32(0));
                            }


                    }







                    sql = "UPDATE person " +
                        "SET Title = @title,NameFirst = @first,NameMiddle = @middle,NameLast = @last,Suffix = @suffix,Address1 = @address1" +
                        ",Address2 = @address2,City = @city,Zipcode = @zip," +
                        "State = @state,Email = @email,PhonePrimary = @phoneprimary,PhoneSecondary = @phonesecondary,Image = @image,PositionID = @pos,PersonDeleted = @persondel " +
                        "WHERE PersonID = " + personID;

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("@title",
                        string.IsNullOrEmpty(tbxTitle.Text) ? (object)DBNull.Value : tbxTitle.Text);

                        cmd.Parameters.AddWithValue("@first", tbxFirstName.Text);

                        cmd.Parameters.AddWithValue("@middle",
                       string.IsNullOrEmpty(tbxMiddleName.Text) ? (object)DBNull.Value : tbxMiddleName.Text);

                        cmd.Parameters.AddWithValue("@last", tbxLastName.Text);

                        cmd.Parameters.AddWithValue("@suffix",
                       string.IsNullOrEmpty(tbxSuffix.Text) ? (object)DBNull.Value : tbxSuffix.Text);

                        cmd.Parameters.AddWithValue("@address1", tbxAddress.Text);

                        cmd.Parameters.AddWithValue("@address2",
                       string.IsNullOrEmpty(tbxSecondAddress.Text) ? (object)DBNull.Value : tbxSecondAddress.Text);

                        cmd.Parameters.AddWithValue("@city", tbxCity.Text);

                        cmd.Parameters.AddWithValue("@zip", tbxZipcode.Text);

                        cmd.Parameters.AddWithValue("@state", cbState.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue("@email",
                            string.IsNullOrEmpty(tbxEmail.Text) ? (object)DBNull.Value : tbxEmail.Text);

                        cmd.Parameters.AddWithValue("@phoneprimary",
                            string.IsNullOrEmpty(tbxPhoneNumber.Text) ? (object)DBNull.Value : tbxPhoneNumber.Text);

                        cmd.Parameters.AddWithValue("@phonesecondary",
                       string.IsNullOrEmpty(tbxSecondaryPhoneNumber.Text) ? (object)DBNull.Value : tbxSecondaryPhoneNumber.Text);

                        cmd.Parameters.AddWithValue("@image", SqlBinary.Null);

                        cmd.Parameters.AddWithValue("@pos", pos);

                        cmd.Parameters.AddWithValue("@persondel", cbDelete.Text);




                        cmd.ExecuteNonQuery();
                    }

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message, "SQLite Error UserEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                int firstQuestionID = 0;
                int secondQuestionID = 0;
                int thirdQuestionID = 0;
                int count = 0;
                sql = "SELECT QuestionID FROM SecurityQuestions WHERE QuestionPrompt = '" + cbFirstQuestion.SelectedItem.ToString() + "' or " +
                    "QuestionPrompt = '" + cbSecondQuestion.SelectedItem.ToString() + "' or QuestionPrompt = '" + cbThirdQuestion.SelectedItem.ToString() + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (count == 0)
                            {
                                firstQuestionID = (reader.GetInt32(0));
                            }
                            if (count == 1)
                            {
                                secondQuestionID = (reader.GetInt32(0));
                            }
                            if (count == 2)
                            {
                                thirdQuestionID = (reader.GetInt32(0));
                            }

                            count++;
                        }


                }



                int posID = 0;
                sql = "SELECT PositionID FROM Person WHERE NameFirst = '" + tbxFirstName.Text + "' and NameLast = '" + tbxLastName.Text + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            posID = (reader.GetInt32(0));
                        }
                }
                string posTitle = "";
                sql = "SELECT PositionTitle FROM Position WHERE PositionID = " + posID;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            posTitle = (reader.GetString(0));
                        }
                }
                try
                {

                    sql = "UPDATE Logon " +
                        "SET PersonID = @person,LogonName = @logonname,Password = @password," +
                        "FirstChallengeQuestion = @firstquestion,FirstChallengeAnswer = @firstanswer," +
                        "SecondChallengeQuestion = @secondquestion,SecondChallengeAnswer = @secondanswer," +
                        "ThirdChallengeQuestion = @thirdquestion,ThirdChallengeAnswer = @thirdanswer,PositionTitle = @postitle," +
                        "AccountDisabled = @accdisabled,AccountDeleted = @accdeleted " +
                        "WHERE PersonID = " + personID;

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("@person", personID);

                        cmd.Parameters.AddWithValue("@logonname", tbxUsername.Text);

                        cmd.Parameters.AddWithValue("@password", tbxPassword.Text);

                        cmd.Parameters.AddWithValue("@firstquestion", firstQuestionID);

                        cmd.Parameters.AddWithValue("@firstanswer", tbxFirstAnswer.Text);

                        cmd.Parameters.AddWithValue("@secondquestion", secondQuestionID);

                        cmd.Parameters.AddWithValue("@secondanswer", tbxSecondAnswer.Text);

                        cmd.Parameters.AddWithValue("@thirdquestion", thirdQuestionID);

                        cmd.Parameters.AddWithValue("@thirdanswer", tbxThirdAnswer.Text);

                        cmd.Parameters.AddWithValue("@postitle", posTitle);

                        cmd.Parameters.AddWithValue("@accdisabled", cbDisable.Text);

                        cmd.Parameters.AddWithValue("@accdeleted", cbDelete.Text);

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message, "SQLite Error UserEdit 2nd part", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                MessageBox.Show("Account Changed!");
            }
        }

        /// <summary>
        /// This function gets the person ID from the database using the passed strings
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>Person ID, -1 if none found</returns>
        internal static int GetUserIDFromFirstName(string firstName, string lastName)
        {

            int ID = -1;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT PersonID FROM Person WHERE NameFirst = '" + firstName + "' AND NameLast = '" + lastName + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    ID = reader.GetInt32(0);
                                }
                            }




                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error GetUserIDFromFirstName", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return ID;
        }

      

        /// <summary>
        /// This function retrieves first and last names in the database according to the method passed and the text entered in the textbox passed
        /// </summary>
        /// <param name="method"></param>
        /// <param name="tbxUserLookup"></param>
        /// <param name="cbAllNames"></param>
        internal static void getValueNamesTyping(string method, TextBox tbxUserLookup, ComboBox cbAllNames)
        {
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    if (method == "Name")
                    {
                        method = "NameFirst";
                    }



                    sql = "SELECT NameFirst, NameLast FROM Person WHERE " + method + " LIKE '%" + tbxUserLookup.Text + "%';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {

                                for (int i = 0; i < reader.FieldCount; i += 2)
                                {
                                    if (!reader.IsDBNull(i))

                                    {
                                        cbAllNames.Items.Add(reader.GetValue(i).ToString() + " " + reader.GetValue(i + 1).ToString());
                                    }
                                }
                            }



                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error Value Names", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        /// <summary>
        /// This function loads all discounts in the database, for the manager to select from for testing
        /// </summary>
        /// <param name="rtbDiscounts"></param>
        internal static void LoadDiscounts(RichTextBox rtbDiscounts)
        {
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT DiscountCode FROM Discounts;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    rtbDiscounts.Text += reader.GetValue(0).ToString() + "\n";
                                }
                            }





                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error LoadDiscounts", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// This function retrieves the full name of the manager, corresponding to the passed manager ID
        /// </summary>
        /// <param name="managerID"></param>
        /// <returns>manager name, or empty string</returns>
        internal static string GetManagerFullName(int managerID)
        {

            string name = "";
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT CONCAT(Person.NameFirst, ' ', Person.NameLast) FROM Person WHERE PersonID = " + managerID + ";";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    name = reader.GetString(0);
                                }
                            }





                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error GetManagerFullName", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





            return name;


        }

        /// <summary>
        /// This function retrieves the users logon name based on their first and last name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>users logon name, or empty string if not found</returns>
        internal static string getCustomerUsername(string firstName, string lastName)
        {
            string username = "";
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT LogonName FROM Person " +
                        "JOIN Logon ON Person.PersonID = Logon.PersonID " +
                        "WHERE NameFirst = '" + firstName + "' AND NameLast = '" + lastName + "';";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    username = reader.GetString(0);
                                }
                            }





                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error getCustomerUsername", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            return username;
        }

        /// <summary>
        /// This function retrieves a group of data from the database for the manager and inserts it into a datagridview 
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="dgvData"></param>
        internal static void DGVDataInsertCustomerInfo(int orderID, DataGridView dgvData)
        {
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT OrderID, CONCAT(Orders.PersonID, ' - ' ,NameFirst, ' ', NameLast) AS 'Full Name', " +
                        "(SELECT CONCAT(PersonID,' - ', NameFirst, ' ', NameLast) " +
                        "FROM Person " +
                        "WHERE PersonID = " + frmManager.managerID + ") AS Employee,OrderDate " +
                        "FROM Orders " +
                        "JOIN Person ON Orders.PersonID = Person.PersonID " +
                        "WHERE OrderID = " + orderID +
                        " GROUP BY OrderID, Orders.PersonID,OrderDate,NameFirst, NameLast";


                    var cmd = new SQLiteDataAdapter(sql, connection);

                    DataTable dt = new DataTable();

                    cmd.Fill(dt);

                    dgvData.DataSource = dt;



                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        /// <summary>
        /// This function retrieves all orders within a specific time frame, depending on a passed variable
        /// between daily, weekly, and monthly
        /// </summary>
        /// <param name="dtpDatecondition"></param>
        /// <param name="range"></param>
        /// <param name="person"></param>
        /// <returns>list of orders</returns>
        internal static List<int> GetTotalTables(DateTimePicker dtpDatecondition, string range, string person)
        {
            List<int> totalTabledToPrint = new List<int>();
            int ID = 0;
            double totalRange = -1;
            DateTime date = dtpDatecondition.Value;
            DateTime? maxDates = date;

            if (!string.IsNullOrEmpty(person))
            {
                string[] split = person.Split(' ');

                ID = GetUserIDFromFirstName(split[0], split[1]);
            }




            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql = "";


                    switch (range)
                    {
                        case "Daily":
                            sql = "SELECT OrderID FROM Orders WHERE OrderDate = '" + date + "'";
                            break;
                        case "Weekly":
                            sql = "SELECT OrderID FROM Orders WHERE OrderDate BETWEEN '" + date.AddDays(-7) + "' AND '" + date + "'";
                            break;
                        case "Monthly":
                            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
                            DateTime startOfNextMonth = startOfMonth.AddMonths(1);
                            DateTime endOfMonth = startOfNextMonth.AddDays(-1);
                            sql = "SELECT OrderID FROM Orders WHERE OrderDate BETWEEN '" + startOfMonth + "' AND '" + endOfMonth + "'";
                            break;
                        default:
                            sql = "SELECT OrderID FROM Orders";
                            break;
                    }






                    if (!string.IsNullOrEmpty(person))
                    {
                        sql = sql + " AND PersonID = " + ID + "";
                    }




                    sql = sql + ";";
                    // Console.WriteLine(sql);
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                //Console.WriteLine(reader[i].ToString());
                                totalTabledToPrint.Add(Convert.ToInt32(reader[i]));
                            }
                        }

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error GetTotalTables", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return totalTabledToPrint;
        }


        /// <summary>
        /// This funcction gets all orders of a specific person
        /// </summary>
        /// <param name="person"></param>
        /// <returns>list of orders</returns>
        internal static List<int> GetTotalCustomerOrders(string person)
        {
            List<int> totalTabledToPrint = new List<int>();
            int ID = 0;


            string[] split = person.Split(' ');

            ID = GetUserIDFromFirstName(split[0], split[1]);


            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql = "SELECT OrderID FROM Orders WHERE PersonID = " + ID + ";";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {

                                    totalTabledToPrint.Add(Convert.ToInt32(reader[i]));
                                }
                            }




                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error GetTotalCustomerOrders", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return totalTabledToPrint;
        }

        /// <summary>
        /// This function gets all order ids from the orders tables that were discounted
        /// </summary>
        /// <param name="orderIDList"></param>
        /// <returns>list of discounted orders</returns>
        internal static List<int> GetDiscountedOrders(List<int> orderIDList)
        {
            List<int> totalDiscountedOrders = new List<int>();
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;

                    sql = "SELECT OrderID FROM Orders WHERE DiscountID is not null;";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    for (int i = 0; i < orderIDList.Count; i++)
                                    {
                                        if (reader.GetInt32(0) == orderIDList[i])
                                        {
                                            totalDiscountedOrders.Add(reader.GetInt32(0));

                                        }

                                    }
                                }
                            }





                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error GetDiscountedOrders", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return totalDiscountedOrders;
        }

        /// <summary>
        /// This function first retrieves various pieces of information for the datagridview before compiling it
        /// to be inserted into a data table, gathering a collection of information from the database
        /// as well as calculations for the subtotal, tax, and final total
        /// before assigning it to the passed datagridview to be shown on the application
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="dgvData"></param>
        internal static void DGVDataInsertOrderInfo(int orderID, DataGridView dgvData)
        {
            decimal total = 0;
            decimal tax = 0m;
            decimal finalTotal = 0m;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;



                    sql = "SELECT CAST(SUM(OrderDetails.Quantity * RetailPrice) AS decimal(9,2)) " +
                        "FROM Inventory " +
                        "JOIN OrderDetails ON Inventory.InventoryID = OrderDetails.InventoryID " +
                        "WHERE OrderID = " + orderID;

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    total += reader.GetDecimal(0);
                                }
                            }

                    }



                    tax = (total * 0.0825m);
                    tax = Math.Round(tax, 2);
                    finalTotal = Math.Round((total + tax), 2);

                    sql = "SELECT CONCAT(Inventory.InventoryID, ' - ', ItemName) AS Item, CONCAT('$',RetailPrice) AS 'Item Price', " +
                        "CAST(OrderDetails.Quantity AS varchar) AS Quantity, CONCAT('$', SUM(OrderDetails.Quantity * RetailPrice)) AS TotalPrice " +
                        "FROM Inventory " +
                        "JOIN OrderDetails ON Inventory.InventoryID = OrderDetails.InventoryID " +
                        "WHERE OrderID = " + orderID + " GROUP BY OrderID,Inventory.InventoryID, ItemName, RetailPrice, OrderDetails.Quantity";

                    var cmd = new SQLiteDataAdapter(sql, connection);

                    DataTable dt = new DataTable();

                    cmd.Fill(dt);

                    DataRow subtotal = dt.NewRow();
                    subtotal["Quantity"] = "Subtotal: ";
                    subtotal["TotalPrice"] = "$" + total;
                    dt.Rows.Add(subtotal);

                    DataRow finalTax = dt.NewRow();
                    finalTax["Quantity"] = "Tax: ";
                    finalTax["TotalPrice"] = "$" + tax;
                    dt.Rows.Add(finalTax);

                    DataRow totalData = dt.NewRow();
                    totalData["Quantity"] = "Total: ";
                    totalData["TotalPrice"] = "$" + finalTotal;
                    dt.Rows.Add(totalData);

                    dgvData.DataSource = dt;











                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /// <summary>
        /// This function first retrieves various pieces of information for the datagridview before compiling it
        /// to be inserted into a data table, gathering a collection of information from the database
        /// as well as calculations for the subtotal, discounts, tax, and final total
        /// before assigning it to the passed datagridview to be shown on the application
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="dgvData"></param>
        internal static void DGVDiscountedDataInsertOrderInfo(int orderID, DataGridView dgvData)
        {
            decimal total = 0m;
            int discountType = 0;
            decimal discountAmountDollar = 0m;
            decimal discountAmountPercent = 0m;
            int discountID = 0;
            string discountName = "";
            decimal finalDiscount = 0m;
            decimal tax = 0m;
            decimal finalTotal = 0m;
            try
            {

                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();
                    string sql;




                    sql = "SELECT DiscountID " +
                        "FROM Orders " +
                        "WHERE OrderID = " + orderID;

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    discountID = reader.GetInt32(0);
                                }
                            }
                    }

                    sql = "SELECT DiscountType, DiscountDollarAmount, DiscountPercentage, DiscountCode " +
                        "FROM Discounts " +
                        "WHERE DiscountID = " + discountID;

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    discountType = reader.GetInt32(0);
                                }
                                if (!reader.IsDBNull(1))
                                {
                                    discountAmountDollar = reader.GetDecimal(1);
                                }
                                if (!reader.IsDBNull(2))
                                {
                                    discountAmountPercent = reader.GetDecimal(2);
                                }
                                if (!reader.IsDBNull(3))
                                {
                                    discountName = reader.GetString(3);
                                }
                            }
                    }









                    sql = "SELECT CAST(SUM(OrderDetails.Quantity * RetailPrice) AS decimal(9,2)) " +
                        "FROM Inventory " +
                        "JOIN OrderDetails ON Inventory.InventoryID = OrderDetails.InventoryID " +
                        "WHERE OrderID = " + orderID;

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = sql;
                        using (var reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    total += reader.GetDecimal(0);
                                }
                            }

                    }

                    if (discountType == 0)
                    {
                        finalDiscount = total * discountAmountPercent;
                    }
                    else if (discountType == 1)
                    {
                        finalDiscount = discountAmountDollar;
                    }
                    tax = (total * 0.0825m);
                    finalDiscount = Math.Round(finalDiscount, 2);
                    tax = Math.Round(tax, 2);
                    finalTotal = Math.Round(((total - finalDiscount) + tax), 2);


                    sql = "SELECT CONCAT(Inventory.InventoryID, ' - ', ItemName) AS Item, CONCAT('$',RetailPrice) AS 'Item Price', " +
                        "CAST(OrderDetails.Quantity AS varchar) AS Quantity, CONCAT('$', SUM(OrderDetails.Quantity * RetailPrice)) AS TotalPrice " +
                        "FROM Inventory " +
                        "JOIN OrderDetails ON Inventory.InventoryID = OrderDetails.InventoryID " +
                        "WHERE OrderID = " + orderID + " GROUP BY OrderID,Inventory.InventoryID, ItemName, RetailPrice, OrderDetails.Quantity";



                    var cmd = new SQLiteDataAdapter(sql, connection);

                    DataTable dt = new DataTable();

                    cmd.Fill(dt);

                    DataRow subtotal = dt.NewRow();
                    subtotal["Quantity"] = "Subtotal: ";
                    subtotal["TotalPrice"] = "$" + total;
                    dt.Rows.Add(subtotal);

                    DataRow discount = dt.NewRow();
                    discount["Item Price"] = "Discount: ";
                    discount["Quantity"] = discountName;
                    discount["TotalPrice"] = "-(" + finalDiscount + ")";
                    dt.Rows.Add(discount);

                    DataRow finalTax = dt.NewRow();
                    finalTax["Quantity"] = "Tax: ";
                    finalTax["TotalPrice"] = "$" + tax;
                    dt.Rows.Add(finalTax);

                    DataRow totalData = dt.NewRow();
                    totalData["Quantity"] = "Total: ";
                    totalData["TotalPrice"] = "$" + finalTotal;
                    dt.Rows.Add(totalData);


                    dgvData.DataSource = dt;











                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error DataGridView Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /// <summary>
        /// This function simply checks the passed username and logon name against all logon names in the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="logonName"></param>
        /// <returns>false if any matches occur, else true</returns>
        internal static bool UsernameUniqueEditing(string username, string logonName)
        {


            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT LogonName FROM Logon";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            if (username.ToUpper() == reader.GetString(0).ToUpper() && logonName.ToUpper() != reader.GetString(0).ToUpper())
                            {

                                return false;
                            }
                        }


                    return true;

                }
            }
        }

        /// <summary>
        /// This function checks the date the user was added to the database.
        /// </summary>
        /// <param name="logonID"></param>
        /// <param name="logonName"></param>
        /// <returns>true If they are older than the rewards table creation, else false </returns>
        internal static bool CheckUserDate(int logonID, string logonName)
        {
            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT DateAdded FROM Logon WHERE LogonID = " + logonID + " AND LogonName = '" + logonName + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            //reward system created on feb 16 2026
                            //accounts older than the reward system will get 500 points upon joining
                            DateTime currentDate = DateTime.Parse("2/16/2026 00:00:00.000");
                            string date = currentDate.ToString("MM/dd/yy");
                            DateTime rewardCreation = DateTime.ParseExact(date, "MM/dd/yy", null);
                            DateTime DateJoined = DateTime.Parse(reader.GetString(0));
                            if (DateJoined < rewardCreation)
                            {
                                return true;
                            }
                        }


                    return false;

                }
            }
        }

        /// <summary>
        /// This function adds a user to the rewards table using passed information
        /// </summary>
        /// <param name="logonID"></param>
        /// <param name="logonName"></param>
        /// <param name="points"></param>
        internal static void AddToRewards(int logonID, string logonName, int points)
        {
            try
            {
                using (var connection = new SQLiteConnection(SQLiteConn))
                {
                    connection.Open();

                    var sql = "INSERT INTO Rewards (LogonID, LogonName, Points)" +
                     " VALUES (@logonID,@logonname,@points)";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {


                        cmd.Parameters.AddWithValue("@logonID", logonID);

                        cmd.Parameters.AddWithValue("@logonname", logonName);

                        cmd.Parameters.AddWithValue("@points", points);

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "SQLite Error insert into rewards", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }


       
        
        /// <summary>
        /// This function retrieves the logon id of the current user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>logon id of the current user, or -1 if not found</returns>
        internal static int GetLogonID(string username, string password)
        {

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT LogonID FROM Logon WHERE LogonName = '" + username + "' AND Password = '" + password + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                }
            }
            return -1;
        }

        /// <summary>
        /// This function checks the database for if the user logging in is in the rewards table or not
        /// </summary>
        /// <param name="logonID"></param>
        /// <param name="username"></param>
        /// <returns>true if the user is in the rewards table, else returns false</returns>
        internal static bool CheckInRewards(int logonID, string username)
        {



            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT LogonID, LogonName FROM Rewards";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var name = reader.GetString(1);

                            if (logonID == id && username == name)
                            {
                                return true;
                            }
                        }
                }
            }

            return false;
        }

        /// <summary>
        /// This function retrieves the total points a user has
        /// </summary>
        /// <param name="logonName"></param>
        /// <param name="logonID"></param>
        /// <returns>the amount of points a user has, or 0 is none</returns>
        internal static string cartRewardsInfo(string logonName, int logonID)
        {
            int points = 0;
            string pointsString = "0";

            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "SELECT Points FROM Rewards WHERE LogonID = " + logonID + " AND LogonName = '" + logonName + "'";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {

                            points = reader.GetInt32(0);

                        }
                }
                pointsString = points.ToString();
                return pointsString;
            }
        }
        /// <summary>
        /// This function both removes the points used for the order, as well as adding points gained from the order,
        /// then updates the database
        /// </summary>
        /// <param name="logonName"></param>
        /// <param name="logonID"></param>
        /// <param name="totalPointsOwned"></param>
        /// <param name="discountPoints"></param>
        /// <param name="pointsToAdd"></param>
        internal static void pointRemoveAdd(string logonName, int logonID, int totalPointsOwned, int discountPoints, int pointsToAdd)
        {

            totalPointsOwned -= discountPoints;
            totalPointsOwned += pointsToAdd;

            




            using (var connection = new SQLiteConnection(SQLiteConn))
            {
                connection.Open();
                string sql = "UPDATE Rewards SET points = '" + totalPointsOwned + "' WHERE LogonName = '" + logonName + "' and LogonID = " + logonID;
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }


            }
        }
    }
}




