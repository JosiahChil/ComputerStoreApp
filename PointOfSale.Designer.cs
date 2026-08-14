namespace CompSoftwareMastery
{
    partial class frmPointOfSale
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
            this.btnPOS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAllNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLookupMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCustomerOrders = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpPOS = new System.Windows.Forms.HelpProvider();
            this.tbxUserLookup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(126, 492);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(243, 41);
            this.btnManager.TabIndex = 26;
            this.btnManager.Text = "Back to manager menu";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(126, 363);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(243, 41);
            this.btnPOS.TabIndex = 25;
            this.btnPOS.Text = "Shop as this Customer";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select an User";
            // 
            // cbAllNames
            // 
            this.cbAllNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllNames.FormattingEnabled = true;
            this.cbAllNames.Location = new System.Drawing.Point(26, 308);
            this.cbAllNames.Margin = new System.Windows.Forms.Padding(6);
            this.cbAllNames.Name = "cbAllNames";
            this.cbAllNames.Size = new System.Drawing.Size(428, 33);
            this.cbAllNames.TabIndex = 21;
            this.cbAllNames.SelectedValueChanged += new System.EventHandler(this.cbAllNames_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select a method of lookup";
            // 
            // cbLookupMethod
            // 
            this.cbLookupMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLookupMethod.FormattingEnabled = true;
            this.cbLookupMethod.Items.AddRange(new object[] {
            "PersonID",
            "Name",
            "Address1",
            "Email",
            "PhonePrimary"});
            this.cbLookupMethod.Location = new System.Drawing.Point(104, 78);
            this.cbLookupMethod.Margin = new System.Windows.Forms.Padding(6);
            this.cbLookupMethod.Name = "cbLookupMethod";
            this.cbLookupMethod.Size = new System.Drawing.Size(265, 33);
            this.cbLookupMethod.TabIndex = 28;
            this.cbLookupMethod.SelectedValueChanged += new System.EventHandler(this.cbLookupMethod_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(121, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Type a value to look up";
            // 
            // btnCustomerOrders
            // 
            this.btnCustomerOrders.Location = new System.Drawing.Point(126, 431);
            this.btnCustomerOrders.Name = "btnCustomerOrders";
            this.btnCustomerOrders.Size = new System.Drawing.Size(243, 41);
            this.btnCustomerOrders.TabIndex = 32;
            this.btnCustomerOrders.Text = "Get Customer Orders";
            this.btnCustomerOrders.UseVisualStyleBackColor = true;
            this.btnCustomerOrders.Click += new System.EventHandler(this.btnCustomerOrders_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeight = 50;
            this.dgvData.Enabled = false;
            this.dgvData.Location = new System.Drawing.Point(2, 0);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 60;
            this.dgvData.Size = new System.Drawing.Size(83, 36);
            this.dgvData.TabIndex = 10001;
            this.dgvData.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(126, 555);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(243, 41);
            this.btnHelp.TabIndex = 10002;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpPOS
            // 
            this.hlpPOS.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\PointOfSaleForm.chm";
            // 
            // tbxUserLookup
            // 
            this.tbxUserLookup.Location = new System.Drawing.Point(60, 202);
            this.tbxUserLookup.Name = "tbxUserLookup";
            this.tbxUserLookup.Size = new System.Drawing.Size(354, 31);
            this.tbxUserLookup.TabIndex = 10003;
            this.tbxUserLookup.TextChanged += new System.EventHandler(this.tbxUserLookup_TextChanged);
            // 
            // frmPointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(510, 618);
            this.Controls.Add(this.tbxUserLookup);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnCustomerOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLookupMethod);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPointOfSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointOfSale";
            this.Load += new System.EventHandler(this.frmPointOfSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAllNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLookupMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCustomerOrders;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpPOS;
        private System.Windows.Forms.TextBox tbxUserLookup;
    }
}