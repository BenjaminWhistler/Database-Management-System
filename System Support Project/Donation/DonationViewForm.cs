using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Support_Project.Donation
{
    public partial class DonationViewForm : Form
    {
        public int e_id;
        public DonationViewForm()
        {
            InitializeComponent();
        }

        private void donationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.donationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alumni_Association_DocumentationDataSet);

        }

        private void DonationViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);

            this.donationBindingSource.Position = this.donationBindingSource.Find("Donation_ID", e_id);
            this.accountBindingSource.Position = this.accountBindingSource.Find("Account_Number", account_NumberTextBox.Text);
            this.alumniBindingSource.Position = this.alumniBindingSource.Find("Alumni_ID", alumni_IDTextBox.Text);

        }

        private void accountDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DonationViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonationMainForm.restrictView = false;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
