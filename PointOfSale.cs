using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This form is for the manager to use a customers information to preform a point of sale operation
    /// </summary>
    public partial class frmPointOfSale : Form
    {

        public static string firstName = "";
        public static string lastName = "";
        public static List<int> orderIDList = new List<int>();
        public static StringBuilder sb = new StringBuilder();
        public static StringBuilder css = new StringBuilder();
        public frmPointOfSale()
        {
            InitializeComponent();
        }

        private void frmPointOfSale_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function takes all the customers names from the combobox and splits them into first and last names, upon the user choosing a customer.
        /// The 2 names are inserted into a global variable for later use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAllNames_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] split = cbAllNames.Text.Split(' ');
            firstName = split[0];
            lastName = split[1];
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Hide();
        }


        /// <summary>
        /// This function hides the current form and opens the customer form after, but sets a pair of global variables in the customer and shopping card,
        /// forms to true to signify the manager shopping as the customer. It also passes the selected customer's username, gotten from another global variable, to another function
        /// and retrieves the customer's first and last name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmLogin.username = clsSQL.getCustomerUsername(firstName, lastName);
            frmShoppingCart.pos = true;
            frmCustomer.pointOfSale = true;
            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Hide();
        }

        private void cbLookupMethod_SelectedValueChanged(object sender, EventArgs e)
        {





        }



        private void tbxUserLookup_TextChanged(object sender, EventArgs e)
        {

            cbAllNames.Items.Clear();
            clsSQL.getValueNamesTyping(cbLookupMethod.Text, tbxUserLookup, cbAllNames);
        }

        /// <summary>
        /// This function first gets the input the user entered, the start date, the range, and the selected customer, and gets all orders made within the specific conditions by passing them
        /// to another function, and returning a list and then also gets any discounted orders and puts them into a list (specifically both lists are of order IDs). 
        /// If the list is not empty then it loops through the list taking each ID and retriving all information on the specific order and inserting it into a datagridview.
        /// The loop then calls another function, adding the specified customers information information to a stringbuilder string. 
        /// At the end of each loop the dtexport function is called to add even more information to the stringbuilder string for later, clearing the datagridview each time
        /// to prevent duplicate information.
        /// After the loop completes it calls the print function to print out the report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerOrders_Click(object sender, EventArgs e)
        {

            orderIDList = clsSQL.GetTotalCustomerOrders(cbAllNames.Text);

            for (int i = 0; i < orderIDList.Count; i++)
            {


                clsSQL.DGVDataInsertCustomerInfo(orderIDList[i], dgvData);
                dtExport();
                clsSQL.DGVDataInsertOrderInfo(orderIDList[i], dgvData);
                dtExport();


                dgvData.DataSource = null;
                dgvData.Rows.Clear();
            }


            ReportDTPrint();



        }

        /// <summary>
        /// This function is called multiple times to add information to a string builder string using multiple objects from the application and global variables
        /// </summary>
        private void dtExport()
        {


            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-aling:center; font-weight:bold;" +
                "text-align: center;}");
            css.AppendLine("h1 {color: " + Color.Blue + ";}");
            css.AppendLine("</style>");




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
            try
            {


                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + "\\Receipt.html"))
                {

                    writer.WriteLine(sb);

                }

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + "\\Receipt.html");
                sb.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {


            Help.ShowHelp(this, hlpPOS.HelpNamespace);


        }


    }
}
