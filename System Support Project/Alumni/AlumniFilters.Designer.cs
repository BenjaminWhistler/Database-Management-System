namespace System_Support_Project.Alumni
{
    partial class AlumniFilters
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
            this.inactive_CheckBox = new System.Windows.Forms.CheckBox();
            this.saveFiltersButton = new System.Windows.Forms.Button();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mobile_PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.home_PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
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
            this.SuspendLayout();
            // 
            // alumni_IDLabel
            // 
            alumni_IDLabel.AutoSize = true;
            alumni_IDLabel.Location = new System.Drawing.Point(12, 14);
            alumni_IDLabel.Name = "alumni_IDLabel";
            alumni_IDLabel.Size = new System.Drawing.Size(55, 13);
            alumni_IDLabel.TabIndex = 1;
            alumni_IDLabel.Text = "Alumni ID:";
            alumni_IDLabel.Click += new System.EventHandler(this.alumni_IDLabel_Click);
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(12, 40);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            first_NameLabel.Click += new System.EventHandler(this.first_NameLabel_Click);
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(12, 66);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            last_NameLabel.Click += new System.EventHandler(this.last_NameLabel_Click);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 92);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(12, 196);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 9;
            streetLabel.Text = "Street:";
            streetLabel.Click += new System.EventHandler(this.streetLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 170);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 248);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            cityLabel.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // zip_CodeLabel
            // 
            zip_CodeLabel.AutoSize = true;
            zip_CodeLabel.Location = new System.Drawing.Point(12, 222);
            zip_CodeLabel.Name = "zip_CodeLabel";
            zip_CodeLabel.Size = new System.Drawing.Size(53, 13);
            zip_CodeLabel.TabIndex = 19;
            zip_CodeLabel.Text = "Zip Code:";
            zip_CodeLabel.Click += new System.EventHandler(this.zip_CodeLabel_Click);
            // 
            // active_Label
            // 
            active_Label.AutoSize = true;
            active_Label.Location = new System.Drawing.Point(12, 306);
            active_Label.Name = "active_Label";
            active_Label.Size = new System.Drawing.Size(43, 13);
            active_Label.TabIndex = 21;
            active_Label.Text = "Active?";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(12, 340);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "Notes:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(12, 274);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 25;
            stateLabel.Text = "State:";
            // 
            // mobile_PhoneLabel1
            // 
            mobile_PhoneLabel1.AutoSize = true;
            mobile_PhoneLabel1.Location = new System.Drawing.Point(12, 118);
            mobile_PhoneLabel1.Name = "mobile_PhoneLabel1";
            mobile_PhoneLabel1.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel1.TabIndex = 30;
            mobile_PhoneLabel1.Text = "Mobile Phone:";
            // 
            // home_PhoneLabel1
            // 
            home_PhoneLabel1.AutoSize = true;
            home_PhoneLabel1.Location = new System.Drawing.Point(12, 144);
            home_PhoneLabel1.Name = "home_PhoneLabel1";
            home_PhoneLabel1.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel1.TabIndex = 32;
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
            this.tableAdapterManager.DonationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Support_Project.Alumni_Association_DocumentationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumni_IDTextBox
            // 
            this.alumni_IDTextBox.CausesValidation = false;
            this.alumni_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Alumni_ID", true));
            this.alumni_IDTextBox.Location = new System.Drawing.Point(93, 11);
            this.alumni_IDTextBox.Name = "alumni_IDTextBox";
            this.alumni_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.alumni_IDTextBox.TabIndex = 2;
            this.alumni_IDTextBox.TextChanged += new System.EventHandler(this.alumniIDTextBox_TextChanged);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(93, 37);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.first_NameTextBox.TabIndex = 4;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(93, 63);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(104, 20);
            this.last_NameTextBox.TabIndex = 6;
            this.last_NameTextBox.TextChanged += new System.EventHandler(this.last_NameTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(93, 89);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox.TabIndex = 8;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(93, 193);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(150, 20);
            this.streetTextBox.TabIndex = 10;
            this.streetTextBox.TextChanged += new System.EventHandler(this.streetTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(93, 167);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 16;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(93, 245);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(104, 20);
            this.cityTextBox.TabIndex = 18;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // zip_CodeTextBox
            // 
            this.zip_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Zip_Code", true));
            this.zip_CodeTextBox.Location = new System.Drawing.Point(93, 219);
            this.zip_CodeTextBox.Name = "zip_CodeTextBox";
            this.zip_CodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.zip_CodeTextBox.TabIndex = 20;
            this.zip_CodeTextBox.TextChanged += new System.EventHandler(this.zip_CodeTextBox_TextChanged);
            // 
            // active_CheckBox
            // 
            this.active_CheckBox.Checked = true;
            this.active_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.active_CheckBox.Location = new System.Drawing.Point(93, 294);
            this.active_CheckBox.Name = "active_CheckBox";
            this.active_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.active_CheckBox.TabIndex = 22;
            this.active_CheckBox.Text = "Remove Yes";
            this.active_CheckBox.UseVisualStyleBackColor = true;
            this.active_CheckBox.CheckedChanged += new System.EventHandler(this.active_CheckBox_CheckedChanged);
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(93, 337);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(234, 127);
            this.notesTextBox.TabIndex = 24;
            this.notesTextBox.TextChanged += new System.EventHandler(this.notesTextBox_TextChanged);
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(93, 271);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(104, 20);
            this.stateTextBox.TabIndex = 26;
            this.stateTextBox.TextChanged += new System.EventHandler(this.stateTextBox_TextChanged);
            // 
            // inactive_CheckBox
            // 
            this.inactive_CheckBox.Checked = true;
            this.inactive_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inactive_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumniBindingSource, "Active?", true));
            this.inactive_CheckBox.Location = new System.Drawing.Point(93, 313);
            this.inactive_CheckBox.Name = "inactive_CheckBox";
            this.inactive_CheckBox.Size = new System.Drawing.Size(104, 18);
            this.inactive_CheckBox.TabIndex = 27;
            this.inactive_CheckBox.Text = "Remove No";
            this.inactive_CheckBox.UseVisualStyleBackColor = true;
            this.inactive_CheckBox.CheckedChanged += new System.EventHandler(this.inactive_CheckBox_CheckedChanged);
            // 
            // saveFiltersButton
            // 
            this.saveFiltersButton.Location = new System.Drawing.Point(348, 248);
            this.saveFiltersButton.Name = "saveFiltersButton";
            this.saveFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.saveFiltersButton.TabIndex = 28;
            this.saveFiltersButton.Text = "Save Filters";
            this.saveFiltersButton.UseVisualStyleBackColor = true;
            this.saveFiltersButton.Click += new System.EventHandler(this.saveFiltersButton_Click);
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.Location = new System.Drawing.Point(348, 274);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(75, 23);
            this.clearFiltersButton.TabIndex = 29;
            this.clearFiltersButton.Text = "Clear Filters";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            this.clearFiltersButton.Click += new System.EventHandler(this.clearFiltersButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(348, 337);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mobile_PhoneMaskedTextBox
            // 
            this.mobile_PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Mobile_Phone", true));
            this.mobile_PhoneMaskedTextBox.Location = new System.Drawing.Point(93, 115);
            this.mobile_PhoneMaskedTextBox.Name = "mobile_PhoneMaskedTextBox";
            this.mobile_PhoneMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.mobile_PhoneMaskedTextBox.TabIndex = 31;
            this.mobile_PhoneMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mobile_PhoneMaskedTextBox_MaskInputRejected);
            this.mobile_PhoneMaskedTextBox.TextChanged += new System.EventHandler(this.mobile_PhoneTextBox_TextChanged);
            // 
            // home_PhoneMaskedTextBox
            // 
            this.home_PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumniBindingSource, "Home_Phone", true));
            this.home_PhoneMaskedTextBox.Location = new System.Drawing.Point(93, 141);
            this.home_PhoneMaskedTextBox.Name = "home_PhoneMaskedTextBox";
            this.home_PhoneMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.home_PhoneMaskedTextBox.TabIndex = 33;
            this.home_PhoneMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.home_PhoneMaskedTextBox_MaskInputRejected);
            this.home_PhoneMaskedTextBox.TextChanged += new System.EventHandler(this.home_PhoneTextBox_TextChanged);
            // 
            // AlumniFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 477);
            this.Controls.Add(home_PhoneLabel1);
            this.Controls.Add(this.home_PhoneMaskedTextBox);
            this.Controls.Add(mobile_PhoneLabel1);
            this.Controls.Add(this.mobile_PhoneMaskedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearFiltersButton);
            this.Controls.Add(this.saveFiltersButton);
            this.Controls.Add(this.inactive_CheckBox);
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
            this.Name = "AlumniFilters";
            this.Text = "Filter Alumni records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.AlumniFilters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumni_Association_DocumentationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumniBindingSource)).EndInit();
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
        private System.Windows.Forms.CheckBox inactive_CheckBox;
        private System.Windows.Forms.Button saveFiltersButton;
        private System.Windows.Forms.Button clearFiltersButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MaskedTextBox mobile_PhoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox home_PhoneMaskedTextBox;
    }
}