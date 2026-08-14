using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class is made of redirecting functions that simply redirect the user to another form
    /// </summary>
    public partial class frmManager : Form
    {
        public static int managerID;

        public frmManager()
        {
            InitializeComponent();
        }


        private void frmManager_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }



        private void btnInventoryEdit_Click(object sender, EventArgs e)
        {
            frmInventoryEditMenu inventoryEdit = new frmInventoryEditMenu();
            inventoryEdit.Show();
            this.Hide();
        }

        private void btnDiscountEdit_Click(object sender, EventArgs e)
        {
            frmPromoEditMenu promoEdit = new frmPromoEditMenu();
            promoEdit.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUserManagment user = new frmUserManagment();
            user.Show();
            this.Hide();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {

            frmShoppingCart.pos = true;
            frmPointOfSale pos = new frmPointOfSale();
            pos.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }



        private void btnInventoryReport_Click_1(object sender, EventArgs e)
        {
            frmInventoryReport reports = new frmInventoryReport();
            reports.Show();
            this.Hide();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpManager.HelpNamespace);
        }
    }
}
