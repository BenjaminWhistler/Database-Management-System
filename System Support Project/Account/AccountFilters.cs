using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Alumni;

namespace System_Support_Project.Account
{
    public partial class AccountFilters : Form
    {

        static string f1 = null;
        static string f2 = null;
        static string f3 = null;
        static string f4 = null;
        Boolean f5 = false;
        Boolean f6 = false;
        public static int s_id;
        public AccountFilters()
        {
            InitializeComponent();
        }

        private void AccountFilters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            record_IDTextBox.Text = AccountMainForm.savedFilter.f1;
            account_NumberTextBox.Text = AccountMainForm.savedFilter.f2;
            account_NameTextBox.Text = AccountMainForm.savedFilter.f3;
            parent_NumberTextBox.Text = AccountMainForm.savedFilter.f4;
            active_CheckBox.Checked = AccountMainForm.savedFilter.f5;
            inactive_CheckBox.Checked = AccountMainForm.savedFilter.f6;
            AccountMainForm.savedFilter = (f1, f2, f3, f4, f5, f6);
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);

        }

        private void record_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            f1 = record_IDTextBox.Text;
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (record_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || account_NameTextBox.Text != "" || parent_NumberTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true)
            {
                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }

        private void account_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            f2 = account_NumberTextBox.Text;
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (record_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || account_NameTextBox.Text != "" || parent_NumberTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true)
            {
                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }

        private void account_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            f3 = account_NameTextBox.Text;
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (record_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || account_NameTextBox.Text != "" || parent_NumberTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true)
            {
                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }

        private void parent_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            f4 = parent_NumberTextBox.Text;
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (record_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || account_NameTextBox.Text != "" || parent_NumberTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true)
            {
                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }

        private void active_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            f5 = active_CheckBox.Checked;
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (record_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || account_NameTextBox.Text != "" || parent_NumberTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true)
            {
                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }

        private void inactive_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            f6 = inactive_CheckBox.Checked;
            AccountMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (record_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || account_NameTextBox.Text != "" || parent_NumberTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true)
            {
                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            AccountMainForm.Instance.filterAll(AccountMainForm.savedFilter.f1, AccountMainForm.savedFilter.f2, AccountMainForm.savedFilter.f3, AccountMainForm.savedFilter.f4,
                AccountMainForm.savedFilter.f5, AccountMainForm.savedFilter.f6);
            AccountMainForm.restrictFilter = false;

            if (AccountMainForm.savedFilter.f1 == "")
            {
                AccountMainForm.savedFilter.f1 = null;
            }
            if (AccountMainForm.savedFilter.f2 == "")
            {
                AccountMainForm.savedFilter.f2 = null;
            }
            if (AccountMainForm.savedFilter.f3 == "")
            {
                AccountMainForm.savedFilter.f3 = null;
            }
            if (AccountMainForm.savedFilter.f4 == "")
            {
                AccountMainForm.savedFilter.f4 = null;
            }
            if (AccountMainForm.savedFilter.f1 != null || AccountMainForm.savedFilter.f2 != null || AccountMainForm.savedFilter.f3 != null ||
                AccountMainForm.savedFilter.f4 != null || AccountMainForm.savedFilter.f5 != false || AccountMainForm.savedFilter.f6 != false)
            {

                AccountMainForm.savedFilterLabel = "Filters are applied";
                AccountMainForm.Instance.filterLabel();
            }
            else
            {
                AccountMainForm.savedFilterLabel = "";
                AccountMainForm.Instance.filterLabel();
            }
        }


        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            record_IDTextBox.Text = null;
            account_NumberTextBox.Text = null;
            account_NameTextBox.Text = null;
            parent_NumberTextBox.Text = null;
            active_CheckBox.Checked = false;
            inactive_CheckBox.Checked = false;
            AccountMainForm.savedFilter = (f1, f2, f3, f4, f5, f6);
            AccountMainForm.savedFilterLabel = "";
            AccountMainForm.Instance.filterLabel();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFiltersButton_Click_1(object sender, EventArgs e)
        {
            if (AccountMainForm.savedFilter != (f1, f2, f3, f4, f5, f6))
            {
                AccountMainForm.savedFilter = (f1, f2, f3, f4, f5, f6);
                AccountMainForm.Instance.filterLabel();
            }
        }
    }
}
