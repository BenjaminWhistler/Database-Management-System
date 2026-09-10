using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Account;

namespace System_Support_Project.Donation
{
    public partial class DonationEditForm : Form
    {
        DonationMainForm epic = (DonationMainForm)Application.OpenForms["DonationMainForm"];
        public int e_id;
        public Boolean stupid = false;
        Boolean loading = true;
        public DonationEditForm()
        {
            InitializeComponent();
        }

        private void DonationEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            this.donationBindingSource.Position = this.donationBindingSource.Find("Donation_ID", e_id);
            if (stupid == false)
            {
                epic2();
            }
            loading = false;
        }

        private void DonationEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonationMainForm.restrictEdit = false;
            epic.loadData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(account_NumberComboBox.SelectedValue?.ToString());
            MessageBox.Show(account_NumberTextBox.Text);
            this.donationBindingSource.CancelEdit();

            string prompt = "You will lose any data you may have entered. Do you wish to cancel and exit?";
            DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string s1 = account_NumberTextBox.Text;
            int s2 = account_NumberComboBox.SelectedIndex;
            loading = false;
            if (account_NumberComboBox.SelectedValue != null)
            {
                if (account_NumberComboBox.SelectedValue.ToString() == account_NumberTextBox.Text)
                {

                    try
                    {
                        this.Validate();
                        account_NumberTextBox.Text = s1;
                        account_NumberComboBox.SelectedIndex = s2;
                        this.donationBindingSource.EndEdit();
                        this.donationTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Donation);
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to save. System says;    " + ex.Message);
                        account_NumberTextBox.Text = s1;
                        account_NumberComboBox.SelectedIndex = s2;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to save. Account Number must match an existing account.");
                }
            }
        }

        public void epic2()
        {
            this.Validate();
            string s1 = account_NumberTextBox.Text;
            int s2 = account_NumberComboBox.SelectedIndex;
            loading = true;
            if (account_NumberComboBox.SelectedValue != null)
            {
                if (account_NumberComboBox.SelectedValue.ToString() == account_NumberTextBox.Text)
                {

                    try
                    {
                        account_NumberTextBox.Text = s1;
                        account_NumberComboBox.SelectedIndex = s2;
                        this.donationBindingSource.EndEdit();
                        this.donationTableAdapter.Update(this.alumni_Association_DocumentationDataSet.Donation);
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        account_NumberTextBox.Text = s1;
                        account_NumberComboBox.SelectedIndex = s2;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to save. Account Number must match an existing account.");
                    account_NumberTextBox.Text = s1;
                    account_NumberComboBox.SelectedValue = s2;
                }
            }
        }

        private void account_NumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading == false)
            {
                account_NumberTextBox.Text = account_NumberComboBox.SelectedValue?.ToString();
            }
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
