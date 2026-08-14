using System;
using System.Windows.Forms;

namespace CompSoftwareMastery
{

    /// <summary>
    /// This class handles sending the user to  various forms to modify and manage users, or disabling them
    /// </summary>
    public partial class frmUserManagment : Form
    {

        public frmUserManagment()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This function loads all user's names into a combo box from the database, then disables 2 buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserManagment_Load(object sender, EventArgs e)
        {
            clsSQL.GetPeopleNames(cbAllNames);
            btnDisable.Enabled = false;
            btnEditUser.Enabled = false;
        }

        /// <summary>
        /// This function hides the form and takes them to the add new user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser user = new frmAddNewUser();
            user.Show();
            this.Hide();
        }

        /// <summary>
        /// This function checks if the combobox is null or empty. If it is then it tells the user to choose a user to edit.
        /// If it isnt then it hides the form and takes them to the user modify form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbAllNames.Text))
            {
                frmUserModify user = new frmUserModify();
                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You need to select a user to edit", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// This function takes the selected user and disables them in the database via another function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            clsSQL.DeactivatePerson(cbAllNames.Text);
        }

        /// <summary>
        /// This function detects when the user chooses a user listed in the combobox, then
        /// saves the name into a global variable to be used later,
        /// and enables the 2 buttons previously disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAllNames_SelectedValueChanged(object sender, EventArgs e)
        {
            frmUserModify.name = cbAllNames.Text;
            btnDisable.Enabled = true;
            btnEditUser.Enabled = true;
        }

        /// <summary>
        /// This function hides the form and takes them to the manager form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpUserManagment.HelpNamespace);
        }
    }
}
