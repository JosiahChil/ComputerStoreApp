using System;
using System.IO;
using System.Windows.Forms;


namespace CompSoftwareMastery
{
    /// <summary>
    /// This class is made for the function of editing inventory items in its entirity
    /// </summary>
    public partial class frmEditingInventoryItem : Form
    {
        public static string itemname = "";
        public byte[] currentImage;


        public frmEditingInventoryItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function simply loads all information for a specific item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditingInventoryItem_Load(object sender, EventArgs e)
        {
            lbName.Text = "Editing: " + itemname;

            

            clsSQL.loadCategories(cbCategory);


            clsSQL.loadAllInfo(tbxName, rtbDescription, cbCategory, tbxPrice, tbxCost, tbxQuantity, tbxRestock, currentImage, itemname, cbItemDeleted);

            currentImage = clsSQL.GetImageEdit(itemname);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmInventoryEditMenu inventoryEdit = new frmInventoryEditMenu();
            inventoryEdit.Show();
            this.Hide();
        }

        private void frmEditingInventoryItem_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        /// <summary>
        /// This function checks that all the required information is acceptable and not empty.
        /// If all checks pass properly then it will update the items information in the database 
        /// otherwise it tells the user they are missing information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int? categoryID = clsSQL.getCategoryID(cbCategory.SelectedItem);




            if (!(string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(rtbDescription.Text) || categoryID == null
                || string.IsNullOrEmpty(tbxPrice.Text) || string.IsNullOrEmpty(tbxCost.Text) || string.IsNullOrEmpty(tbxQuantity.Text) || string.IsNullOrEmpty(tbxRestock.Text)))
            {


                clsSQL.EditInventoryItem(tbxName.Text, rtbDescription.Text, categoryID, tbxPrice.Text, tbxCost.Text, tbxQuantity.Text, tbxRestock.Text, cbItemDeleted.Text, currentImage);

                MessageBox.Show("Item Successfully edited!", "Success!",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill out all information fields", "Missing imformation",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This function opens a file dialog to allow the user to input an image to insert into the database
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

                //var filePath = imagePath.FileName;
                //currentImage = System.IO.File.ReadAllBytes(filePath);
                Console.WriteLine(imagePath.FileName);


                using (var ms = new MemoryStream())
                {
                    currentImage = System.IO.File.ReadAllBytes(imagePath.FileName);

                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpEditItem.HelpNamespace);
        }
    }
}
