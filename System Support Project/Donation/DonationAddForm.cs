using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Support_Project.Donation
{
    public partial class DonationAddForm : Form
    {

        DonationMainForm epic = (DonationMainForm)Application.OpenForms["DonationMainForm"];
        Boolean loading = true;
        public DonationAddForm()
        {
            InitializeComponent();
        }

        private void DonationAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            this.donationBindingSource.AddNew();
            loading = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string s1 = account_NumberTextBox.Text;
            string s2 = account_NumberComboBox.SelectedValue?.ToString();
            if (account_NumberComboBox.SelectedValue != null)
            {
                if (account_NumberComboBox.SelectedValue.ToString() == account_NumberTextBox.Text)
                {
                    try
                    {
                        this.Validate();
                        this.donationBindingSource.EndEdit();
                        this.donationTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Donation);

                        if (epic != null)
                        {
                            epic.loadData();
                        }

                        this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
                        this.donationBindingSource.AddNew();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to save. Account Number must match an existing account.");
                    account_NumberTextBox.Text = s1;
                    account_NumberComboBox.SelectedValue = s2;
                }
            }
            else
            {
                MessageBox.Show("Unable to save. Account Number must match an existing account.");
            }
        }

        private void DonationAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonationMainForm.restrictAdd = false;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != "" || donation_AmountTextBox.Text != "" ||
                notesTextBox.Text != "")
            {
                string prompt = "You will lose any data entered data. Do you wish to exit?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void account_NumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            account_NumberTextBox.Text = account_NumberComboBox.SelectedValue?.ToString();
        }
        int index = 0;
        private void account_NumberTextBox_TextChanged(object sender, EventArgs e)
        {


            if (loading == false)
            {
                bool matchFound = false;

                foreach (var item in account_NumberComboBox.Items)
                {
                    var row = item as DataRowView;
                    index = account_NumberComboBox.Items.IndexOf(item);
                    if (row != null)
                    {
                        if (row[account_NumberComboBox.ValueMember].ToString() == account_NumberTextBox.Text)
                        {
                            matchFound = true;
                            break;
                        }

                    }

                }
                if (matchFound)
                {
                    loading = true;
                    account_NumberComboBox.SelectedIndex = index;
                    loading = false;
                }
            }
        }
    }
}
