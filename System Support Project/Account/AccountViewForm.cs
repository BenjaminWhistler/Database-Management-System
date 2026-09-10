using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Support_Project.Account
{
    public partial class AccountViewForm : Form
    {
        public string e_id;
        public AccountViewForm()
        {
            InitializeComponent();
        }

        private void AccountViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            active_CheckBox.AutoCheck = false;

            if (e_id == "")
            {
                MessageBox.Show("Record has no account number. Please add an account number in order to view this record.");
                this.Close();
            }
            else
            {
                this.accountBindingSource.Position = this.accountBindingSource.Find("Account_Number", e_id);
            }
        }

        private void AlumniViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountMainForm.restrictView = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
