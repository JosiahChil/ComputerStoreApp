namespace CompSoftwareMastery
{
    partial class frmInventoryReport
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pOrder = new System.Windows.Forms.Panel();
            this.lbemptyCheck = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrderReport = new System.Windows.Forms.Button();
            this.dtpDatecondition = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.pInventory = new System.Windows.Forms.Panel();
            this.btnInventoryReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDatabaseTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpReports = new System.Windows.Forms.HelpProvider();
            this.btnManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pOrder.SuspendLayout();
            this.pInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeight = 50;
            this.dgvData.Enabled = false;
            this.dgvData.Location = new System.Drawing.Point(1, 0);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 60;
            this.dgvData.Size = new System.Drawing.Size(83, 36);
            this.dgvData.TabIndex = 10000;
            this.dgvData.Visible = false;
            // 
            // pOrder
            // 
            this.pOrder.Controls.Add(this.lbemptyCheck);
            this.pOrder.Controls.Add(this.label8);
            this.pOrder.Controls.Add(this.cbPerson);
            this.pOrder.Controls.Add(this.label7);
            this.pOrder.Controls.Add(this.btnOrderReport);
            this.pOrder.Controls.Add(this.dtpDatecondition);
            this.pOrder.Controls.Add(this.label4);
            this.pOrder.Controls.Add(this.label6);
            this.pOrder.Controls.Add(this.cbRange);
            this.pOrder.Enabled = false;
            this.pOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOrder.Location = new System.Drawing.Point(472, 159);
            this.pOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(402, 381);
            this.pOrder.TabIndex = 10005;
            // 
            // lbemptyCheck
            // 
            this.lbemptyCheck.AutoSize = true;
            this.lbemptyCheck.Location = new System.Drawing.Point(16, 342);
            this.lbemptyCheck.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbemptyCheck.Name = "lbemptyCheck";
            this.lbemptyCheck.Size = new System.Drawing.Size(129, 25);
            this.lbemptyCheck.TabIndex = 11;
            this.lbemptyCheck.Text = "PlaceHolder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Person";
            // 
            // cbPerson
            // 
            this.cbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(84, 204);
            this.cbPerson.Margin = new System.Windows.Forms.Padding(6);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(238, 33);
            this.cbPerson.TabIndex = 14;
            this.cbPerson.SelectedValueChanged += new System.EventHandler(this.cbPerson_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Starting Date";
            // 
            // btnOrderReport
            // 
            this.btnOrderReport.Location = new System.Drawing.Point(84, 269);
            this.btnOrderReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Size = new System.Drawing.Size(238, 54);
            this.btnOrderReport.TabIndex = 11;
            this.btnOrderReport.Text = "Get orders report";
            this.btnOrderReport.UseVisualStyleBackColor = true;
            this.btnOrderReport.Click += new System.EventHandler(this.btnOrderReport_Click);
            // 
            // dtpDatecondition
            // 
            this.dtpDatecondition.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatecondition.Location = new System.Drawing.Point(144, 46);
            this.dtpDatecondition.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatecondition.Name = "dtpDatecondition";
            this.dtpDatecondition.Size = new System.Drawing.Size(148, 31);
            this.dtpDatecondition.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Range of data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Orders Data";
            // 
            // cbRange
            // 
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.cbRange.Location = new System.Drawing.Point(84, 125);
            this.cbRange.Margin = new System.Windows.Forms.Padding(6);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(238, 33);
            this.cbRange.TabIndex = 7;
            this.cbRange.SelectedValueChanged += new System.EventHandler(this.cbRange_SelectedValueChanged);
            // 
            // pInventory
            // 
            this.pInventory.Controls.Add(this.btnInventoryReport);
            this.pInventory.Controls.Add(this.label3);
            this.pInventory.Controls.Add(this.cbCondition);
            this.pInventory.Controls.Add(this.label5);
            this.pInventory.Enabled = false;
            this.pInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInventory.Location = new System.Drawing.Point(40, 159);
            this.pInventory.Margin = new System.Windows.Forms.Padding(4);
            this.pInventory.Name = "pInventory";
            this.pInventory.Size = new System.Drawing.Size(402, 358);
            this.pInventory.TabIndex = 10004;
            // 
            // btnInventoryReport
            // 
            this.btnInventoryReport.Location = new System.Drawing.Point(124, 144);
            this.btnInventoryReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventoryReport.Name = "btnInventoryReport";
            this.btnInventoryReport.Size = new System.Drawing.Size(238, 54);
            this.btnInventoryReport.TabIndex = 10;
            this.btnInventoryReport.Text = "Get inventory report";
            this.btnInventoryReport.UseVisualStyleBackColor = true;
            this.btnInventoryReport.Click += new System.EventHandler(this.btnInventoryReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Condition";
            // 
            // cbCondition
            // 
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "None",
            "Needing restock",
            "Avalible for sale"});
            this.cbCondition.Location = new System.Drawing.Point(124, 69);
            this.cbCondition.Margin = new System.Windows.Forms.Padding(6);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(238, 33);
            this.cbCondition.TabIndex = 4;
            this.cbCondition.SelectedValueChanged += new System.EventHandler(this.cbCondition_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Inventory Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 10003;
            this.label2.Text = "Reports";
            // 
            // cbDatabaseTable
            // 
            this.cbDatabaseTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabaseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabaseTable.FormattingEnabled = true;
            this.cbDatabaseTable.Items.AddRange(new object[] {
            "Inventory",
            "Orders"});
            this.cbDatabaseTable.Location = new System.Drawing.Point(358, 69);
            this.cbDatabaseTable.Margin = new System.Windows.Forms.Padding(6);
            this.cbDatabaseTable.Name = "cbDatabaseTable";
            this.cbDatabaseTable.Size = new System.Drawing.Size(238, 33);
            this.cbDatabaseTable.TabIndex = 10002;
            this.cbDatabaseTable.SelectedValueChanged += new System.EventHandler(this.cbDatabaseTable_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 10001;
            this.label1.Text = "Data Table";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 552);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(131, 41);
            this.btnHelp.TabIndex = 10006;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpReports
            // 
            this.hlpReports.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\InventoryReport.chm";
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(164, 552);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(238, 41);
            this.btnManager.TabIndex = 10007;
            this.btnManager.Text = "Back to manager menu";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(928, 605);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pOrder);
            this.Controls.Add(this.pInventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDatabaseTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmInventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryReport";
            this.Load += new System.EventHandler(this.frmInventoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pOrder.ResumeLayout(false);
            this.pOrder.PerformLayout();
            this.pInventory.ResumeLayout(false);
            this.pInventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrderReport;
        private System.Windows.Forms.DateTimePicker dtpDatecondition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.Panel pInventory;
        private System.Windows.Forms.Button btnInventoryReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDatabaseTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbemptyCheck;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpReports;
        private System.Windows.Forms.Button btnManager;
    }
}