namespace CompSoftwareMastery
{
    partial class frmManager
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
            this.btnInventoryReport = new System.Windows.Forms.Button();
            this.btnInventoryEdit = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDiscountEdit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.hlpManager = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventoryReport
            // 
            this.btnInventoryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryReport.Location = new System.Drawing.Point(45, 39);
            this.btnInventoryReport.Name = "btnInventoryReport";
            this.btnInventoryReport.Size = new System.Drawing.Size(192, 49);
            this.btnInventoryReport.TabIndex = 0;
            this.btnInventoryReport.Text = "Inventory Reports";
            this.btnInventoryReport.UseVisualStyleBackColor = true;
            this.btnInventoryReport.Click += new System.EventHandler(this.btnInventoryReport_Click_1);
            // 
            // btnInventoryEdit
            // 
            this.btnInventoryEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryEdit.Location = new System.Drawing.Point(45, 181);
            this.btnInventoryEdit.Name = "btnInventoryEdit";
            this.btnInventoryEdit.Size = new System.Drawing.Size(192, 49);
            this.btnInventoryEdit.TabIndex = 1;
            this.btnInventoryEdit.Text = "Inventory Editing";
            this.btnInventoryEdit.UseVisualStyleBackColor = true;
            this.btnInventoryEdit.Click += new System.EventHandler(this.btnInventoryEdit_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(45, 109);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(192, 49);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "Point of Sale";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(45, 255);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(192, 49);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Manage User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDiscountEdit
            // 
            this.btnDiscountEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountEdit.Location = new System.Drawing.Point(45, 325);
            this.btnDiscountEdit.Name = "btnDiscountEdit";
            this.btnDiscountEdit.Size = new System.Drawing.Size(192, 49);
            this.btnDiscountEdit.TabIndex = 4;
            this.btnDiscountEdit.Text = "Promo Editing";
            this.btnDiscountEdit.UseVisualStyleBackColor = true;
            this.btnDiscountEdit.Click += new System.EventHandler(this.btnDiscountEdit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(45, 393);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 49);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // hlpManager
            // 
            this.hlpManager.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\ManagerForm.chm";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(45, 457);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(192, 49);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(292, 522);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDiscountEdit);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnInventoryEdit);
            this.Controls.Add(this.btnInventoryReport);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManager_FormClosed);
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryReport;
        private System.Windows.Forms.Button btnInventoryEdit;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDiscountEdit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.HelpProvider hlpManager;
        private System.Windows.Forms.Button btnHelp;
    }
}