using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompSoftwareMastery
{

    /// <summary>
    /// This class is made to show the  user a report of inventory orders. The user inputs a variety of requirements and it prints out a report that is saved to a file
    /// </summary>
    public partial class frmInventoryReport : Form
    {

        public static string reportType = "";
        public static string requirement = "";
        public static string tableName = "";
        public static string condition = "";
        public static bool discounted = false;
        public static StringBuilder sb = new StringBuilder();
        public static StringBuilder css = new StringBuilder();
        public static List<string> orders = new List<string>();
        public static List<int> orderIDList = new List<int>();
        public static List<int> discountedOrderIDList = new List<int>();
        public static int numOfTables = -1;
        public static int columnNames = -1;
        public static int columnCounter = 1;


        public frmInventoryReport()
        {
            InitializeComponent();
        }



        //string requirement = "*";

        //string tableName = "Orders";

        //string condition = "WHERE OrderDate = '2025-03-01'";

        //clsSQL.reportsHTML(requirement, tableName, condition);


        /// <summary>
        /// This function takes a group of requirements, in the form of a string, and checks whether or not the user
        /// has selected a specific category. If they have it adds onto the requirement string a specific phrase that is passed
        /// to another function along with a stringbuilder string and constructs a report of any inventory items
        /// that fit the requirements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryReport_Click(object sender, EventArgs e)
        {

            requirement = "InventoryID, ItemName, Cost, RetailPrice, Quantity, RestockThreshold, Discontinued";

            if (!(cbCondition.SelectedItem == null || string.IsNullOrEmpty(cbCondition.SelectedItem.ToString())))
            {
                if (cbCondition.SelectedItem.ToString() == "Needing restock")
                {
                    condition = "WHERE RestockThreshold > Quantity";
                }
                else if (cbCondition.SelectedItem.ToString() == "Avalible for sale")
                {
                    condition = "WHERE Discontinued = 'false'";
                }
                else if (cbCondition.SelectedItem.ToString() == "None")
                {
                    condition = "";
                }
            }
            else
            {

                MessageBox.Show("Please choose a condition", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsSQL.reportsHTML(sb, reportType, requirement, tableName, condition);
            ReportDTPrint();
        }

        /// <summary>
        /// This function first gets the input the user entered, the start date, the range, and the selected customer, and gets all orders made within the specific conditions by passing them
        /// to another function, and returning a list and then also gets any discounted orders and puts them into a list (specifically both lists are of order IDs). 
        /// If the list is not empty then it loops through the initial list taking each ID and retriving all information on the specific order and inserting it into a datagridview.
        /// The loop then calls another function, adding the specified customers information information to a stringbuilder string.
        /// Then it detects if the orders is a discounted order or not. If discounted it calls a special function for discounted orders to fill the datagridview
        /// with more information. If the order is not a discounted one then it calls a different function, both functions being passed the order id and the datagridview.
        /// At the end of each loop the dtexport function is called to add even more information to the stringbuilder string for later, clearing the datagridview each time
        /// to prevent duplicate information.
        /// After the loop completes it calls the print function to print out the report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderReport_Click(object sender, EventArgs e)
        {
            lbemptyCheck.Text = "";

            orderIDList = clsSQL.GetTotalTables(dtpDatecondition, cbRange.Text, cbPerson.Text);
            discountedOrderIDList = clsSQL.GetDiscountedOrders(orderIDList);

            if (!orderIDList.Any())
            {
                lbemptyCheck.Text = "No orders in the given time frame";
                return;
            }



            for (int i = 0; i < orderIDList.Count; i++)
            {




                clsSQL.DGVDataInsertCustomerInfo(orderIDList[i], dgvData);
                dtExport();

                if (discountedOrderIDList.Any())
                {
                    for (int x = 0; x < discountedOrderIDList.Count; x++)
                    {
                        if (orderIDList[i] != discountedOrderIDList[x])
                        {
                            clsSQL.DGVDataInsertOrderInfo(orderIDList[i], dgvData);
                        }
                        else if (orderIDList[i] == discountedOrderIDList[x])
                        {
                            clsSQL.DGVDiscountedDataInsertOrderInfo(orderIDList[i], dgvData);
                        }
                    }
                }
                else
                {
                    clsSQL.DGVDataInsertOrderInfo(orderIDList[i], dgvData);
                }



                dtExport();
                dgvData.DataSource = null;
                dgvData.Rows.Clear();




            }

            ReportDTPrint();



        }


        /// <summary>
        /// This function simply enables or disables a section of the application depending on  what option the user selects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDatabaseTable_SelectedValueChanged(object sender, EventArgs e)
        {
            tableName = cbDatabaseTable.SelectedItem.ToString();
            reportType = cbDatabaseTable.SelectedItem.ToString();

            if (cbDatabaseTable.SelectedItem.ToString() == "Inventory")
            {
                pInventory.Enabled = true;
                pOrder.Enabled = false;
            }
            else if (cbDatabaseTable.SelectedItem.ToString() == "Orders")
            {
                pInventory.Enabled = false;
                pOrder.Enabled = true;
            }


            if (string.IsNullOrEmpty(cbRange.Text))
            {
                btnOrderReport.Enabled = false;
            }
            if (string.IsNullOrEmpty(cbCondition.Text))
            {
                btnInventoryReport.Enabled = false;
            }

        }


        /// <summary>
        /// This function simply adds onto the global stringbuilder string.
        /// Its for the initial portion of the string to be used for later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            lbemptyCheck.Text = "";
            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-aling:center; font-weight:bold;" +
                "text-align: center;}");
            css.AppendLine("h1 {color: " + Color.Blue + ";}");
            css.AppendLine("</style>");



            cbPerson.Items.Add("");
            clsSQL.FillNames(cbPerson);

            //DELETE THIS AFTER
            //clsSQL.DGVDataInsert(dgvData);
        }


        /// <summary>
        /// This function is called multiple times to add information to a string builder string using multiple objects from the application and global variables
        /// </summary>
        private void dtExport()
        {
            sb.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            sb.AppendLine("<tr>");

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (!string.IsNullOrEmpty(column.HeaderText.ToString()))
                    sb.AppendLine("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>");
            }
            sb.AppendLine("</tr>");


            foreach (DataGridViewRow row in dgvData.Rows)
            {
                sb.AppendLine("<tr>");



                foreach (DataGridViewCell cell in row.Cells)
                {
                    // if(!string.IsNullOrEmpty(cell.Value.ToString()))


                    sb.AppendLine("<td style='background-color: #FFFDD0;width:120px;border: 1px solid #ccc'>" + cell.Value?.ToString() + "</td>");
                }
                sb.AppendLine("</tr>");
            }


            sb.AppendLine("</table>");

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //File.WriteAllText(@"C:\Users\josia\source\repos\TSTC-CPT\24su-233x-JosiahChildress\Receipt.htm", sb);


            //System.Diagnostics.Process.Start(@"C:\Users\josia\source\repos\TSTC-CPT\24su-233x-JosiahChildress\Receipt.htm");

        }


        /// <summary>
        /// This function prints out the stringbuilder string and saves it to a file in the  users application data folder
        /// </summary>
        private void ReportDTPrint()
        {
            DateTime now = DateTime.Now;
            string dateStamp = now.ToString("MM-dd-yy--hh-mm");

            try
            {

                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + "\\Report--" + dateStamp + ".html"))
                {

                    writer.WriteLine(sb);

                }

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + "\\Report--" + dateStamp + ".html");
                sb.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbRange_SelectedValueChanged(object sender, EventArgs e)
        {
            lbemptyCheck.Text = "";
            btnOrderReport.Enabled = true;
        }

        private void cbPerson_SelectedValueChanged(object sender, EventArgs e)
        {
            lbemptyCheck.Text = "";
        }

        private void cbCondition_SelectedValueChanged(object sender, EventArgs e)
        {
            btnInventoryReport.Enabled = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpReports.HelpNamespace);
            Console.WriteLine(hlpReports.HelpNamespace);
        }

        /// <summary>
        /// This function hides the current form and shoes the manager form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Hide();
        }
    }
}
