namespace CompSoftwareMastery
{
    partial class frmEditingInventoryItem
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxRestock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.hlpEditItem = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbItemDeleted = new System.Windows.Forms.Label();
            this.cbItemDeleted = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(226, 533);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(249, 48);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Return to edit menu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(520, 533);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(249, 48);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Confirm Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(611, 396);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(158, 35);
            this.btnImage.TabIndex = 34;
            this.btnImage.Text = "Choose Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Item Image";
            // 
            // tbxRestock
            // 
            this.tbxRestock.Location = new System.Drawing.Point(623, 316);
            this.tbxRestock.Margin = new System.Windows.Forms.Padding(6);
            this.tbxRestock.Name = "tbxRestock";
            this.tbxRestock.Size = new System.Drawing.Size(146, 31);
            this.tbxRestock.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 50);
            this.label7.TabIndex = 31;
            this.label7.Text = "Restock\r\nThreshold";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(623, 214);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(146, 31);
            this.tbxQuantity.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quantity";
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(623, 117);
            this.tbxCost.Margin = new System.Windows.Forms.Padding(6);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(146, 31);
            this.tbxCost.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 50);
            this.label5.TabIndex = 27;
            this.label5.Text = "Item Cost\r\n(To make)";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(176, 456);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(6);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(133, 31);
            this.tbxPrice.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 459);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Item Price";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(176, 396);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(253, 33);
            this.cbCategory.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Item Type";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(176, 197);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(253, 117);
            this.rtbDescription.TabIndex = 22;
            this.rtbDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 50);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item \r\nDescription";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(171, 111);
            this.tbxName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(258, 31);
            this.tbxName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item Name";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(315, 28);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(124, 25);
            this.lbName.TabIndex = 37;
            this.lbName.Text = "placeholder";
            // 
            // hlpEditItem
            // 
            this.hlpEditItem.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\EditingInventory.chm";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 533);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(173, 48);
            this.btnHelp.TabIndex = 38;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbItemDeleted
            // 
            this.lbItemDeleted.AutoSize = true;
            this.lbItemDeleted.Location = new System.Drawing.Point(475, 457);
            this.lbItemDeleted.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbItemDeleted.Name = "lbItemDeleted";
            this.lbItemDeleted.Size = new System.Drawing.Size(137, 25);
            this.lbItemDeleted.TabIndex = 39;
            this.lbItemDeleted.Text = "Discontinued";
            // 
            // cbItemDeleted
            // 
            this.cbItemDeleted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemDeleted.FormattingEnabled = true;
            this.cbItemDeleted.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbItemDeleted.Location = new System.Drawing.Point(621, 454);
            this.cbItemDeleted.Name = "cbItemDeleted";
            this.cbItemDeleted.Size = new System.Drawing.Size(112, 33);
            this.cbItemDeleted.TabIndex = 40;
            // 
            // frmEditingInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(805, 593);
            this.Controls.Add(this.cbItemDeleted);
            this.Controls.Add(this.lbItemDeleted);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxRestock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEditingInventoryItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditingInventoryItem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditingInventoryItem_FormClosed);
            this.Load += new System.EventHandler(this.frmEditingInventoryItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxRestock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.HelpProvider hlpEditItem;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lbItemDeleted;
        private System.Windows.Forms.ComboBox cbItemDeleted;
    }
}