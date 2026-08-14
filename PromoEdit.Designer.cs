namespace CompSoftwareMastery
{
    partial class frmPromoEditMenu
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
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.btnAddPromo = new System.Windows.Forms.Button();
            this.btnEditPromo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAllNames = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpPromoEdit = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(135, 292);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(243, 41);
            this.btnManager.TabIndex = 13;
            this.btnManager.Text = "Back to manager menu";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.Location = new System.Drawing.Point(271, 146);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(227, 41);
            this.btnDiscontinue.TabIndex = 12;
            this.btnDiscontinue.Text = "Discontinue Promo";
            this.btnDiscontinue.UseVisualStyleBackColor = true;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnAddPromo
            // 
            this.btnAddPromo.Location = new System.Drawing.Point(135, 225);
            this.btnAddPromo.Name = "btnAddPromo";
            this.btnAddPromo.Size = new System.Drawing.Size(243, 41);
            this.btnAddPromo.TabIndex = 11;
            this.btnAddPromo.Text = "Add Promo Code";
            this.btnAddPromo.UseVisualStyleBackColor = true;
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            // 
            // btnEditPromo
            // 
            this.btnEditPromo.Location = new System.Drawing.Point(21, 146);
            this.btnEditPromo.Name = "btnEditPromo";
            this.btnEditPromo.Size = new System.Drawing.Size(227, 41);
            this.btnEditPromo.TabIndex = 10;
            this.btnEditPromo.Text = "Edit Promo";
            this.btnEditPromo.UseVisualStyleBackColor = true;
            this.btnEditPromo.Click += new System.EventHandler(this.btnEditPromo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select an Code";
            // 
            // cbAllNames
            // 
            this.cbAllNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllNames.FormattingEnabled = true;
            this.cbAllNames.Location = new System.Drawing.Point(47, 81);
            this.cbAllNames.Margin = new System.Windows.Forms.Padding(6);
            this.cbAllNames.Name = "cbAllNames";
            this.cbAllNames.Size = new System.Drawing.Size(428, 33);
            this.cbAllNames.TabIndex = 8;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(135, 351);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(243, 41);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpPromoEdit
            // 
            this.hlpPromoEdit.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\PromoEditForm.chm";
            // 
            // frmPromoEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(520, 415);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnDiscontinue);
            this.Controls.Add(this.btnAddPromo);
            this.Controls.Add(this.btnEditPromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPromoEditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromoEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPromoEdit_FormClosed);
            this.Load += new System.EventHandler(this.frmPromoEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.Button btnAddPromo;
        private System.Windows.Forms.Button btnEditPromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAllNames;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpPromoEdit;
    }
}