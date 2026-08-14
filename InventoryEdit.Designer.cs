namespace CompSoftwareMastery
{
    partial class frmInventoryEditMenu
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
            this.cbAllNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.hlpInventoryEdit = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAllNames
            // 
            this.cbAllNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllNames.FormattingEnabled = true;
            this.cbAllNames.Location = new System.Drawing.Point(53, 105);
            this.cbAllNames.Margin = new System.Windows.Forms.Padding(6);
            this.cbAllNames.Name = "cbAllNames";
            this.cbAllNames.Size = new System.Drawing.Size(428, 33);
            this.cbAllNames.TabIndex = 0;
            this.cbAllNames.SelectedIndexChanged += new System.EventHandler(this.cbAllNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an item";
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(27, 170);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(227, 41);
            this.btnEditItem.TabIndex = 4;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(140, 228);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(243, 41);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item to Inventory";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.Location = new System.Drawing.Point(277, 170);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(227, 41);
            this.btnDiscontinue.TabIndex = 6;
            this.btnDiscontinue.Text = "Discontinue Item";
            this.btnDiscontinue.UseVisualStyleBackColor = true;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(140, 340);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(243, 41);
            this.btnManager.TabIndex = 7;
            this.btnManager.Text = "Back to manager menu";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(140, 283);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(243, 41);
            this.btnRestock.TabIndex = 8;
            this.btnRestock.Text = "Restock Alert";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // hlpInventoryEdit
            // 
            this.hlpInventoryEdit.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\InventoryEditMenu.chm";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(396, 353);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(129, 46);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmInventoryEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(537, 411);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnDiscontinue);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmInventoryEditMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventoryEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInventoryEdit_FormClosed);
            this.Load += new System.EventHandler(this.frmInventoryEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAllNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.HelpProvider hlpInventoryEdit;
        private System.Windows.Forms.Button btnHelp;
    }
}