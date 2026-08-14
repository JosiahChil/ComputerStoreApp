using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class is made up of  functions to allow the user to manage the inventory, restocking items if needed, editing items, 
    /// adding new items, or even discontinuing them
    /// </summary>
    public partial class frmInventoryEditMenu : Form
    {
        public static string restock = null;
        public frmInventoryEditMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function lets the user know if there are any inventory items in need of restock. Afterwhich it loads all inventory item names into the application for the user to select
        /// an an item to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInventoryEdit_Load(object sender, EventArgs e)
        {
            clsSQL.RestockAlert();
            if (!string.IsNullOrEmpty(restock))
            {
                MessageBox.Show("Warning. You have items that need restocking. Press the 'Restock alert' button to see details"
                    , "Restock alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            clsSQL.getAllInventoryNames(cbAllNames);
            btnDiscontinue.Enabled = false;
            btnEditItem.Enabled = false;
        }

        private void frmInventoryEdit_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }



        /// <summary>
        /// This function hide the current form and shows the inventory add form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addItem_Click(object sender, EventArgs e)
        {
            frmInventoryAdd inventoryAdd = new frmInventoryAdd();
            inventoryAdd.Show();
            this.Hide();
        }

        /// <summary>
        /// This function hide the current form and shows the manager form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Hide();
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {

            clsSQL.discontinueItem(cbAllNames.SelectedItem.ToString());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            cbAllNames.Enabled = false;
            frmEditingInventoryItem.itemname = cbAllNames.SelectedItem.ToString();
            frmEditingInventoryItem inventoryEditItem = new frmEditingInventoryItem();
            inventoryEditItem.Show();
            this.Hide();


        }

        private void cbAllNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDiscontinue.Enabled = true;
            btnEditItem.Enabled = true;
        }

        /// <summary>
        /// This function shows the user which items need restocking, or if none do tells the user that no items need to be restocked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(restock))
            {
                MessageBox.Show("No Restocking needed at this current time"
                    , "No action needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!string.IsNullOrEmpty(restock))
            {
                MessageBox.Show("The following items need to be restocked. \n" + restock
                    , "Restock alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpInventoryEdit.HelpNamespace);
        }
    }
}
