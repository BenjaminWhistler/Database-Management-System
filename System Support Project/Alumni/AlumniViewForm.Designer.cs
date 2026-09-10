namespace System_Support_Project.Alumni
{
    partial class AlumniViewForm
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
            System.Windows.Forms.Label alumni_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zip_CodeLabel;
            System.Windows.Forms.Label active_Label;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label mobile_PhoneLabel1;
            System.Windows.Forms.Label home_PhoneLabel1;
            this.alumni_Association_DocumentationDataSet = new System_Support_Project.Alumni_Association_DocumentationDataSet();
            this.alumniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumniTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter();
            this.tableAdapterManager = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager();
            this.donationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter();
            this.educationTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter();
            this.alumni_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zip_CodeTextBox = new System.Windows.Forms.TextBox();
            this.active_CheckBox = new System.Windows.Forms.CheckBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationDataGridView = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationDataGridView = new System.Windows.Forms.DataGridView();
            this.donationLabel = new System.Windows.Forms.Label();
            this.educationLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.accountTableAdapter = new System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter();
            this.mobile_PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.home_PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alumni_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zip_CodeLabel = new System.Windows.Forms.Label();
            active_Label = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            mobile_PhoneLabel1 = new System.Windows.Forms.Label();
            home_PhoneLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alumni_IDLabel
            // 
            alumni_IDLabel.AutoSize = true;
            alumni_IDLabel.Location = new System.Drawing.Point(17, 24);
            alumni_IDLabel.Name = "alumni_IDLabel";
            alumni_IDLabel.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel.TabIndex = 1;
            alumni_IDLabel.Text = "Alumni ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(17, 50);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(17, 76);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(17, 102);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(17, 206);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 9;
            streetLabel.Text = "Street:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(17, 180);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(17, 258);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            // 
            // zip_CodeLabel
            // 
            zip_CodeLabel.AutoSize = true;
            zip_CodeLabel.Location = new System.Drawing.Point(17, 232);
            zip_CodeLabel.Name = "zip_CodeLabel";
            zip_CodeLabel.Size = new System.Drawing.Size(53, 13);
            zip_CodeLabel.TabIndex = 19;
            zip_CodeLabel.Text = "Zip Code:";
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(17, 312);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(43, 13);
            active_Label.TabIndex = 21;
            active_Label.Text = "Active?";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(17, 340);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "Notes:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(17, 284);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 25;
            stateLabel.Text = "State:";
            // 
            // mobile_PhoneLabel1
            // 
            mobile_PhoneLabel1.AutoSize = true;
            mobile_PhoneLabel1.Location = new System.Drawing.Point(17, 128);
            mobile_PhoneLabel1.Name = "mobile_PhoneLabel1";
            mobile_PhoneLabel1.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel1.TabIndex = 31;
            mobile_PhoneLabel1.Text = "Mobile Phone:";
            // 
            // home_PhoneLabel1
            // 
            home_PhoneLabel1.AutoSize = true;
            home_PhoneLabel1.Location = new System.Drawing.Point(20, 154);
            home_PhoneLabel1.Name = "home_PhoneLabel1";
            home_PhoneLabel1.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel1.TabIndex = 33;
            home_PhoneLabel1.Text = "Home Phone:";
            // 
            // alumni_Association_DocumentationDataSet
            // 
            this.alumni_Association_DocumentationDataSet.DataSetName = "Alumni_Association_DocumentationDataSet";
            this.alumni_Association_DocumentationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumniBindingSource
            // 
            this.alumniBindingSource.DataMember = "Alumni";
            this.alumniBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // alumniTableAdapter
            // 
            this.alumniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AlumniTableAdapter = this.alumniTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonationTableAdapter = this.donationTableAdapter;
            this.tableAdapterManager.EducationTableAdapter = this.educationTableAdapter;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(98, 21);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.ReadOnly = true;
            this.alumni_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.alumni_IDTextBox.TabIndex = 2;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(98, 47);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ReadOnly = true;
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(98, 73);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.ReadOnly = true;
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(98, 99);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(98, 203);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(130, 20);
            this.streetTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(98, 177);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(130, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(98, 255);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(104, 20);
            this.cityTextBox.TabIndex = 18;
            // 
            // zip_CodeTextBox
            // 
            this.zip_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Zip_Code", true));
            this.zip_CodeTextBox.Location = new System.Drawing.Point(98, 229);
            this.zip_CodeTextBox.Name = "zip_CodeTextBox";
            this.zip_CodeTextBox.ReadOnly = true;
            this.zip_CodeTextBox.Size = new System.Drawing.Size(37, 20);
            this.zip_CodeTextBox.TabIndex = 20;
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.active_CheckBox.Location = new System.Drawing.Point(98, 307);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 22;
            this.active_CheckBox.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(98, 337);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox.TabIndex = 24;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(98, 281);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(30, 20);
            this.stateTextBox.TabIndex = 26;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "AlumniDonation";
            this.donationBindingSource.DataSource = this.alumniBindingSource;
            // 
            // donationDataGridView
            // 
            this.donationDataGridView.AllowUserToAddRows = false;
            this.donationDataGridView.AllowUserToDeleteRows = false;
            this.donationDataGridView.AutoGenerateColumns = false;
            this.donationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.donationDataGridView.DataSource = this.donationBindingSource;
            this.donationDataGridView.Location = new System.Drawing.Point(305, 29);
            this.donationDataGridView.Name = "donationDataGridView";
            this.donationDataGridView.ReadOnly = true;
            this.donationDataGridView.Size = new System.Drawing.Size(860, 272);
            this.donationDataGridView.TabIndex = 27;
            this.donationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donationDataGridView_CellContentClick);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.alumni_Association_DocumentationDataSet;
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "AlumniEducation";
            this.educationBindingSource.DataSource = this.alumniBindingSource;
            // 
            // educationDataGridView
            // 
            this.educationDataGridView.AllowUserToAddRows = false;
            this.educationDataGridView.AllowUserToDeleteRows = false;
            this.educationDataGridView.AutoGenerateColumns = false;
            this.educationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.educationDataGridView.DataSource = this.educationBindingSource;
            this.educationDataGridView.Location = new System.Drawing.Point(385, 340);
            this.educationDataGridView.Name = "educationDataGridView";
            this.educationDataGridView.ReadOnly = true;
            this.educationDataGridView.Size = new System.Drawing.Size(710, 211);
            this.educationDataGridView.TabIndex = 28;
            // 
            // donationLabel
            // 
            this.donationLabel.AutoSize = true;
            this.donationLabel.Location = new System.Drawing.Point(658, 9);
            this.donationLabel.Name = "donationLabel";
            this.donationLabel.Size = new System.Drawing.Size(173, 13);
            this.donationLabel.TabIndex = 29;
            this.donationLabel.Text = "Donation records tied to this Alumni";
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Location = new System.Drawing.Point(658, 324);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(178, 13);
            this.educationLabel.TabIndex = 30;
            this.educationLabel.Text = "Education records tied to this Alumni";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(81, 512);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 31;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // mobile_PhoneMaskedTextBox
            // 
            this.mobile_PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Mobile_Phone", true));
            this.mobile_PhoneMaskedTextBox.Location = new System.Drawing.Point(98, 125);
            this.mobile_PhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.mobile_PhoneMaskedTextBox.Name = "mobile_PhoneMaskedTextBox";
            this.mobile_PhoneMaskedTextBox.ReadOnly = true;
            this.mobile_PhoneMaskedTextBox.Size = new System.Drawing.Size(81, 20);
            this.mobile_PhoneMaskedTextBox.TabIndex = 32;
            // 
            // home_PhoneMaskedTextBox
            // 
            this.home_PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Home_Phone", true));
            this.home_PhoneMaskedTextBox.Location = new System.Drawing.Point(98, 151);
            this.home_PhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.home_PhoneMaskedTextBox.Name = "home_PhoneMaskedTextBox";
            this.home_PhoneMaskedTextBox.ReadOnly = true;
            this.home_PhoneMaskedTextBox.Size = new System.Drawing.Size(81, 20);
            this.home_PhoneMaskedTextBox.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Donation_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Donation_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Alumni_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Alumni_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Account_Number";
            this.dataGridViewTextBoxColumn3.DataSource = this.accountBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Account_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Account_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Account_Number";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Donation_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Donation_Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Donation_Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Donation_Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Education_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Education_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Alumni_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Alumni_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Degree";
            this.dataGridViewTextBoxColumn9.HeaderText = "Degree";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Institution";
            this.dataGridViewTextBoxColumn10.HeaderText = "Institution";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Graduation_Date";
            this.dataGridViewTextBoxColumn11.HeaderText = "Graduation_Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // AlumniViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 576);
            this.Controls.Add(home_PhoneLabel1);
            this.Controls.Add(this.home_PhoneMaskedTextBox);
            this.Controls.Add(mobile_PhoneLabel1);
            this.Controls.Add(this.mobile_PhoneMaskedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.donationLabel);
            this.Controls.Add(this.educationDataGridView);
            this.Controls.Add(this.donationDataGridView);
            this.Controls.Add(alumni_IDLabel);
            this.Controls.Add(this.alumni_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(zip_CodeLabel);
            this.Controls.Add(this.zip_CodeTextBox);
            this.Controls.Add(active_Label);
            this.Controls.Add(this.active_CheckBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Name = "AlumniViewForm";
            this.Text = "View an Alumni record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlumniViewForm_FormClosing);
            this.Load += new System.EventHandler(this.AlumniViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Alumni_Association_DocumentationDataSet alumni_Association_DocumentationDataSet;
        private System.Windows.Forms.BindingSource alumniBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AlumniTableAdapter alumniTableAdapter;
        private Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox alumni_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zip_CodeTextBox;
        private System.Windows.Forms.CheckBox active_CheckBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private Alumni_Association_DocumentationDataSetTableAdapters.DonationTableAdapter donationTableAdapter;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.EducationTableAdapter educationTableAdapter;
        private System.Windows.Forms.DataGridView donationDataGridView;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private System.Windows.Forms.DataGridView educationDataGridView;
        private System.Windows.Forms.Label donationLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Alumni_Association_DocumentationDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.MaskedTextBox mobile_PhoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox home_PhoneMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}