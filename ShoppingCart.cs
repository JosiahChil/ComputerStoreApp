using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class handles all functions for the shopping cart including calculating the total, inserting data to the database, and other manager exclusive functionality
    /// </summary>
    public partial class frmShoppingCart : Form
    {

        public static List<int> itemIDCart = new List<int>();
        public static List<int> itemQuantityCart = new List<int>();
        public static int currentID = 0;
        public static int userID = 0;
        public int? employeeID = null;
        public static decimal discountAmount = -1;
        public static decimal discountPercent = -1;
        public static int discountLevel = 0;
        public static int discountType = 0;
        public static bool isDiscounted = false;
        public static string discountCode = "";
        public static bool dateValid = false;
        public static bool itemDiscount = false;
        public static int discountID = 0;
        public static int chosenID = 0;
        public static bool pos = false;
        public static int LogonID = -1;
        public static string LogonName = "";
        public static int discountPoints = 0;
        public static int pointsToAdd = 0;
        public static int totalPointsOwned = 0;
        public bool discountViaCode = false;
        public bool discountViaReward = false;
        public double rewardsDiscount = 0.0;

        public frmShoppingCart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function handles enabling and disabling different options depending on the access.
        /// Guests arent allowed to complete their shopping
        /// Managers are in point of sale mode, which have other functionality later
        /// and customers get the default permissions and options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShoppingCart_Load(object sender, EventArgs e)
        {

            if (frmLogin.guest)
            {
                btnCompletePurchase.Enabled = false;
                btnCompletePurchase.Text = "Not logged in";
            }
            else
            {
                userID = clsSQL.GetUserID(frmLogin.username);
                btnBackToMain.Enabled = false;
                btnBackToMain.Hide();
            }
            if (frmCustomer.pointOfSale == true)
            {
                userID = clsSQL.GetUserIDFromFirstName(frmPointOfSale.firstName, frmPointOfSale.lastName);
                pDiscounts.Visible = true;
                pDiscounts.Enabled = true;
                employeeID = frmManager.managerID;
                clsSQL.LoadDiscounts(rtbDiscounts);
            }
            else if (frmCustomer.pointOfSale == false)
            {
                pDiscounts.Enabled = false;
                pDiscounts.Visible = false;
            }

            if (!frmLogin.guest && !frmCustomer.pointOfSale)
            {
                pointLabel.Visible = true;
                tbxPoints.Visible = true;
                redeemLabel.Visible = true;
                tbxPoints.Enabled = true;
                pointLabel.Enabled = true;
                redeemLabel.Enabled = true;
                pointCfmBtn.Enabled = true;
                pointCfmBtn.Visible = true;
                string currentPoints = clsSQL.cartRewardsInfo(LogonName, LogonID);
                pointLabel.Text = "Current points: " + currentPoints;
                totalPointsOwned = Int32.Parse(currentPoints);
            }

            lbEditingName.Text = "";
            loadDataGridView();



        }

        /// <summary>
        /// This function first takes the information from the cart and runs a loop.
        /// If the current item matches any items that have already been inserted into the list
        /// then the item is deleted from the first list, which will be refered to as the item list,
        /// and the quantity of the item is added onto the already existing quantity for that item in the second list
        /// , refered to as the quantity list.
        /// after that loop is finished all the data is inserted into a datagridview along with the calculated subtotal,
        /// tax, and total amount due, with discounts being added later if needed
        /// </summary>
        private void loadDataGridView()
        {
            int index = 0;
            decimal subtotal = 0;
            decimal tax = 0;
            decimal finalTotal = 0;
            string[] data = new string[4];

            lbDiscountFeedback.Text = "";
            lbFeedback.Text = "";


            dtCart.Rows.Clear();
            dtCart.Refresh();
            for (int i = 0; i < itemIDCart.Count; i++)
            {
                for (int x = 0; x < itemIDCart.Count; x++)
                {
                    if (itemIDCart[i] == itemIDCart[x])
                    {
                        if (!(i == x))
                        {
                            itemQuantityCart[i] += itemQuantityCart[x];
                            itemQuantityCart.RemoveAt(x);
                            itemIDCart.RemoveAt(x);
                        }

                    }

                }
            }
            for (int i = 0; i < itemIDCart.Count; i++)
            {
                data = clsSQL.CartData(itemIDCart[index], itemQuantityCart[index]);
                dtCart.Rows.Add(data);

                index++;
                string price = data[3].Replace("$", "");
                subtotal += decimal.Parse(price);

            }
            tax = (subtotal * 0.0825m);
            finalTotal = subtotal + tax;





            dtCart.Rows.Add("", "", "Subtotal: ", subtotal.ToString("C", CultureInfo.CurrentCulture));
            dtCart.Rows.Add("", "", "Tax (8.25%): ", tax.ToString("C", CultureInfo.CurrentCulture));
            dtCart.Rows.Add("", "", "Total: ", finalTotal.ToString("C", CultureInfo.CurrentCulture));

            pointsToAdd = Decimal.ToInt32(finalTotal / 10);
            tbxCreditCard.TextChanged += textbox_TextChanged;
        }


        /// <summary>
        /// This function is an altered version of loadDataGridView. It takes all the information in the item and quantity lists and passes it through a another function to
        /// populate an array. it takes that array and uses its information to calculate the price and subtotal, calculating the tax after the subtotal is calculated. 
        /// After this, the discount subtotal is set to the subtotal, to be changed later, and then it determines what type of discount is being used.
        /// After determining which discount level is being used, it further determines if the discount is a percentage or a flat discount, calculating
        /// and applying the discount appropriately. Then the rewards discount is taken into account. After that the discounts are added together and
        /// applied to the discounted subtotal and the final total is calculated. Then all the data is inserted into a datagridview along with the calculated subtotal,
        /// tax, and total amount due, with discounts being added later if needed
        /// </summary>
        private void loadDiscountedDataGridView()
        {
            int index = 0;
            decimal subtotal = 0;
            decimal tax = 0;
            decimal finalTotal = 0;
            string[] data = new string[4];
            decimal discountFromCode = 0;
            decimal discountFromRewards = 0;
            decimal discount = 0;
            string price = "";
            dtCart.Rows.Clear();
            dtCart.Refresh();
            for (int i = 0; i < itemIDCart.Count; i++)
            {
                data = clsSQL.CartData(itemIDCart[index], itemQuantityCart[index]);
                dtCart.Rows.Add(data);
                index++;
                price = data[3].Replace("$", "");
                subtotal += decimal.Parse(price);
            }
            tax = (subtotal * 0.0825m);

            decimal discountedSubtotal = subtotal;

            index = 0;
            price = "";
            if (discountViaCode)
            {
                if (discountLevel == 0)
                {

                    if (discountPercent > 0)
                    {
                        discountFromCode = subtotal * (discountPercent);
                        //Console.WriteLine(price +"\n"+ finalDiscount);
                    }

                    if (discountAmount > 0)
                    {

                        discountFromCode = discountAmount;
                        //Console.WriteLine(price + "\n" + finalDiscount);

                    }
                }


                if (discountLevel == 1)
                {

                    if (discountPercent > 0)
                    {

                        discountFromCode = subtotal * (discountPercent);
                        //Console.WriteLine(price +"\n"+ finalDiscount);
                    }

                    if (discountAmount > 0)
                    {

                        discountFromCode = discountAmount;
                        //Console.WriteLine(price + "\n" + finalDiscount);

                    }

                }
                discountedSubtotal -= discountFromCode;
                discount += discountFromCode;
            }


            if (discountViaReward)
            {
                discountFromRewards = (decimal)rewardsDiscount;
                discountedSubtotal -= discountFromRewards;
                discount += discountFromRewards;
            }





            finalTotal = discountedSubtotal + tax;
            dtCart.Rows.Add("", "", "Subtotal: ", subtotal.ToString("C", CultureInfo.CurrentCulture));
            dtCart.Rows.Add("", "", "Discount", "-" + discount.ToString("C", CultureInfo.CurrentCulture));
            dtCart.Rows.Add("", "", "Discounted Subtotal: ", discountedSubtotal.ToString("C", CultureInfo.CurrentCulture));
            dtCart.Rows.Add("", "", "Tax (8.25%): ", tax.ToString("C", CultureInfo.CurrentCulture));
            dtCart.Rows.Add("", "", "Total: ", finalTotal.ToString("C", CultureInfo.CurrentCulture));

            pointsToAdd = Decimal.ToInt32(finalTotal / 10);


        }




        private void textbox_TextChanged(object sender, EventArgs e)
        {
            lbFeedback.Text = "";
        }

        private void frmShoppingCart_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        /// <summary>
        /// This function handles the ordering of the card.
        /// First it will set up  variables and check if the inserted credit card's date is valid. If so
        /// then it will proceed to pass a group of variables to multiple functions which will both update the database orders
        /// and the points system before calling another function to save the order report. After that it will update
        /// the inventory and clear the carts and thank the customer for shopping and sends them to the customer form,
        /// unless the order was done from a point of sale operation then it thanks the manager and sends them back to the manager form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompletePurchase_Click(object sender, EventArgs e)
        {


            try
            {
                string creditCard = tbxCreditCard.Text;
                string ccv = tbxCCV.Text;
                creditCard = creditCard.Replace("-", string.Empty);
                DateTime currentDate = DateTime.Today;
                string date = currentDate.ToString("MM/yy");
                DateTime newDate = DateTime.ParseExact(date, "MM/yy", null);
                DateTime dateCreditCard = DateTime.ParseExact(tbxDate.Text, "MM/yy", CultureInfo.InvariantCulture);
                DateTime fiveYearsAfter = newDate.AddYears(5);
                if (dateCreditCard > fiveYearsAfter || newDate > dateCreditCard)
                {
                    lbFeedback.Text = "Card is not valid";
                    return;
                }

                clsSQL.orders(userID, discountID, date, creditCard, tbxDate.Text, ccv, employeeID);
                clsSQL.pointRemoveAdd(LogonName, LogonID, totalPointsOwned, discountPoints, pointsToAdd);

                dtExport();

                clsSQL.UpdateInventory(itemIDCart, itemQuantityCart);
                itemIDCart.Clear();
                itemQuantityCart.Clear();



                string message = "Thank you for shopping ";

                if (pos == false)
                {
                    message = message + "dear customer. Rerouting you to the customer form now.";
                    MessageBox.Show(message, "Transaction Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frmCustomer customer = new frmCustomer();
                    customer.Show();
                    this.Hide();
                }
                else if (pos == true)
                {
                    message = message + "dear manager. Rerouting you to the manager form now.";
                    MessageBox.Show(message, "Transaction Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frmManager Manager = new frmManager();
                    Manager.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {

                lbFeedback.Text = "Payment Information is invalid";


            }



            //date1 > date 2 then date 1 is later than date 2


        }

        /// <summary>
        /// This function is called multiple times to add information to a string builder string using multiple objects from the application and stringbuilder strings.
        /// Once the string is fully built it saves the report to a file in the users application data folder
        /// </summary>
        private void dtExport()
        {
            StringBuilder sb = new StringBuilder();

            StringBuilder css = new StringBuilder();
            string managerName = clsSQL.GetManagerFullName(frmManager.managerID);


            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-aling:center; font-weight:bold;" +
                "text-align: center;}");
            css.AppendLine("h1 {color: " + Color.Blue + ";}");
            css.AppendLine("</style>");


            sb.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            sb.AppendLine("<tr>");
            sb.AppendLine($"<head>{css}<title>Your Shopping Cart</title></head>");

            foreach (DataGridViewColumn column in dtCart.Columns)
            {
                if (!string.IsNullOrEmpty(column.HeaderText.ToString()))
                    sb.AppendLine("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>");
            }
            sb.AppendLine("</tr>");


            foreach (DataGridViewRow row in dtCart.Rows)
            {
                sb.AppendLine("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // if(!string.IsNullOrEmpty(cell.Value.ToString()))
                    sb.AppendLine("<td style='width:120px;border: 1px solid #ccc'>" + cell.Value?.ToString() + "</td>");
                }
                sb.AppendLine("</tr>");
            }

            sb.AppendLine("Thank you for shopping with us!");
            if (frmCustomer.pointOfSale == true)
            {
                string fullName = frmPointOfSale.firstName + " " + frmPointOfSale.lastName;
                sb.AppendLine("POS Manager: " + managerName + " Shopping as: " + fullName);
            }
            sb.AppendLine("</table>");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //File.WriteAllText(@"C:\Users\josia\source\repos\TSTC-CPT\24su-233x-JosiahChildress\Receipt.htm", sb);


            //System.Diagnostics.Process.Start(@"C:\Users\josia\source\repos\TSTC-CPT\24su-233x-JosiahChildress\Receipt.htm");
            DateTime now = DateTime.Now;
            string dateStamp = now.ToString("MM-dd-yy--hh-mm");

            try
            {


                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + "\\Receipt--" + dateStamp + ".html"))
                {

                    writer.WriteLine(sb);

                }

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + "\\Receipt--" + dateStamp + ".html");
                sb.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        /// <summary>
        /// This function sets a group of variables using functions with parameters of input from the application
        /// Then after checking if the discount is valid, it sets 2 global variables to true, reassignes another global variable,
        /// sets a labal text to tell the user the discount was applied, and calls the discounted datagridview function to 
        /// rewrite the gridview to show the discount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {


            int itemID = clsSQL.checkCode(tbxDiscount.Text);

            string itemName = clsSQL.getItemName(discountID);
            bool validItem = clsSQL.validateItemDiscount(tbxDiscount.Text);

            if ((discountAmount == -1 && discountPercent == -1) || dateValid == false || (discountLevel == 1 && !validItem))
            {
                lbDiscountFeedback.Text = "Code Invalid";
            }
            else
            {

                //Console.WriteLine(discountPercent);
                //Console.WriteLine(discountAmount);
                discountViaCode = true;
                discountCode = tbxDiscount.Text;
                lbDiscountFeedback.Text = "Success";
                isDiscounted = true;
                loadDiscountedDataGridView();
            }


            
        }



        /// <summary>
        /// This function clears the id quantity and cart lists and returns the user to the login form after hiding the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackToMain_Click(object sender, EventArgs e)
        {


            dtCart.Rows.Clear();
            itemIDCart.Clear();
            itemQuantityCart.Clear();
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        /// <summary>
        /// This function clears the id quantity and cart lists and returns the user to the customer form after hiding the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {

            itemIDCart.Clear();
            itemQuantityCart.Clear();
            dtCart.Rows.Clear();

            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Hide();
        }

        /// <summary>
        /// This function shows a specific help file depending on if a manager is using the point of sale mechanic
        /// or a customer is shopping normally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            string fullPath;

            if (frmCustomer.pointOfSale == false)
            {
                Help.ShowHelp(this, hlpShopping.HelpNamespace);
            }
            else if (frmCustomer.pointOfSale == true)
            {
                Help.ShowHelp(this, hlpManager.HelpNamespace);
            }



        }

        /// <summary>
        /// This function allows the user to alter the quantity of the item being purchased without returning to the customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pEditing.Enabled = true;

            cbNewQuantity.Items.Clear();
            try
            {
                string name = dtCart.CurrentRow.Cells[0].Value.ToString();


                if (name != string.Empty)
                {
                    lbEditingName.Text = "Now editing " + name;
                    chosenID = clsSQL.getAndSetInfo(name, cbNewQuantity);
                }
                else
                {
                    lbEditingName.Text = "";
                    cbNewQuantity.Items.Clear();
                    pEditing.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error clicking Datagridview", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void btnBackToShop_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Hide();
        }


        /// <summary>
        /// This function adjusts the quantity list by running the id list through a loop and if the id of the item in the list
        /// matches the id of the chosen item, it reassigns the quantity of the corresponding index in the quantity list to the
        /// new quantity, which the user inputs. Then if there is an active discount, it will load the discounted grid view, 
        /// otherwise it will load the normal one.
        /// After that it resets the editing area back to blank for any more editing to be done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int newQuantity = Int32.Parse(cbNewQuantity.Text);

            for (int i = 0; i < itemIDCart.Count(); i++)
            {

                if (chosenID == itemIDCart[i])
                {
                    itemQuantityCart[i] = newQuantity;
                }
            }

            if (isDiscounted)
            {

                loadDiscountedDataGridView();
            }
            else
            {
                loadDataGridView();
            }
            lbEditingName.Text = "";
            cbNewQuantity.SelectedIndex = 0;
            pEditing.Enabled = false;
        }


        /// <summary>
        /// This function first asks the user if they are sure they want to delete the selected item from their cart. If yes then it will first remove the item from the quantity
        /// and id cart. Then it will check for a discount with a global vairable and if true it will load the discounted gridview, if false it loads the normal version.
        /// After that, it checks for the cart and if empty it tells the user and sends them to the customer form for more shopping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {



            DialogResult result = MessageBox.Show("Do you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < itemIDCart.Count(); i++)
                {

                    if (chosenID == itemIDCart[i])
                    {
                        itemQuantityCart.RemoveAt(i);
                        itemIDCart.RemoveAt(i);
                    }
                }



                if (isDiscounted)
                {
              

                    loadDiscountedDataGridView();
                }
                else
                {
                    loadDataGridView();
                }
                cbNewQuantity.SelectedIndex = 0;
                lbEditingName.Text = "";
                pEditing.Enabled = false;



                if (itemQuantityCart.Count == 0 || itemIDCart.Count == 0)
                {


                    DialogResult backToCart = MessageBox.Show("Your cart is empty. Please press 'OK' to proceed back to the card.", "Alert", MessageBoxButtons.OK);
                    if (backToCart == DialogResult.OK)
                    {
                        frmCustomer customer = new frmCustomer();
                        customer.Show();
                        this.Hide();
                    }



                }

            }
            else
            {
                cbNewQuantity.SelectedIndex = 0;
                return;
            }
        }

        /// <summary>
        /// This function simply changes the editing name label to the current item being edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNewQuantity_Click(object sender, EventArgs e)
        {
            string name = dtCart.CurrentRow.Cells[0].Value.ToString();

            lbEditingName.Text = "Now editing " + name;
        }


        /// <summary>
        /// ///This function first checks the points textbox for being 0 or empty. If it is then it checks for a previously used discount
        /// via a code. If false then it reloads the normal datagridview, but if the discount via code checks true then it loads the discounted
        /// version and stops the function. If the points textbox isnt empty or 0, then next it checks the entered text to be able to  be parsed
        /// into an int. If it can not then it tells the user that it is not valid. If the inserted value is parseable then, it takes the value
        /// and the logon name and id of the current user, then parses the point value into a variable and the total points the user has into another variable.
        /// If the inserted points exceeds the users total points it tells the user that they entered too much and stops the function, otherwise 
        /// it calculates the discount based on the entered points and applies it to global variables then calls the discounted datagridview load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pointCfmBtn_Click(object sender, EventArgs e)
        {
            if (tbxPoints.Text == "0" || tbxPoints.Text == string.Empty)
            {
                discountViaReward = false;
                if (discountViaCode)
                {
                    loadDiscountedDataGridView();
                }
                else
                {
                    loadDataGridView();
                }
                return;
            }
            int test;
            bool pointsInt = int.TryParse(tbxPoints.Text, out test);
            if (!pointsInt)
            {
                pointCheckerlb.Visible = true;
                pointCheckerlb.Text = "Not a valid entry for points";
                return;
            }

            string pointsText = tbxPoints.Text;
            string totalPointsText = clsSQL.cartRewardsInfo(LogonName, LogonID);
            double points = Int32.Parse(pointsText);
            double totalPoints = Int32.Parse(totalPointsText);
            discountViaReward = true;




            if (points > totalPoints)
            {
                pointCheckerlb.Visible = true;
                pointCheckerlb.Text = "Amount entered exceed your points.";
                return;

            }






            rewardsDiscount = Math.Floor(points / 10);
            discountPoints = (int)(rewardsDiscount * 10);


            loadDiscountedDataGridView();


        }




        private void tbxPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
