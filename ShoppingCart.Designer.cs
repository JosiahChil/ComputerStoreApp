namespace CompSoftwareMastery
{
    partial class frmShoppingCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtCart = new System.Windows.Forms.DataGridView();
            this.clnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.MaskedTextBox();
            this.tbxCreditCard = new System.Windows.Forms.MaskedTextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCCV = new System.Windows.Forms.Label();
            this.lbCreditCard = new System.Windows.Forms.Label();
            this.btnCompletePurchase = new System.Windows.Forms.Button();
            this.lbStoreName = new System.Windows.Forms.Label();
            this.tbxCCV = new System.Windows.Forms.MaskedTextBox();
            this.lbFeedback = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbDiscountFeedback = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.hlpShopping = new System.Windows.Forms.HelpProvider();
            this.btnBackToShop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.cbNewQuantity = new System.Windows.Forms.ComboBox();
            this.bntConfirm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbEditingName = new System.Windows.Forms.Label();
            this.pEditing = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDiscounts = new System.Windows.Forms.RichTextBox();
            this.pDiscounts = new System.Windows.Forms.Panel();
            this.hlpManager = new System.Windows.Forms.HelpProvider();
            this.redeemLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.pointCfmBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pointCheckerlb = new System.Windows.Forms.Label();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtCart)).BeginInit();
            this.pEditing.SuspendLayout();
            this.pDiscounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtCart
            // 
            this.dtCart.ColumnHeadersHeight = 50;
            this.dtCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnItem,
            this.clnPrice,
            this.clnQuantity,
            this.clnTotal});
            this.dtCart.Location = new System.Drawing.Point(73, 83);
            this.dtCart.Name = "dtCart";
            this.dtCart.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtCart.RowHeadersWidth = 60;
            this.dtCart.Size = new System.Drawing.Size(611, 326);
            this.dtCart.TabIndex = 9999;
            this.dtCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCart_CellClick);
            // 
            // clnItem
            // 
            this.clnItem.FillWeight = 150F;
            this.clnItem.HeaderText = "Item";
            this.clnItem.Name = "clnItem";
            this.clnItem.ReadOnly = true;
            this.clnItem.Width = 250;
            // 
            // clnPrice
            // 
            this.clnPrice.FillWeight = 200F;
            this.clnPrice.HeaderText = "Item Price";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // clnQuantity
            // 
            this.clnQuantity.FillWeight = 200F;
            this.clnQuantity.HeaderText = "Quantity";
            this.clnQuantity.Name = "clnQuantity";
            this.clnQuantity.ReadOnly = true;
            // 
            // clnTotal
            // 
            this.clnTotal.FillWeight = 200F;
            this.clnTotal.HeaderText = "Total Price";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(629, 463);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(134, 24);
            this.lbDiscount.TabIndex = 35;
            this.lbDiscount.Text = "Discount Code";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscount.Location = new System.Drawing.Point(612, 490);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(173, 29);
            this.tbxDiscount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Payment Information";
            // 
            // tbxDate
            // 
            this.tbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDate.Location = new System.Drawing.Point(124, 572);
            this.tbxDate.Mask = "00/00";
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(65, 31);
            this.tbxDate.TabIndex = 3;
            this.tbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbxCreditCard
            // 
            this.tbxCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCreditCard.Location = new System.Drawing.Point(124, 495);
            this.tbxCreditCard.Mask = "0000-0000-0000-0000";
            this.tbxCreditCard.Name = "tbxCreditCard";
            this.tbxCreditCard.Size = new System.Drawing.Size(226, 31);
            this.tbxCreditCard.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(69, 572);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(48, 24);
            this.lbDate.TabIndex = 31;
            this.lbDate.Text = "Date";
            // 
            // lbCCV
            // 
            this.lbCCV.AutoSize = true;
            this.lbCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCV.Location = new System.Drawing.Point(69, 537);
            this.lbCCV.Name = "lbCCV";
            this.lbCCV.Size = new System.Drawing.Size(49, 24);
            this.lbCCV.TabIndex = 29;
            this.lbCCV.Text = "CCV";
            // 
            // lbCreditCard
            // 
            this.lbCreditCard.AutoSize = true;
            this.lbCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditCard.Location = new System.Drawing.Point(1, 502);
            this.lbCreditCard.Name = "lbCreditCard";
            this.lbCreditCard.Size = new System.Drawing.Size(117, 24);
            this.lbCreditCard.TabIndex = 28;
            this.lbCreditCard.Text = "Credit / Debit";
            // 
            // btnCompletePurchase
            // 
            this.btnCompletePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletePurchase.Location = new System.Drawing.Point(653, 711);
            this.btnCompletePurchase.Name = "btnCompletePurchase";
            this.btnCompletePurchase.Size = new System.Drawing.Size(185, 46);
            this.btnCompletePurchase.TabIndex = 9;
            this.btnCompletePurchase.Text = "Complete Purchase";
            this.btnCompletePurchase.UseVisualStyleBackColor = true;
            this.btnCompletePurchase.Click += new System.EventHandler(this.btnCompletePurchase_Click);
            // 
            // lbStoreName
            // 
            this.lbStoreName.AutoSize = true;
            this.lbStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStoreName.Location = new System.Drawing.Point(145, 10);
            this.lbStoreName.Name = "lbStoreName";
            this.lbStoreName.Size = new System.Drawing.Size(436, 37);
            this.lbStoreName.TabIndex = 38;
            this.lbStoreName.Text = "Josiah\'s Computer Part Store";
            // 
            // tbxCCV
            // 
            this.tbxCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCCV.Location = new System.Drawing.Point(124, 532);
            this.tbxCCV.Mask = "000";
            this.tbxCCV.Name = "tbxCCV";
            this.tbxCCV.Size = new System.Drawing.Size(44, 31);
            this.tbxCCV.TabIndex = 2;
            // 
            // lbFeedback
            // 
            this.lbFeedback.AutoSize = true;
            this.lbFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.ForeColor = System.Drawing.Color.White;
            this.lbFeedback.Location = new System.Drawing.Point(96, 624);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(93, 33);
            this.lbFeedback.TabIndex = 41;
            this.lbFeedback.Text = "label2";
            this.lbFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(22, 711);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 46);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(623, 576);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(162, 46);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check Code";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbDiscountFeedback
            // 
            this.lbDiscountFeedback.AutoSize = true;
            this.lbDiscountFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscountFeedback.ForeColor = System.Drawing.Color.White;
            this.lbDiscountFeedback.Location = new System.Drawing.Point(619, 536);
            this.lbDiscountFeedback.Name = "lbDiscountFeedback";
            this.lbDiscountFeedback.Size = new System.Drawing.Size(102, 37);
            this.lbDiscountFeedback.TabIndex = 44;
            this.lbDiscountFeedback.Text = "label2";
            this.lbDiscountFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.Location = new System.Drawing.Point(175, 711);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(175, 46);
            this.btnBackToMain.TabIndex = 7;
            this.btnBackToMain.Text = "Back to login form";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(881, 711);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(78, 46);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // hlpShopping
            // 
            this.hlpShopping.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\ShoppingCart.chm";
            // 
            // btnBackToShop
            // 
            this.btnBackToShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToShop.Location = new System.Drawing.Point(415, 711);
            this.btnBackToShop.Name = "btnBackToShop";
            this.btnBackToShop.Size = new System.Drawing.Size(175, 46);
            this.btnBackToShop.TabIndex = 8;
            this.btnBackToShop.Text = "Back to Shop";
            this.btnBackToShop.UseVisualStyleBackColor = true;
            this.btnBackToShop.Click += new System.EventHandler(this.btnBackToShop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Editing Section";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(6, 126);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(122, 24);
            this.lbQuantity.TabIndex = 50;
            this.lbQuantity.Text = "New Quantity\r\n";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNewQuantity
            // 
            this.cbNewQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.cbNewQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewQuantity.FormattingEnabled = true;
            this.cbNewQuantity.Location = new System.Drawing.Point(149, 123);
            this.cbNewQuantity.Name = "cbNewQuantity";
            this.cbNewQuantity.Size = new System.Drawing.Size(242, 32);
            this.cbNewQuantity.TabIndex = 20;
            this.cbNewQuantity.Click += new System.EventHandler(this.cbNewQuantity_Click);
            // 
            // bntConfirm
            // 
            this.bntConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConfirm.Location = new System.Drawing.Point(172, 184);
            this.bntConfirm.Name = "bntConfirm";
            this.bntConfirm.Size = new System.Drawing.Size(186, 46);
            this.bntConfirm.TabIndex = 21;
            this.bntConfirm.Text = "Confirm Update";
            this.bntConfirm.UseVisualStyleBackColor = true;
            this.bntConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(172, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 46);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbEditingName
            // 
            this.lbEditingName.AutoSize = true;
            this.lbEditingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditingName.Location = new System.Drawing.Point(145, 79);
            this.lbEditingName.Name = "lbEditingName";
            this.lbEditingName.Size = new System.Drawing.Size(114, 24);
            this.lbEditingName.TabIndex = 53;
            this.lbEditingName.Text = "PlaceHolder";
            // 
            // pEditing
            // 
            this.pEditing.Controls.Add(this.btnDelete);
            this.pEditing.Controls.Add(this.lbEditingName);
            this.pEditing.Controls.Add(this.lbQuantity);
            this.pEditing.Controls.Add(this.bntConfirm);
            this.pEditing.Controls.Add(this.label2);
            this.pEditing.Controls.Add(this.cbNewQuantity);
            this.pEditing.Enabled = false;
            this.pEditing.Location = new System.Drawing.Point(690, 83);
            this.pEditing.Name = "pEditing";
            this.pEditing.Size = new System.Drawing.Size(403, 326);
            this.pEditing.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Avalible Discounts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbDiscounts
            // 
            this.rtbDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDiscounts.Location = new System.Drawing.Point(20, 53);
            this.rtbDiscounts.Name = "rtbDiscounts";
            this.rtbDiscounts.ReadOnly = true;
            this.rtbDiscounts.Size = new System.Drawing.Size(218, 170);
            this.rtbDiscounts.TabIndex = 10000;
            this.rtbDiscounts.Text = "";
            // 
            // pDiscounts
            // 
            this.pDiscounts.Controls.Add(this.rtbDiscounts);
            this.pDiscounts.Controls.Add(this.label3);
            this.pDiscounts.Enabled = false;
            this.pDiscounts.Location = new System.Drawing.Point(815, 415);
            this.pDiscounts.Name = "pDiscounts";
            this.pDiscounts.Size = new System.Drawing.Size(254, 251);
            this.pDiscounts.TabIndex = 10001;
            this.pDiscounts.Visible = false;
            // 
            // hlpManager
            // 
            this.hlpManager.HelpNamespace = "C:\\Users\\josia\\OneDrive\\Desktop\\Help\\ShoppingCartManager.chm";
            // 
            // redeemLabel
            // 
            this.redeemLabel.AutoSize = true;
            this.redeemLabel.Enabled = false;
            this.redeemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redeemLabel.Location = new System.Drawing.Point(409, 409);
            this.redeemLabel.Name = "redeemLabel";
            this.redeemLabel.Size = new System.Drawing.Size(137, 72);
            this.redeemLabel.TabIndex = 10003;
            this.redeemLabel.Text = "Point redeem. \r\n100pt = $10\r\n$10 spent = 1pt";
            this.redeemLabel.Visible = false;
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Enabled = false;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.Location = new System.Drawing.Point(383, 487);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(110, 24);
            this.pointLabel.TabIndex = 10004;
            this.pointLabel.Text = "placeholder";
            this.pointLabel.Visible = false;
            // 
            // pointCfmBtn
            // 
            this.pointCfmBtn.Enabled = false;
            this.pointCfmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCfmBtn.Location = new System.Drawing.Point(375, 592);
            this.pointCfmBtn.Name = "pointCfmBtn";
            this.pointCfmBtn.Size = new System.Drawing.Size(225, 46);
            this.pointCfmBtn.TabIndex = 10005;
            this.pointCfmBtn.Text = "Confirm Point Discounts";
            this.pointCfmBtn.UseVisualStyleBackColor = true;
            this.pointCfmBtn.Visible = false;
            this.pointCfmBtn.Click += new System.EventHandler(this.pointCfmBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 10006;
            this.label4.Text = "Set to 0 or empty to clear";
            this.label4.Visible = false;
            // 
            // pointCheckerlb
            // 
            this.pointCheckerlb.AutoSize = true;
            this.pointCheckerlb.Enabled = false;
            this.pointCheckerlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCheckerlb.Location = new System.Drawing.Point(350, 648);
            this.pointCheckerlb.Name = "pointCheckerlb";
            this.pointCheckerlb.Size = new System.Drawing.Size(110, 24);
            this.pointCheckerlb.TabIndex = 10007;
            this.pointCheckerlb.Text = "placeholder";
            this.pointCheckerlb.Visible = false;
            // 
            // tbxPoints
            // 
            this.tbxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPoints.Location = new System.Drawing.Point(432, 537);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(114, 29);
            this.tbxPoints.TabIndex = 10008;
            this.tbxPoints.Visible = false;
            this.tbxPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPoints_KeyPress);
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1122, 769);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.pointCheckerlb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pointCfmBtn);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.redeemLabel);
            this.Controls.Add(this.pDiscounts);
            this.Controls.Add(this.pEditing);
            this.Controls.Add(this.btnBackToShop);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lbDiscountFeedback);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbFeedback);
            this.Controls.Add(this.tbxCCV);
            this.Controls.Add(this.lbStoreName);
            this.Controls.Add(this.btnCompletePurchase);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.tbxDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.tbxCreditCard);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbCCV);
            this.Controls.Add(this.lbCreditCard);
            this.Controls.Add(this.dtCart);
            this.Name = "frmShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShoppingCart_FormClosed);
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCart)).EndInit();
            this.pEditing.ResumeLayout(false);
            this.pEditing.PerformLayout();
            this.pDiscounts.ResumeLayout(false);
            this.pDiscounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCart;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxDate;
        private System.Windows.Forms.MaskedTextBox tbxCreditCard;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCCV;
        private System.Windows.Forms.Label lbCreditCard;
        private System.Windows.Forms.Button btnCompletePurchase;
        private System.Windows.Forms.Label lbStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
        private System.Windows.Forms.MaskedTextBox tbxCCV;
        private System.Windows.Forms.Label lbFeedback;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbDiscountFeedback;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.HelpProvider hlpShopping;
        private System.Windows.Forms.Button btnBackToShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ComboBox cbNewQuantity;
        private System.Windows.Forms.Button bntConfirm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbEditingName;
        private System.Windows.Forms.Panel pEditing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDiscounts;
        private System.Windows.Forms.Panel pDiscounts;
        private System.Windows.Forms.HelpProvider hlpManager;
        private System.Windows.Forms.Label redeemLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Button pointCfmBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pointCheckerlb;
        private System.Windows.Forms.TextBox tbxPoints;
    }
}