using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class allows the manager to add promo codes to the database
    /// </summary>
    public partial class frmPromoModify : Form
    {
        public static string promocodeName = "";
        public frmPromoModify()
        {
            InitializeComponent();
        }

        private void PromoModify_Load(object sender, EventArgs e)
        {


            clsSQL.getAllInventoryNames(cbInventoryName);

            clsSQL.FillDiscountsInfo(promocodeName, tbxName, rtbDescription, cbLevel, cbInventoryName
                    , cbType, tbxPercent, tbxDollar, dtpStartDate, dtpEndDate);

        }

        private void frmPromoModify_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
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
        /// it the combobox
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




            }
        }

       /// <summary>
       /// This function first checks a pair of textboxes for being null or empty. If either are then the variable is set to true, preventing the editing from taking place.
       /// After that the datetimepicker for the start date is checked. If the box is not checked then the datetimepicker value is set to the min date possible.
       /// Then if the combobox for inventory names is not null or empty, the inventory name variable that was initilized but not filled before is assigned to the string value
       /// of the selected item. Once that is finished the function checks a  handfull of values from the application as well as the initial boolean that checked if the pair of
       /// textboxes were null or empty. IF everything passes the check then the various values are passed to another function and the database's discount code is edited, otherwise
       /// the function will not edit the values
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool discountAmount = string.IsNullOrEmpty(tbxPercent.Text) && string.IsNullOrEmpty(tbxDollar.Text);

            string inventoryName = null;
            if (!dtpStartDate.Checked)
            {
                dtpStartDate.Value = dtpStartDate.MinDate;
            }

            if (!string.IsNullOrEmpty(cbInventoryName.Text))
            {
                inventoryName = cbInventoryName.SelectedItem.ToString();
            }


            if (!(string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(rtbDescription.Text) || string.IsNullOrEmpty(cbLevel.Text)
                 || string.IsNullOrEmpty(cbType.Text) || string.IsNullOrEmpty(dtpEndDate.Text))
                 && !discountAmount)
            {


                clsSQL.ModifyPromo(promocodeName, tbxName.Text, rtbDescription.Text, cbLevel.SelectedItem.ToString(), inventoryName
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
            Help.ShowHelp(this, hlpPromoModify.HelpNamespace);
        }
    }
}
