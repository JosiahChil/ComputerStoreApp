namespace CompSoftwareMastery
{
    partial class frmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUser));
            this.btnHelp = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.tbxSecondaryPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxZipcode = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbxThirdAnswer = new System.Windows.Forms.TextBox();
            this.lbThirdAnswer = new System.Windows.Forms.Label();
            this.tbxSecondAnswer = new System.Windows.Forms.TextBox();
            this.lbSecondAnswer = new System.Windows.Forms.Label();
            this.tbxFirstAnswer = new System.Windows.Forms.TextBox();
            this.lbFirstAnswer = new System.Windows.Forms.Label();
            this.lbThirdSecurity = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.cbDisable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.Button();
            this.fNameBox = new System.Windows.Forms.Button();
            this.stateBox = new System.Windows.Forms.Button();
            this.zipccodeBox = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.Button();
            this.cityBox = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.Button();
            this.cbThirdQuestion = new System.Windows.Forms.ComboBox();
            this.lbSecondSecurity = new System.Windows.Forms.Label();
            this.cbSecondQuestion = new System.Windows.Forms.ComboBox();
            this.lbFirstSecurity = new System.Windows.Forms.Label();
            this.tbxSecondAddress = new System.Windows.Forms.TextBox();
            this.lbSecondAddress = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSecondaryPhoneNumber = new System.Windows.Forms.Label();
            this.lbPrimaryPhone = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbZipcode = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.lbSuffix = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.cbFirstQuestion = new System.Windows.Forms.ComboBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.hlpAddUser = new System.Windows.Forms.HelpProvider();
            this.btnManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(1124, 652);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(182, 38);
            this.btnHelp.TabIndex = 189;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.Enabled = false;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Usernames must be unique and cannot be repeated for any other user",
            "Usernames Cannot begin with a number",
            "Usernames Cannot be less than 8 characters long",
            "Usernames Cannot be longer than 20 characters long",
            "Usernames Cannot contain special Characters",
            "Usernames Cannot contain, start with or end with spaces",
            "Password Cannot be less than 8 characters long",
            "Password Cannot be more than 20 charaters long",
            "Must have atleast 3 of the 4 following conditions. ",
            "Upper case characters (A through Z)",
            "Lower case characters (a through z)",
            "Numbers (0 through 9)",
            "Special characters ()!@#$%^&* No spaces allowed\"",
            "13",
            "First name must not be blank",
            "Last name must not be blank",
            "Address must not be blank",
            "City must not be blank",
            "Zipcode must not be blank and must be between 5 and 10 digits",
            "State must not be blank",
            "Email must not be blank",
            "Phone number must not be blank and must be 10 digits",
            "Security questions 1 - 3 must not be blank",
            "Answers 1 - 3 must not be blank"});
            this.checkedListBox.Location = new System.Drawing.Point(1333, 37);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(526, 498);
            this.checkedListBox.TabIndex = 188;
            // 
            // tbxSecondaryPhoneNumber
            // 
            this.tbxSecondaryPhoneNumber.Location = new System.Drawing.Point(1110, 143);
            this.tbxSecondaryPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSecondaryPhoneNumber.Name = "tbxSecondaryPhoneNumber";
            this.tbxSecondaryPhoneNumber.Size = new System.Drawing.Size(196, 31);
            this.tbxSecondaryPhoneNumber.TabIndex = 153;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(1001, 82);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(196, 31);
            this.tbxPhoneNumber.TabIndex = 152;
            this.tbxPhoneNumber.TextChanged += new System.EventHandler(this.tbxPhoneNumber_TextChanged);
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Location = new System.Drawing.Point(562, 204);
            this.tbxZipcode.Margin = new System.Windows.Forms.Padding(6);
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(196, 31);
            this.tbxZipcode.TabIndex = 149;
            this.tbxZipcode.TextChanged += new System.EventHandler(this.tbxZipcode_TextChanged);
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbState.Location = new System.Drawing.Point(562, 265);
            this.cbState.Margin = new System.Windows.Forms.Padding(6);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(196, 33);
            this.cbState.TabIndex = 177;
            this.cbState.TabStop = false;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(990, 244);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(196, 31);
            this.tbxPassword.TabIndex = 157;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(877, 244);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(106, 25);
            this.lbPassword.TabIndex = 176;
            this.lbPassword.Text = "Password";
            // 
            // tbxThirdAnswer
            // 
            this.tbxThirdAnswer.Location = new System.Drawing.Point(822, 709);
            this.tbxThirdAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxThirdAnswer.Name = "tbxThirdAnswer";
            this.tbxThirdAnswer.Size = new System.Drawing.Size(238, 31);
            this.tbxThirdAnswer.TabIndex = 162;
            this.tbxThirdAnswer.TextChanged += new System.EventHandler(this.tbxThirdAnswer_TextChanged);
            // 
            // lbThirdAnswer
            // 
            this.lbThirdAnswer.AutoSize = true;
            this.lbThirdAnswer.Location = new System.Drawing.Point(885, 665);
            this.lbThirdAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbThirdAnswer.Name = "lbThirdAnswer";
            this.lbThirdAnswer.Size = new System.Drawing.Size(101, 25);
            this.lbThirdAnswer.TabIndex = 175;
            this.lbThirdAnswer.Text = "Answer 3";
            // 
            // tbxSecondAnswer
            // 
            this.tbxSecondAnswer.Location = new System.Drawing.Point(481, 709);
            this.tbxSecondAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSecondAnswer.Name = "tbxSecondAnswer";
            this.tbxSecondAnswer.Size = new System.Drawing.Size(238, 31);
            this.tbxSecondAnswer.TabIndex = 160;
            this.tbxSecondAnswer.TextChanged += new System.EventHandler(this.tbxSecondAnswer_TextChanged);
            // 
            // lbSecondAnswer
            // 
            this.lbSecondAnswer.AutoSize = true;
            this.lbSecondAnswer.Location = new System.Drawing.Point(550, 665);
            this.lbSecondAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondAnswer.Name = "lbSecondAnswer";
            this.lbSecondAnswer.Size = new System.Drawing.Size(101, 25);
            this.lbSecondAnswer.TabIndex = 174;
            this.lbSecondAnswer.Text = "Answer 2";
            // 
            // tbxFirstAnswer
            // 
            this.tbxFirstAnswer.Location = new System.Drawing.Point(114, 709);
            this.tbxFirstAnswer.Margin = new System.Windows.Forms.Padding(6);
            this.tbxFirstAnswer.Name = "tbxFirstAnswer";
            this.tbxFirstAnswer.Size = new System.Drawing.Size(238, 31);
            this.tbxFirstAnswer.TabIndex = 158;
            this.tbxFirstAnswer.TextChanged += new System.EventHandler(this.tbxFirstAnswer_TextChanged);
            // 
            // lbFirstAnswer
            // 
            this.lbFirstAnswer.AutoSize = true;
            this.lbFirstAnswer.Location = new System.Drawing.Point(177, 665);
            this.lbFirstAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFirstAnswer.Name = "lbFirstAnswer";
            this.lbFirstAnswer.Size = new System.Drawing.Size(101, 25);
            this.lbFirstAnswer.TabIndex = 173;
            this.lbFirstAnswer.Text = "Answer 1";
            // 
            // lbThirdSecurity
            // 
            this.lbThirdSecurity.AutoSize = true;
            this.lbThirdSecurity.Location = new System.Drawing.Point(847, 541);
            this.lbThirdSecurity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbThirdSecurity.Name = "lbThirdSecurity";
            this.lbThirdSecurity.Size = new System.Drawing.Size(200, 25);
            this.lbThirdSecurity.TabIndex = 172;
            this.lbThirdSecurity.Text = "Security Question 3";
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Manager"});
            this.cbPosition.Location = new System.Drawing.Point(1012, 344);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(6);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(196, 33);
            this.cbPosition.TabIndex = 195;
            this.cbPosition.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(920, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 194;
            this.label3.Text = "Position";
            // 
            // cbDelete
            // 
            this.cbDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbDelete.Location = new System.Drawing.Point(664, 344);
            this.cbDelete.Margin = new System.Windows.Forms.Padding(6);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(196, 33);
            this.cbDelete.TabIndex = 193;
            this.cbDelete.TabStop = false;
            // 
            // cbDisable
            // 
            this.cbDisable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisable.FormattingEnabled = true;
            this.cbDisable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbDisable.Location = new System.Drawing.Point(253, 341);
            this.cbDisable.Margin = new System.Windows.Forms.Padding(6);
            this.cbDisable.Name = "cbDisable";
            this.cbDisable.Size = new System.Drawing.Size(196, 33);
            this.cbDisable.TabIndex = 192;
            this.cbDisable.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 191;
            this.label2.Text = "Delete Account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 190;
            this.label1.Text = "Disable account?";
            // 
            // lNameBox
            // 
            this.lNameBox.Enabled = false;
            this.lNameBox.Image = ((System.Drawing.Image)(resources.GetObject("lNameBox.Image")));
            this.lNameBox.Location = new System.Drawing.Point(376, 196);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(49, 34);
            this.lNameBox.TabIndex = 187;
            this.lNameBox.TabStop = false;
            this.lNameBox.UseVisualStyleBackColor = true;
            // 
            // fNameBox
            // 
            this.fNameBox.Enabled = false;
            this.fNameBox.Image = ((System.Drawing.Image)(resources.GetObject("fNameBox.Image")));
            this.fNameBox.Location = new System.Drawing.Point(376, 85);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(49, 34);
            this.fNameBox.TabIndex = 186;
            this.fNameBox.TabStop = false;
            this.fNameBox.UseVisualStyleBackColor = true;
            // 
            // stateBox
            // 
            this.stateBox.Enabled = false;
            this.stateBox.Image = global::CompSoftwareMastery.Properties.Resources.XMark;
            this.stateBox.Location = new System.Drawing.Point(767, 265);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(49, 34);
            this.stateBox.TabIndex = 185;
            this.stateBox.TabStop = false;
            this.stateBox.UseVisualStyleBackColor = true;
            // 
            // zipccodeBox
            // 
            this.zipccodeBox.Enabled = false;
            this.zipccodeBox.Image = ((System.Drawing.Image)(resources.GetObject("zipccodeBox.Image")));
            this.zipccodeBox.Location = new System.Drawing.Point(767, 205);
            this.zipccodeBox.Name = "zipccodeBox";
            this.zipccodeBox.Size = new System.Drawing.Size(49, 34);
            this.zipccodeBox.TabIndex = 184;
            this.zipccodeBox.TabStop = false;
            this.zipccodeBox.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Enabled = false;
            this.addressBox.Image = ((System.Drawing.Image)(resources.GetObject("addressBox.Image")));
            this.addressBox.Location = new System.Drawing.Point(767, 34);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(49, 34);
            this.addressBox.TabIndex = 183;
            this.addressBox.TabStop = false;
            this.addressBox.UseVisualStyleBackColor = true;
            // 
            // cityBox
            // 
            this.cityBox.Enabled = false;
            this.cityBox.Image = ((System.Drawing.Image)(resources.GetObject("cityBox.Image")));
            this.cityBox.Location = new System.Drawing.Point(767, 149);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(49, 34);
            this.cityBox.TabIndex = 182;
            this.cityBox.TabStop = false;
            this.cityBox.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Enabled = false;
            this.passwordBox.Image = ((System.Drawing.Image)(resources.GetObject("passwordBox.Image")));
            this.passwordBox.Location = new System.Drawing.Point(1195, 244);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(49, 34);
            this.passwordBox.TabIndex = 181;
            this.passwordBox.TabStop = false;
            this.passwordBox.UseVisualStyleBackColor = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Enabled = false;
            this.usernameBox.Image = ((System.Drawing.Image)(resources.GetObject("usernameBox.Image")));
            this.usernameBox.Location = new System.Drawing.Point(1195, 193);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(49, 34);
            this.usernameBox.TabIndex = 180;
            this.usernameBox.TabStop = false;
            this.usernameBox.UseVisualStyleBackColor = true;
            // 
            // phoneBox
            // 
            this.phoneBox.Enabled = false;
            this.phoneBox.Image = ((System.Drawing.Image)(resources.GetObject("phoneBox.Image")));
            this.phoneBox.Location = new System.Drawing.Point(1206, 79);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(49, 34);
            this.phoneBox.TabIndex = 179;
            this.phoneBox.TabStop = false;
            this.phoneBox.UseVisualStyleBackColor = true;
            // 
            // emailBox
            // 
            this.emailBox.Enabled = false;
            this.emailBox.Image = ((System.Drawing.Image)(resources.GetObject("emailBox.Image")));
            this.emailBox.Location = new System.Drawing.Point(1195, 33);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(49, 34);
            this.emailBox.TabIndex = 178;
            this.emailBox.TabStop = false;
            this.emailBox.UseVisualStyleBackColor = true;
            // 
            // cbThirdQuestion
            // 
            this.cbThirdQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThirdQuestion.FormattingEnabled = true;
            this.cbThirdQuestion.Location = new System.Drawing.Point(802, 586);
            this.cbThirdQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.cbThirdQuestion.Name = "cbThirdQuestion";
            this.cbThirdQuestion.Size = new System.Drawing.Size(307, 33);
            this.cbThirdQuestion.TabIndex = 171;
            this.cbThirdQuestion.TabStop = false;
            this.cbThirdQuestion.SelectedIndexChanged += new System.EventHandler(this.cbThirdQuestion_SelectedIndexChanged);
            // 
            // lbSecondSecurity
            // 
            this.lbSecondSecurity.AutoSize = true;
            this.lbSecondSecurity.Location = new System.Drawing.Point(507, 541);
            this.lbSecondSecurity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondSecurity.Name = "lbSecondSecurity";
            this.lbSecondSecurity.Size = new System.Drawing.Size(200, 25);
            this.lbSecondSecurity.TabIndex = 170;
            this.lbSecondSecurity.Text = "Security Question 2";
            // 
            // cbSecondQuestion
            // 
            this.cbSecondQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecondQuestion.FormattingEnabled = true;
            this.cbSecondQuestion.Location = new System.Drawing.Point(452, 586);
            this.cbSecondQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.cbSecondQuestion.Name = "cbSecondQuestion";
            this.cbSecondQuestion.Size = new System.Drawing.Size(322, 33);
            this.cbSecondQuestion.TabIndex = 169;
            this.cbSecondQuestion.TabStop = false;
            this.cbSecondQuestion.SelectedIndexChanged += new System.EventHandler(this.cbSecondQuestion_SelectedIndexChanged);
            // 
            // lbFirstSecurity
            // 
            this.lbFirstSecurity.AutoSize = true;
            this.lbFirstSecurity.Location = new System.Drawing.Point(139, 541);
            this.lbFirstSecurity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFirstSecurity.Name = "lbFirstSecurity";
            this.lbFirstSecurity.Size = new System.Drawing.Size(200, 25);
            this.lbFirstSecurity.TabIndex = 168;
            this.lbFirstSecurity.Text = "Security Question 1";
            // 
            // tbxSecondAddress
            // 
            this.tbxSecondAddress.Location = new System.Drawing.Point(562, 85);
            this.tbxSecondAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSecondAddress.Name = "tbxSecondAddress";
            this.tbxSecondAddress.Size = new System.Drawing.Size(196, 31);
            this.tbxSecondAddress.TabIndex = 146;
            // 
            // lbSecondAddress
            // 
            this.lbSecondAddress.AutoSize = true;
            this.lbSecondAddress.Location = new System.Drawing.Point(435, 88);
            this.lbSecondAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondAddress.Name = "lbSecondAddress";
            this.lbSecondAddress.Size = new System.Drawing.Size(121, 25);
            this.lbSecondAddress.TabIndex = 167;
            this.lbSecondAddress.Text = "Address #2";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(171, 30);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(6);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(196, 31);
            this.tbxTitle.TabIndex = 136;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(94, 30);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(53, 25);
            this.lbTitle.TabIndex = 166;
            this.lbTitle.Text = "Title";
            // 
            // lbSecondaryPhoneNumber
            // 
            this.lbSecondaryPhoneNumber.AutoSize = true;
            this.lbSecondaryPhoneNumber.Location = new System.Drawing.Point(834, 146);
            this.lbSecondaryPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSecondaryPhoneNumber.Name = "lbSecondaryPhoneNumber";
            this.lbSecondaryPhoneNumber.Size = new System.Drawing.Size(264, 25);
            this.lbSecondaryPhoneNumber.TabIndex = 165;
            this.lbSecondaryPhoneNumber.Text = "Secondary Phone Number";
            // 
            // lbPrimaryPhone
            // 
            this.lbPrimaryPhone.AutoSize = true;
            this.lbPrimaryPhone.Location = new System.Drawing.Point(834, 85);
            this.lbPrimaryPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrimaryPhone.Name = "lbPrimaryPhone";
            this.lbPrimaryPhone.Size = new System.Drawing.Size(155, 25);
            this.lbPrimaryPhone.TabIndex = 164;
            this.lbPrimaryPhone.Text = "Phone Number";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(990, 33);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(196, 31);
            this.tbxEmail.TabIndex = 150;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(913, 36);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(65, 25);
            this.lbEmail.TabIndex = 163;
            this.lbEmail.Text = "Email";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(478, 267);
            this.lbState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(62, 25);
            this.lbState.TabIndex = 161;
            this.lbState.Text = "State";
            // 
            // lbZipcode
            // 
            this.lbZipcode.AutoSize = true;
            this.lbZipcode.Location = new System.Drawing.Point(451, 210);
            this.lbZipcode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbZipcode.Name = "lbZipcode";
            this.lbZipcode.Size = new System.Drawing.Size(89, 25);
            this.lbZipcode.TabIndex = 159;
            this.lbZipcode.Text = "Zipcode";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(990, 195);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(196, 31);
            this.tbxUsername.TabIndex = 155;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(877, 195);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(110, 25);
            this.lbUsername.TabIndex = 156;
            this.lbUsername.Text = "Username";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(562, 149);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(6);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(196, 31);
            this.tbxCity.TabIndex = 148;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(491, 149);
            this.lbCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(49, 25);
            this.lbCity.TabIndex = 154;
            this.lbCity.Text = "City";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(562, 36);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(196, 31);
            this.tbxAddress.TabIndex = 145;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(449, 36);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(91, 25);
            this.lbAddress.TabIndex = 151;
            this.lbAddress.Text = "Address";
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.Location = new System.Drawing.Point(171, 262);
            this.tbxSuffix.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.Size = new System.Drawing.Size(196, 31);
            this.tbxSuffix.TabIndex = 143;
            // 
            // lbSuffix
            // 
            this.lbSuffix.AutoSize = true;
            this.lbSuffix.Location = new System.Drawing.Point(94, 264);
            this.lbSuffix.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSuffix.Name = "lbSuffix";
            this.lbSuffix.Size = new System.Drawing.Size(66, 25);
            this.lbSuffix.TabIndex = 147;
            this.lbSuffix.Text = "Suffix";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(171, 198);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(196, 31);
            this.tbxLastName.TabIndex = 141;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(45, 201);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(115, 25);
            this.lbLastName.TabIndex = 144;
            this.lbLastName.Text = "Last Name";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(171, 143);
            this.tbxMiddleName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(196, 31);
            this.tbxMiddleName.TabIndex = 139;
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(22, 146);
            this.lbMiddleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(138, 25);
            this.lbMiddleName.TabIndex = 142;
            this.lbMiddleName.Text = "Middle Name";
            // 
            // cbFirstQuestion
            // 
            this.cbFirstQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirstQuestion.FormattingEnabled = true;
            this.cbFirstQuestion.Location = new System.Drawing.Point(89, 586);
            this.cbFirstQuestion.Margin = new System.Windows.Forms.Padding(6);
            this.cbFirstQuestion.Name = "cbFirstQuestion";
            this.cbFirstQuestion.Size = new System.Drawing.Size(299, 33);
            this.cbFirstQuestion.TabIndex = 140;
            this.cbFirstQuestion.TabStop = false;
            this.cbFirstQuestion.TextChanged += new System.EventHandler(this.cbFirstQuestion_TextChanged);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(171, 85);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(196, 31);
            this.tbxFirstName.TabIndex = 138;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(44, 85);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(116, 25);
            this.lbFirstName.TabIndex = 137;
            this.lbFirstName.Text = "First Name";
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Enabled = false;
            this.btnAddNewAccount.Location = new System.Drawing.Point(1124, 709);
            this.btnAddNewAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(182, 44);
            this.btnAddNewAccount.TabIndex = 135;
            this.btnAddNewAccount.Text = "Add Account";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // hlpAddUser
            // 
            this.hlpAddUser.HelpNamespace = "C:\\Program Files (x86)\\TSTC\\CompSoftwareWizard\\Help\\AddUserForm.chm";
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(1333, 709);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(243, 44);
            this.btnManager.TabIndex = 196;
            this.btnManager.Text = "Back to manager menu";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1881, 783);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.tbxSecondaryPhoneNumber);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.tbxZipcode);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbxThirdAnswer);
            this.Controls.Add(this.lbThirdAnswer);
            this.Controls.Add(this.tbxSecondAnswer);
            this.Controls.Add(this.lbSecondAnswer);
            this.Controls.Add(this.tbxFirstAnswer);
            this.Controls.Add(this.lbFirstAnswer);
            this.Controls.Add(this.lbThirdSecurity);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbDisable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.zipccodeBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.cbThirdQuestion);
            this.Controls.Add(this.lbSecondSecurity);
            this.Controls.Add(this.cbSecondQuestion);
            this.Controls.Add(this.lbFirstSecurity);
            this.Controls.Add(this.tbxSecondAddress);
            this.Controls.Add(this.lbSecondAddress);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbSecondaryPhoneNumber);
            this.Controls.Add(this.lbPrimaryPhone);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbZipcode);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbxSuffix);
            this.Controls.Add(this.lbSuffix);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.cbFirstQuestion);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.btnAddNewAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.TextBox tbxSecondaryPhoneNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxZipcode;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbxThirdAnswer;
        private System.Windows.Forms.Label lbThirdAnswer;
        private System.Windows.Forms.TextBox tbxSecondAnswer;
        private System.Windows.Forms.Label lbSecondAnswer;
        private System.Windows.Forms.TextBox tbxFirstAnswer;
        private System.Windows.Forms.Label lbFirstAnswer;
        private System.Windows.Forms.Label lbThirdSecurity;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.ComboBox cbDisable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lNameBox;
        private System.Windows.Forms.Button fNameBox;
        private System.Windows.Forms.Button stateBox;
        private System.Windows.Forms.Button zipccodeBox;
        private System.Windows.Forms.Button addressBox;
        private System.Windows.Forms.Button cityBox;
        private System.Windows.Forms.Button passwordBox;
        private System.Windows.Forms.Button usernameBox;
        private System.Windows.Forms.Button phoneBox;
        private System.Windows.Forms.Button emailBox;
        private System.Windows.Forms.ComboBox cbThirdQuestion;
        private System.Windows.Forms.Label lbSecondSecurity;
        private System.Windows.Forms.ComboBox cbSecondQuestion;
        private System.Windows.Forms.Label lbFirstSecurity;
        private System.Windows.Forms.TextBox tbxSecondAddress;
        private System.Windows.Forms.Label lbSecondAddress;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSecondaryPhoneNumber;
        private System.Windows.Forms.Label lbPrimaryPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbZipcode;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.Label lbSuffix;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.ComboBox cbFirstQuestion;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.HelpProvider hlpAddUser;
        private System.Windows.Forms.Button btnManager;
    }
}