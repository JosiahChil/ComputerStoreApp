using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{

    /// <summary>
    /// This class allows the manager to add promo codes to the database
    /// </summary>
    public partial class frmPromoAdd : Form
    {

        public frmPromoAdd()
        {
            InitializeComponent();
        }



        private void frmPromoAdd_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        /// <summary>
        /// This function checks the first date time picker for if its checked. If checked, it will assign the value of the date to the lowest value possible meaning the discount will not have a starting date.
        /// Next it will assign a value of true or false to a variable depending on if 2 seperate textboxes are empty or not.
        /// After that, it will check if a 3rd textbox is empty, and if not it will assign a value to a previously created but unassigned variable.
        /// Lastly, it will check for all textboxes on the form to see whether or not they are empty as well as if the 3rd variable previously mentioned is true or false
        /// if they are not empty, then it will call another function passing multiple objects as a parameter, and if there is an empty textbox, or if the boolean is false,
        /// it will print out all the values to determine which is causing the error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!dtpStartDate.Checked)
            {
                dtpStartDate.Value = dtpStartDate.MinDate;
                Console.WriteLine(dtpStartDate.Value.ToString());
            }


            bool discountAmount = string.IsNullOrEmpty(tbxPercent.Text) && string.IsNullOrEmpty(tbxDollar.Text);

            string inventoryName = null;

            if (!string.IsNullOrEmpty(cbInventoryName.Text))
            {
                inventoryName = cbInventoryName.SelectedItem.ToString();
            }


            if (!(string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(rtbDescription.Text) || string.IsNullOrEmpty(cbLevel.Text)
                 || string.IsNullOrEmpty(cbType.Text) || string.IsNullOrEmpty(dtpEndDate.Text))
                 && !discountAmount)
            {


                clsSQL.AddPromo(tbxName.Text, rtbDescription.Text, cbLevel.SelectedItem.ToString(), inventoryName
                    , cbType.Text, tbxPercent.Text, tbxDollar.Text, dtpStartDate, dtpEndDate);
            }
            else
            {
                Console.WriteLine(tbxName.Text + "\n" + rtbDescription.Text + "\n" + cbLevel.Text + "\n" + cbType.Text + "\n" + tbxPercent.Text
                     + "\n" + tbxDollar.Text + "\n" + dtpEndDate.Text + "\n" + discountAmount);





                MessageBox.Show("Please fill out all information fields", "Missing imformation",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }








        }


        /// <summary>
        /// This function transitions from the current form to the promo edit form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromoMenu_Click(object sender, EventArgs e)
        {
            frmPromoEditMenu promoEdit = new frmPromoEditMenu();
            promoEdit.Show();
            this.Hide();
        }

        /// <summary>
        /// This function checked for wh en the index of the type of discount is changed.
        /// Depending on which type is chosen a set of labels and textboxes is enabled or disabled, and both options
        /// set a specific textbox text to null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem.ToString() == "0")
            {
                tbxDollar.Text = null;
                lbPercent.Enabled = true;
                tbxPercent.Enabled = true;
                lbDollar.Enabled = false;
                tbxDollar.Enabled = false;

            }
            else if (cbType.SelectedItem.ToString() == "1")
            {
                tbxPercent.Text = null;
                lbPercent.Enabled = false;
                tbxPercent.Enabled = false;
                lbDollar.Enabled = true;
                tbxDollar.Enabled = true;
            }
        }

        /// <summary>
        /// This function detects when the user changes the level of discount and will either clear and disabled the name combobox and clear it, or enable
        /// it and retrieve all item names from the database to fill the combo  box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel.SelectedItem.ToString() == "0")
            {
                cbInventoryName.Items.Clear();
                cbInventoryName.Enabled = false;


            }
            else if (cbLevel.SelectedItem.ToString() == "1")
            {
                cbInventoryName.Enabled = true;

                clsSQL.getAllInventoryNames(cbInventoryName);


            }
        }

        /// <summary>
        /// This function detects when the datetimepicker value is changed. If it is then the format is set to short.
        /// If the box for the datetimepicker is not checked then the format is switched to a custom format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Short;
            if (!dtpStartDate.Checked)
            {
                dtpStartDate.Format = DateTimePickerFormat.Custom;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPromoAdd.HelpNamespace);
        }

        private void frmPromoAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
