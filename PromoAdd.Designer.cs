namespace CompSoftwareMastery
{
    partial class frmPromoAdd
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
            this.lbName = new System.Windows.Forms.Label();
            this.btnPromoMenu = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDollar = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbInventoryName = new System.Windows.Forms.ComboBox();
            this.lbInventory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbxDollar = new System.Windows.Forms.TextBox();
            this.tbxPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpPromoAdd = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(435, 18);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(242, 25);
            this.lbName.TabIndex = 56;
            this.lbName.Text = "Adding New Promocode";
            // 
            // btnPromoMenu
            // 
            this.btnPromoMenu.Location = new System.Drawing.Point(393, 567);
            this.btnPromoMenu.Name = "btnPromoMenu";
            this.btnPromoMenu.Size = new System.Drawing.Size(249, 48);
            this.btnPromoMenu.TabIndex = 10;
            this.btnPromoMenu.Text = "Return to Promo menu";
            this.btnPromoMenu.UseVisualStyleBackColor = true;
            this.btnPromoMenu.Click += new System.EventHandler(this.btnPromoMenu_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(674, 567);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(249, 48);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Confirm Promo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbDollar
            // 
            this.lbDollar.AutoSize = true;
            this.lbDollar.Enabled = false;
            this.lbDollar.Location = new System.Drawing.Point(904, 150);
            this.lbDollar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(147, 75);
            this.lbDollar.TabIndex = 50;
            this.lbDollar.Text = "Discount \r\nDollar Amount\r\n($0.00 format)";
            this.lbDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Enabled = false;
            this.lbPercent.Location = new System.Drawing.Point(894, 18);
            this.lbPercent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(176, 50);
            this.lbPercent.TabIndex = 48;
            this.lbPercent.Text = "Discount Percent\r\n(00% format)";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(249, 205);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(253, 117);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 50);
            this.label2.TabIndex = 40;
            this.label2.Text = "Discount \r\nDescription";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(244, 111);
            this.tbxName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(258, 31);
            this.tbxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Discount Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Discount Level";
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbLevel.Location = new System.Drawing.Point(855, 311);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(95, 33);
            this.cbLevel.TabIndex = 8;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbType.Location = new System.Drawing.Point(755, 139);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(95, 33);
            this.cbType.TabIndex = 5;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Discount Type";
            // 
            // cbInventoryName
            // 
            this.cbInventoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInventoryName.Enabled = false;
            this.cbInventoryName.FormattingEnabled = true;
            this.cbInventoryName.Location = new System.Drawing.Point(664, 415);
            this.cbInventoryName.Name = "cbInventoryName";
            this.cbInventoryName.Size = new System.Drawing.Size(372, 33);
            this.cbInventoryName.TabIndex = 9;
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.Enabled = false;
            this.lbInventory.Location = new System.Drawing.Point(767, 378);
            this.lbInventory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(173, 25);
            this.lbInventory.TabIndex = 59;
            this.lbInventory.Text = "Inventory Names";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 75);
            this.label5.TabIndex = 61;
            this.label5.Text = "Discount State Date\r\n(Uncheck box for no \r\nstart date)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = " ";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(368, 392);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(144, 31);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.Value = new System.DateTime(2025, 4, 10, 17, 22, 15, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 482);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "Discount End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(365, 477);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(147, 31);
            this.dtpEndDate.TabIndex = 4;
            this.dtpEndDate.Value = new System.DateTime(2025, 4, 10, 17, 34, 20, 0);
            // 
            // tbxDollar
            // 
            this.tbxDollar.Enabled = false;
            this.tbxDollar.Location = new System.Drawing.Point(928, 231);
            this.tbxDollar.Margin = new System.Windows.Forms.Padding(6);
            this.tbxDollar.Name = "tbxDollar";
            this.tbxDollar.Size = new System.Drawing.Size(94, 31);
            this.tbxDollar.TabIndex = 7;
            // 
            // tbxPercent
            // 
            this.tbxPercent.Enabled = false;
            this.tbxPercent.Location = new System.Drawing.Point(928, 78);
            this.tbxPercent.Margin = new System.Windows.Forms.Padding(6);
            this.tbxPercent.Name = "tbxPercent";
            this.tbxPercent.Size = new System.Drawing.Size(94, 31);
            this.tbxPercent.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1024, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 66;
            this.label6.Text = "%";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(118, 567);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(243, 45);
            this.btnHelp.TabIndex = 67;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpPromoAdd
            // 
            this.hlpPromoAdd.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\PromoAdd.chm";
            // 
            // frmPromoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1181, 628);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbInventoryName);
            this.Controls.Add(this.lbInventory);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnPromoMenu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxDollar);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.tbxPercent);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPromoAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromoAdd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPromoAdd_FormClosed);
            this.Load += new System.EventHandler(this.frmPromoAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnPromoMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbDollar;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbInventoryName;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbxDollar;
        private System.Windows.Forms.TextBox tbxPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpPromoAdd;
    }
}