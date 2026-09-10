namespace System_Support_Project.Donation
{
    partial class DonationViewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label donation_IDLabel;
            System.Windows.Forms.Label alumni_IDLabel;
            System.Windows.Forms.Label account_NumberLabel;
            System.Windows.Forms.Label donation_DateLabel;
            System.Windows.Forms.Label donation_AmountLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label record_IDLabel;
            System.Windows.Forms.Label account_NumberLabel1;
            System.Windows.Forms.Label account_NameLabel;
            System.Windows.Forms.Label parent_NumberLabel;
            System.Windows.Forms.Label active_Label;
            System.Windows.Forms.Label alumni_IDLabel1;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label mobile_PhoneLabel;
            System.Windows.Forms.Label home_PhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zip_CodeLabel;
            System.Windows.Forms.Label active_Label1;
            System.Windows.Forms.Label notesLabel1;
            System.Windows.Forms.Label stateLabel;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.alumniTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter();
            this.donation_IDTextBox = new System.Windows.Forms.TextBox();
            this.alumni_IDTextBox = new System.Windows.Forms.TextBox();
            this.account_NumberTextBox = new System.Windows.Forms.TextBox();
            this.donation_DateTextBox = new System.Windows.Forms.TextBox();
            this.donation_AmountTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.record_IDTextBox = new System.Windows.Forms.TextBox();
            this.account_NumberTextBox1 = new System.Windows.Forms.TextBox();
            this.account_NameTextBox = new System.Windows.Forms.TextBox();
            this.parent_NumberTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.alumniLabel = new System.Windows.Forms.Label();
            this.alumni_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.mobile_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.home_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zip_CodeTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox1 = new System.Windows.Forms.CheckBox();
            this.notesTextBox1 = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            donation_IDLabel = new System.Windows.Forms.Label();
            alumni_IDLabel = new System.Windows.Forms.Label();
            account_NumberLabel = new System.Windows.Forms.Label();
            donation_DateLabel = new System.Windows.Forms.Label();
            donation_AmountLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            record_IDLabel = new System.Windows.Forms.Label();
            account_NumberLabel1 = new System.Windows.Forms.Label();
            account_NameLabel = new System.Windows.Forms.Label();
            parent_NumberLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            alumni_IDLabel1 = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            mobile_PhoneLabel = new System.Windows.Forms.Label();
            home_PhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zip_CodeLabel = new System.Windows.Forms.Label();
            active_Label1 = new System.Windows.Forms.Label();
            notesLabel1 = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // donation_IDLabel
            // 
            donation_IDLabel.AutoSize = true;
            donation_IDLabel.Location = new System.Drawing.Point(12, 30);
            donation_IDLabel.Name = "donation_IDLabel";
            donation_IDLabel.Size = new System.Drawing.Size(67, 13);
            donation_IDLabel.TabIndex = 1;
            donation_IDLabel.Text = "Donation ID:";
            // 
            // alumni_IDLabel
            // 
            alumni_IDLabel.AutoSize = true;
            alumni_IDLabel.Location = new System.Drawing.Point(12, 56);
            alumni_IDLabel.Name = "alumni_IDLabel";
            alumni_IDLabel.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel.TabIndex = 3;
            alumni_IDLabel.Text = "Alumni ID:";
            // 
            // account_NumberLabel
            // 
            account_NumberLabel.AutoSize = true;
            account_NumberLabel.Location = new System.Drawing.Point(12, 82);
            account_NumberLabel.Name = "account_NumberLabel";
            account_NumberLabel.Size = new System.Drawing.Size(90, 13);
            account_NumberLabel.TabIndex = 5;
            account_NumberLabel.Text = "Account Number:";
            // 
            // donation_DateLabel
            // 
            donation_DateLabel.AutoSize = true;
            donation_DateLabel.Location = new System.Drawing.Point(12, 108);
            donation_DateLabel.Name = "donation_DateLabel";
            donation_DateLabel.Size = new System.Drawing.Size(79, 13);
            donation_DateLabel.TabIndex = 7;
            donation_DateLabel.Text = "Donation Date:";
            // 
            // donation_AmountLabel
            // 
            donation_AmountLabel.AutoSize = true;
            donation_AmountLabel.Location = new System.Drawing.Point(12, 134);
            donation_AmountLabel.Name = "donation_AmountLabel";
            donation_AmountLabel.Size = new System.Drawing.Size(92, 13);
            donation_AmountLabel.TabIndex = 9;
            donation_AmountLabel.Text = "Donation Amount:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(12, 160);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Notes:";
            // 
            // record_IDLabel
            // 
            record_IDLabel.AutoSize = true;
            record_IDLabel.Location = new System.Drawing.Point(361, 30);
            record_IDLabel.Name = "record_IDLabel";
            record_IDLabel.Size = new System.Drawing.Size(59, 13);
            record_IDLabel.TabIndex = 14;
            record_IDLabel.Text = "Record ID:";
            // 
            // account_NumberLabel1
            // 
            account_NumberLabel1.AutoSize = true;
            account_NumberLabel1.Location = new System.Drawing.Point(361, 56);
            account_NumberLabel1.Name = "account_NumberLabel1";
            account_NumberLabel1.Size = new System.Drawing.Size(90, 13);
            account_NumberLabel1.TabIndex = 16;
            account_NumberLabel1.Text = "Account Number:";
            // 
            // account_NameLabel
            // 
            account_NameLabel.AutoSize = true;
            account_NameLabel.Location = new System.Drawing.Point(361, 82);
            account_NameLabel.Name = "account_NameLabel";
            account_NameLabel.Size = new System.Drawing.Size(81, 13);
            account_NameLabel.TabIndex = 18;
            account_NameLabel.Text = "Account Name:";
            // 
            // parent_NumberLabel
            // 
            parent_NumberLabel.AutoSize = true;
            parent_NumberLabel.Location = new System.Drawing.Point(361, 108);
            parent_NumberLabel.Name = "parent_NumberLabel";
            parent_NumberLabel.Size = new System.Drawing.Size(81, 13);
            parent_NumberLabel.TabIndex = 20;
            parent_NumberLabel.Text = "Parent Number:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(361, 136);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(46, 13);
            active_Label.TabIndex = 22;
            active_Label.Text = "Active?:";
            // 
            // alumni_IDLabel1
            // 
            alumni_IDLabel1.AutoSize = true;
            alumni_IDLabel1.Location = new System.Drawing.Point(661, 27);
            alumni_IDLabel1.Name = "alumni_IDLabel1";
            alumni_IDLabel1.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel1.TabIndex = 25;
            alumni_IDLabel1.Text = "Alumni ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(661, 53);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 27;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(661, 79);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 29;
            last_NameLabel.Text = "Last Name:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(661, 105);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 31;
            titleLabel.Text = "Title:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(661, 209);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 33;
            streetLabel.Text = "Street:";
            // 
            // mobile_PhoneLabel
            // 
            mobile_PhoneLabel.AutoSize = true;
            mobile_PhoneLabel.Location = new System.Drawing.Point(661, 131);
            mobile_PhoneLabel.Name = "mobile_PhoneLabel";
            mobile_PhoneLabel.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel.TabIndex = 35;
            mobile_PhoneLabel.Text = "Mobile Phone:";
            // 
            // home_PhoneLabel
            // 
            home_PhoneLabel.AutoSize = true;
            home_PhoneLabel.Location = new System.Drawing.Point(661, 157);
            home_PhoneLabel.Name = "home_PhoneLabel";
            home_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel.TabIndex = 37;
            home_PhoneLabel.Text = "Home Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(661, 183);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 39;
            emailLabel.Text = "Email:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(661, 261);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 41;
            cityLabel.Text = "City:";
            // 
            // zip_CodeLabel
            // 
            zip_CodeLabel.AutoSize = true;
            zip_CodeLabel.Location = new System.Drawing.Point(661, 235);
            zip_CodeLabel.Name = "zip_CodeLabel";
            zip_CodeLabel.Size = new System.Drawing.Size(53, 13);
            zip_CodeLabel.TabIndex = 43;
            zip_CodeLabel.Text = "Zip Code:";
            // 
            // active_Label1
            // 
            active_Label1.AutoSize = true;
            active_Label1.Location = new System.Drawing.Point(661, 315);
            active_Label1.Name = "active_Label1";
            active_Label1.Size = new System.Drawing.Size(46, 13);
            active_Label1.TabIndex = 45;
            active_Label1.Text = "Active?:";
            // 
            // notesLabel1
            // 
            notesLabel1.AutoSize = true;
            notesLabel1.Location = new System.Drawing.Point(661, 343);
            notesLabel1.Name = "notesLabel1";
            notesLabel1.Size = new System.Drawing.Size(38, 13);
            notesLabel1.TabIndex = 47;
            notesLabel1.Text = "Notes:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(661, 287);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 49;
            stateLabel.Text = "State:";
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "Donation";
            this.donationBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.AlumniTableAdapter = this.alumniTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonationTableAdapter = this.donationTableAdapter;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // alumniTableAdapter
            // 
            this.alumniTableAdapter.ClearBeforeFill = true;
            // 
            // donation_IDTextBox
            // 
            this.donation_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Donation_ID", true));
            this.donation_IDTextBox.Location = new System.Drawing.Point(110, 27);
            this.donation_IDTextBox.Name = "donation_IDTextBox";
            this.donation_IDTextBox.ReadOnly = true;
            this.donation_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.donation_IDTextBox.TabIndex = 2;
            // 
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(110, 53);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.ReadOnly = true;
            this.alumni_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.alumni_IDTextBox.TabIndex = 4;
            // 
            // account_NumberTextBox
            // 
            this.account_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Account_Number", true));
            this.account_NumberTextBox.Location = new System.Drawing.Point(110, 79);
            this.account_NumberTextBox.Name = "account_NumberTextBox";
            this.account_NumberTextBox.ReadOnly = true;
            this.account_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.account_NumberTextBox.TabIndex = 6;
            // 
            // donation_DateTextBox
            // 
            this.donation_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Donation_Date", true));
            this.donation_DateTextBox.Location = new System.Drawing.Point(110, 105);
            this.donation_DateTextBox.Name = "donation_DateTextBox";
            this.donation_DateTextBox.ReadOnly = true;
            this.donation_DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.donation_DateTextBox.TabIndex = 8;
            // 
            // donation_AmountTextBox
            // 
            this.donation_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Donation_Amount", true));
            this.donation_AmountTextBox.Location = new System.Drawing.Point(110, 131);
            this.donation_AmountTextBox.Name = "donation_AmountTextBox";
            this.donation_AmountTextBox.ReadOnly = true;
            this.donation_AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.donation_AmountTextBox.TabIndex = 10;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donationBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(110, 157);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox.TabIndex = 12;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // alumniBindingSource
            // 
            this.alumniBindingSource.DataMember = "Alumni";
            this.alumniBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // record_IDTextBox
            // 
            this.record_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Record_ID", true));
            this.record_IDTextBox.Location = new System.Drawing.Point(457, 27);
            this.record_IDTextBox.Name = "record_IDTextBox";
            this.record_IDTextBox.ReadOnly = true;
            this.record_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.record_IDTextBox.TabIndex = 15;
            // 
            // account_NumberTextBox1
            // 
            this.account_NumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Number", true));
            this.account_NumberTextBox1.Location = new System.Drawing.Point(457, 53);
            this.account_NumberTextBox1.Name = "account_NumberTextBox1";
            this.account_NumberTextBox1.ReadOnly = true;
            this.account_NumberTextBox1.Size = new System.Drawing.Size(104, 20);
            this.account_NumberTextBox1.TabIndex = 17;
            // 
            // account_NameTextBox
            // 
            this.account_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Account_Name", true));
            this.account_NameTextBox.Location = new System.Drawing.Point(457, 79);
            this.account_NameTextBox.Name = "account_NameTextBox";
            this.account_NameTextBox.ReadOnly = true;
            this.account_NameTextBox.Size = new System.Drawing.Size(183, 20);
            this.account_NameTextBox.TabIndex = 19;
            // 
            // parent_NumberTextBox
            // 
            this.parent_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "Parent_Number", true));
            this.parent_NumberTextBox.Location = new System.Drawing.Point(457, 105);
            this.parent_NumberTextBox.Name = "parent_NumberTextBox";
            this.parent_NumberTextBox.ReadOnly = true;
            this.parent_NumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.parent_NumberTextBox.TabIndex = 21;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accountBindingSource, "Active?", true));
            this.active_CheckBox.Enabled = false;
            this.active_CheckBox.Location = new System.Drawing.Point(457, 131);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 23;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(361, 3);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(178, 13);
            this.accountLabel.TabIndex = 24;
            this.accountLabel.Text = "Account connected to this Donation";
            // 
            // alumniLabel
            // 
            this.alumniLabel.AutoSize = true;
            this.alumniLabel.Location = new System.Drawing.Point(661, 3);
            this.alumniLabel.Name = "alumniLabel";
            this.alumniLabel.Size = new System.Drawing.Size(169, 13);
            this.alumniLabel.TabIndex = 25;
            this.alumniLabel.Text = "Alumni connected to this Donation";
            // 
            // alumni_IDTextBox1
            // 
            this.alumni_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox1.Location = new System.Drawing.Point(742, 24);
            this.alumni_IDTextBox1.Name = "alumni_IDTextBox1";
            this.alumni_IDTextBox1.ReadOnly = true;
            this.alumni_IDTextBox1.Size = new System.Drawing.Size(104, 20);
            this.alumni_IDTextBox1.TabIndex = 26;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(742, 50);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ReadOnly = true;
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 28;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(742, 76);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.ReadOnly = true;
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 30;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(742, 102);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox.TabIndex = 32;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(742, 206);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(130, 20);
            this.streetTextBox.TabIndex = 34;
            // 
            // mobile_PhoneTextBox
            // 
            this.mobile_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Mobile_Phone", true));
            this.mobile_PhoneTextBox.Location = new System.Drawing.Point(742, 128);
            this.mobile_PhoneTextBox.Name = "mobile_PhoneTextBox";
            this.mobile_PhoneTextBox.ReadOnly = true;
            this.mobile_PhoneTextBox.Size = new System.Drawing.Size(81, 20);
            this.mobile_PhoneTextBox.TabIndex = 36;
            // 
            // home_PhoneTextBox
            // 
            this.home_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Home_Phone", true));
            this.home_PhoneTextBox.Location = new System.Drawing.Point(742, 154);
            this.home_PhoneTextBox.Name = "home_PhoneTextBox";
            this.home_PhoneTextBox.ReadOnly = true;
            this.home_PhoneTextBox.Size = new System.Drawing.Size(81, 20);
            this.home_PhoneTextBox.TabIndex = 38;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(742, 180);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(130, 20);
            this.emailTextBox.TabIndex = 40;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(742, 258);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(104, 20);
            this.cityTextBox.TabIndex = 42;
            // 
            // zip_CodeTextBox
            // 
            this.zip_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Zip_Code", true));
            this.zip_CodeTextBox.Location = new System.Drawing.Point(742, 232);
            this.zip_CodeTextBox.Name = "zip_CodeTextBox";
            this.zip_CodeTextBox.ReadOnly = true;
            this.zip_CodeTextBox.Size = new System.Drawing.Size(37, 20);
            this.zip_CodeTextBox.TabIndex = 44;
            // 
            // active_CheckBox1
            // 
            this.active_CheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.active_CheckBox1.Enabled = false;
            this.active_CheckBox1.Location = new System.Drawing.Point(742, 310);
            this.active_CheckBox1.Name = "active_CheckBox1";
            this.active_CheckBox1.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox1.TabIndex = 46;
            this.active_CheckBox1.UseVisualStyleBackColor = true;
            // 
            // notesTextBox1
            // 
            this.notesTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Notes", true));
            this.notesTextBox1.Location = new System.Drawing.Point(742, 340);
            this.notesTextBox1.Multiline = true;
            this.notesTextBox1.Name = "notesTextBox1";
            this.notesTextBox1.ReadOnly = true;
            this.notesTextBox1.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox1.TabIndex = 48;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(742, 284);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(30, 20);
            this.stateTextBox.TabIndex = 50;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(184, 392);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 51;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DonationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 503);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(alumni_IDLabel1);
            this.Controls.Add(this.alumni_IDTextBox1);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(mobile_PhoneLabel);
            this.Controls.Add(this.mobile_PhoneTextBox);
            this.Controls.Add(home_PhoneLabel);
            this.Controls.Add(this.home_PhoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(zip_CodeLabel);
            this.Controls.Add(this.zip_CodeTextBox);
            this.Controls.Add(active_Label1);
            this.Controls.Add(this.active_CheckBox1);
            this.Controls.Add(notesLabel1);
            this.Controls.Add(this.notesTextBox1);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.alumniLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(record_IDLabel);
            this.Controls.Add(this.record_IDTextBox);
            this.Controls.Add(account_NumberLabel1);
            this.Controls.Add(this.account_NumberTextBox1);
            this.Controls.Add(account_NameLabel);
            this.Controls.Add(this.account_NameTextBox);
            this.Controls.Add(parent_NumberLabel);
            this.Controls.Add(this.parent_NumberTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Controls.Add(donation_IDLabel);
            this.Controls.Add(this.donation_IDTextBox);
            this.Controls.Add(alumni_IDLabel);
            this.Controls.Add(this.alumni_IDTextBox);
            this.Controls.Add(account_NumberLabel);
            this.Controls.Add(this.account_NumberTextBox);
            this.Controls.Add(donation_DateLabel);
            this.Controls.Add(this.donation_DateTextBox);
            this.Controls.Add(donation_AmountLabel);
            this.Controls.Add(this.donation_AmountTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Name = "DonationViewForm";
            this.Text = "View a Donation record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonationViewForm_FormClosing);
            this.Load += new System.EventHandler(this.DonationViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter donationTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox donation_IDTextBox;
        private System.Windows.Forms.TextBox alumni_IDTextBox;
        private System.Windows.Forms.TextBox account_NumberTextBox;
        private System.Windows.Forms.TextBox donation_DateTextBox;
        private System.Windows.Forms.TextBox donation_AmountTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter alumniTableAdapter;
        private System.Windows.Forms.BindingSource alumniBindingSource;
        private System.Windows.Forms.TextBox record_IDTextBox;
        private System.Windows.Forms.TextBox account_NumberTextBox1;
        private System.Windows.Forms.TextBox account_NameTextBox;
        private System.Windows.Forms.TextBox parent_NumberTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label alumniLabel;
        private System.Windows.Forms.TextBox alumni_IDTextBox1;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox mobile_PhoneTextBox;
        private System.Windows.Forms.TextBox home_PhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zip_CodeTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox1;
        private System.Windows.Forms.TextBox notesTextBox1;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}