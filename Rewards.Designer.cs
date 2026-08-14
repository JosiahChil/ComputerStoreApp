namespace CompSoftwareMastery
{
    partial class frmRewards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRewards));
            this.termsAndconditionsRTB = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.acceptTaCcheck = new System.Windows.Forms.CheckBox();
            this.acceptEmailcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // termsAndconditionsRTB
            // 
            this.termsAndconditionsRTB.Location = new System.Drawing.Point(0, -1);
            this.termsAndconditionsRTB.Name = "termsAndconditionsRTB";
            this.termsAndconditionsRTB.Size = new System.Drawing.Size(796, 186);
            this.termsAndconditionsRTB.TabIndex = 0;
            this.termsAndconditionsRTB.Text = resources.GetString("termsAndconditionsRTB.Text");
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(78, 322);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(199, 41);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm and join rewards";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(420, 322);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(260, 41);
            this.btnDeny.TabIndex = 2;
            this.btnDeny.Text = "Deny and return to previous form";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // acceptTaCcheck
            // 
            this.acceptTaCcheck.AutoSize = true;
            this.acceptTaCcheck.Location = new System.Drawing.Point(264, 208);
            this.acceptTaCcheck.Name = "acceptTaCcheck";
            this.acceptTaCcheck.Size = new System.Drawing.Size(229, 24);
            this.acceptTaCcheck.TabIndex = 3;
            this.acceptTaCcheck.Text = "Accept terms and conditions";
            this.acceptTaCcheck.UseVisualStyleBackColor = true;
            this.acceptTaCcheck.CheckedChanged += new System.EventHandler(this.acceptTaCcheck_CheckedChanged);
            // 
            // acceptEmailcheck
            // 
            this.acceptEmailcheck.AutoSize = true;
            this.acceptEmailcheck.Location = new System.Drawing.Point(194, 255);
            this.acceptEmailcheck.Name = "acceptEmailcheck";
            this.acceptEmailcheck.Size = new System.Drawing.Size(406, 24);
            this.acceptEmailcheck.TabIndex = 4;
            this.acceptEmailcheck.Text = "Accept email advertisements, reminders, and updates";
            this.acceptEmailcheck.UseVisualStyleBackColor = true;
            this.acceptEmailcheck.CheckedChanged += new System.EventHandler(this.acceptEmailcheck_CheckedChanged);
            // 
            // frmRewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.acceptEmailcheck);
            this.Controls.Add(this.acceptTaCcheck);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.termsAndconditionsRTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRewards";
            this.Text = "Rewards";
            this.Load += new System.EventHandler(this.Rewards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox termsAndconditionsRTB;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.CheckBox acceptTaCcheck;
        private System.Windows.Forms.CheckBox acceptEmailcheck;
    }
}