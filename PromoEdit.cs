using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This class is another one made of redirecting functions that simply redirect the user to another form
    /// </summary>
    public partial class frmPromoEditMenu : Form
    {

        public frmPromoEditMenu()
        {
            InitializeComponent();
        }

        private void frmPromoEdit_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        private void frmPromoEdit_Load(object sender, EventArgs e)
        {

            clsSQL.GetPromo(cbAllNames);




        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Hide();
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {

            clsSQL.PromoDisable(cbAllNames.Text);
        }


        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            frmPromoAdd promoAdd = new frmPromoAdd();
            promoAdd.Show();
            this.Hide();
        }

        private void btnEditPromo_Click(object sender, EventArgs e)
        {
            frmPromoModify.promocodeName = cbAllNames.Text;
            frmPromoModify promoModify = new frmPromoModify();
            promoModify.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPromoEdit.HelpNamespace);
        }
    }
}
