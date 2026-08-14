namespace CompSoftwareMastery
{
    partial class frmCustomer
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.rtbProductInfo = new System.Windows.Forms.RichTextBox();
            this.hlpCustomer = new System.Windows.Forms.HelpProvider();
            this.buttonHlp = new System.Windows.Forms.Button();
            this.lbAddToCart = new System.Windows.Forms.Label();
            this.pbSelectedItem = new System.Windows.Forms.PictureBox();
            this.lbManagerPOS = new System.Windows.Forms.Label();
            this.hlpManager = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(681, 460);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(309, 46);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Proceed to checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 679);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(660, 8);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(104, 24);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search For";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1016, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(768, 6);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(242, 29);
            this.tbxSearch.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1111, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Search";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(768, 41);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(242, 32);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(677, 44);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(85, 24);
            this.lbCategory.TabIndex = 11;
            this.lbCategory.Text = "Category";
            // 
            // cbQuantity
            // 
            this.cbQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.cbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Location = new System.Drawing.Point(1070, 308);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(242, 32);
            this.cbQuantity.TabIndex = 5;
            this.cbQuantity.Click += new System.EventHandler(this.cbQuantity_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(1107, 257);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(78, 24);
            this.lbQuantity.TabIndex = 14;
            this.lbQuantity.Text = "Quantity\r\n";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(1090, 379);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(211, 46);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // rtbProductInfo
            // 
            this.rtbProductInfo.Enabled = false;
            this.rtbProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbProductInfo.Location = new System.Drawing.Point(1001, 112);
            this.rtbProductInfo.Name = "rtbProductInfo";
            this.rtbProductInfo.Size = new System.Drawing.Size(417, 142);
            this.rtbProductInfo.TabIndex = 16;
            this.rtbProductInfo.Text = "";
            // 
            // hlpCustomer
            // 
            this.hlpCustomer.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\CustomerForm.chm";
            // 
            // buttonHlp
            // 
            this.buttonHlp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHlp.Location = new System.Drawing.Point(1330, 621);
            this.buttonHlp.Name = "buttonHlp";
            this.buttonHlp.Size = new System.Drawing.Size(110, 46);
            this.buttonHlp.TabIndex = 17;
            this.buttonHlp.Text = "Help";
            this.buttonHlp.UseVisualStyleBackColor = true;
            this.buttonHlp.Click += new System.EventHandler(this.buttonHlp_Click);
            // 
            // lbAddToCart
            // 
            this.lbAddToCart.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbAddToCart.AutoSize = true;
            this.lbAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddToCart.Location = new System.Drawing.Point(1129, 446);
            this.lbAddToCart.Name = "lbAddToCart";
            this.lbAddToCart.Size = new System.Drawing.Size(145, 24);
            this.lbAddToCart.TabIndex = 18;
            this.lbAddToCart.Text = "Placeholder text";
            this.lbAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSelectedItem
            // 
            this.pbSelectedItem.Location = new System.Drawing.Point(660, 104);
            this.pbSelectedItem.Name = "pbSelectedItem";
            this.pbSelectedItem.Size = new System.Drawing.Size(300, 300);
            this.pbSelectedItem.TabIndex = 12;
            this.pbSelectedItem.TabStop = false;
            // 
            // lbManagerPOS
            // 
            this.lbManagerPOS.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbManagerPOS.AutoSize = true;
            this.lbManagerPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagerPOS.Location = new System.Drawing.Point(1129, 62);
            this.lbManagerPOS.Name = "lbManagerPOS";
            this.lbManagerPOS.Size = new System.Drawing.Size(145, 24);
            this.lbManagerPOS.TabIndex = 19;
            this.lbManagerPOS.Text = "Placeholder text";
            this.lbManagerPOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hlpManager
            // 
            this.hlpManager.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\CustomerFormManager.chm";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1452, 679);
            this.Controls.Add(this.lbManagerPOS);
            this.Controls.Add(this.lbAddToCart);
            this.Controls.Add(this.buttonHlp);
            this.Controls.Add(this.rtbProductInfo);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.pbSelectedItem);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.tbxSearch);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomer_FormClosed);
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.PictureBox pbSelectedItem;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.RichTextBox rtbProductInfo;
        private System.Windows.Forms.HelpProvider hlpCustomer;
        private System.Windows.Forms.Button buttonHlp;
        private System.Windows.Forms.Label lbAddToCart;
        private System.Windows.Forms.Label lbManagerPOS;
        private System.Windows.Forms.HelpProvider hlpManager;
    }
}