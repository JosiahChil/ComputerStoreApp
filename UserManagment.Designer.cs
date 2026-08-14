namespace CompSoftwareMastery
{
    partial class frmUserManagment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManager = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAllNames = new System.Windows.Forms.ComboBox();
            this.hlpUserManagment = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(142, 311);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(243, 41);
            this.btnManager.TabIndex = 20;
            this.btnManager.Text = "Back to manager menu";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(279, 141);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(227, 41);
            this.btnDisable.TabIndex = 19;
            this.btnDisable.Text = "Disable user";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(142, 244);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(243, 41);
            this.btnAddUser.TabIndex = 18;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(29, 141);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(227, 41);
            this.btnEditUser.TabIndex = 17;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select an User";
            // 
            // cbAllNames
            // 
            this.cbAllNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllNames.FormattingEnabled = true;
            this.cbAllNames.Location = new System.Drawing.Point(55, 76);
            this.cbAllNames.Margin = new System.Windows.Forms.Padding(6);
            this.cbAllNames.Name = "cbAllNames";
            this.cbAllNames.Size = new System.Drawing.Size(428, 33);
            this.cbAllNames.TabIndex = 15;
            this.cbAllNames.SelectedValueChanged += new System.EventHandler(this.cbAllNames_SelectedValueChanged);
            // 
            // hlpUserManagment
            // 
            this.hlpUserManagment.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\UserManagmentForm.chm";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(142, 376);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(243, 41);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmUserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(539, 429);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagment";
            this.Load += new System.EventHandler(this.frmUserManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAllNames;
        private System.Windows.Forms.HelpProvider hlpUserManagment;
        private System.Windows.Forms.Button btnHelp;
    }
}