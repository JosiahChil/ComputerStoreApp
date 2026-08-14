using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class handles adding items to inventory
    /// </summary>
    public partial class frmInventoryAdd : Form
    {
        public byte[] fileBytes = null;
        public frmInventoryAdd()
        {
            InitializeComponent();
        }

        private void frmInventoryAdd_Load(object sender, EventArgs e)
        {
            clsSQL.loadCategories(cbCategory);
        }


        /// <summary>
        /// This function opens a file dialog to select an image, then saving the image to a global variable to be used later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagePath = new OpenFileDialog();

            imagePath.InitialDirectory = "c:\\";
            imagePath.Filter = "Images|*.png;*.jpeg;*.jpg";
            imagePath.FilterIndex = 2;
            imagePath.RestoreDirectory = true;

            if (imagePath.ShowDialog() == DialogResult.OK)
            {

                var filePath = imagePath.FileName;
                fileBytes = System.IO.File.ReadAllBytes(filePath);
            }


        }

        /// <summary>
        /// This fuction first passes an object value to a 2nd function to store the returned value into a variable, then if they variable is not null
        /// and a set of other objects are not empty or null, it will pass all the checked objects to another function to add items to the inventory,
        /// if the check fails, it will print out a message for the user telling them to fill out all information first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {


            int? categoryID = clsSQL.getCategoryID(cbCategory.SelectedItem);




            if (!(string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(rtbDescription.Text) || categoryID == null
                           || string.IsNullOrEmpty(tbxPrice.Text) || string.IsNullOrEmpty(tbxCost.Text) || string.IsNullOrEmpty(tbxQuantity.Text) || string.IsNullOrEmpty(tbxRestock.Text)))
            {


                clsSQL.addItemToInventory(tbxName.Text, rtbDescription.Text, categoryID, tbxPrice.Text, tbxCost.Text, tbxQuantity.Text, tbxRestock.Text, fileBytes);
                MessageBox.Show("Item Added To Inventory", "Success!",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill out all information fields", "Missing imformation",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmInventoryEditMenu inventoryEdit = new frmInventoryEditMenu();
            inventoryEdit.Show();
            this.Hide();
        }


        private void frmInventoryAdd_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpAddItem.HelpNamespace);
        }
    }
}
