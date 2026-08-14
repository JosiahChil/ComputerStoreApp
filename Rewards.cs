using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSoftwareMastery
{
    /// <summary>
    /// This form handles reward registration
    /// </summary>
    public partial class frmRewards : Form
    {
        public frmRewards()
        {
            InitializeComponent();
        }

        public static int LogonID;
        public static string LogonName;
        public static int points = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rewards_Load(object sender, EventArgs e)
        {
           bool oldAcc = clsSQL.CheckUserDate(LogonID, LogonName);
            if (oldAcc)
            {
                points = 500;
            }
        }

        /// <summary>
        /// This function checkes the 2 checkboxes to see if they are checked.
        /// If they are that means the user as accepted the terms and conditions and the confirm button is enabled.
        /// If not then the user must check the boxes before the button is enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptTaCcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!acceptTaCcheck.Checked || !acceptEmailcheck.Checked){
                btnConfirm.Enabled = false;
            }
            else
            {
                btnConfirm.Enabled = true;
            }
        }

        /// <summary>
        /// This function checkes the 2 checkboxes to see if they are checked.
        /// If they are that means the user as accepted the terms and conditions and the confirm button is enabled.
        /// If not then the user must check the boxes before the button is enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptEmailcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!acceptTaCcheck.Checked || !acceptEmailcheck.Checked)
            {
                btnConfirm.Enabled = false;
            }
            else
            {
                btnConfirm.Enabled = true;
            }
        }

        /// <summary>
        /// This button passes a set of parameters to another function, registering the user, then tells the user
        /// theyve been verified and then hides the form, moving them to the customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            clsSQL.AddToRewards(LogonID, LogonName, points);
            MessageBox.Show("Youve been enrolled in the rewards program!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCustomer.hasAccount = true;
            frmCustomer Customer = new frmCustomer();
            Customer.Show();
            this.Hide();
           
        }

        /// <summary>
        /// This form simply hides the form and movese the user to the customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeny_Click(object sender, EventArgs e)
        {
            frmCustomer.hasAccount = true;
            frmCustomer Customer = new frmCustomer();
            Customer.Show();
            this.Hide();
        }

       
    }
}
