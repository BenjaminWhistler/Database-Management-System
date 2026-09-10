using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Account;

namespace System_Support_Project.Donation
{
    public partial class DonationFilters : Form
    {
        public static DonationFilters Instance;
        static string f1 = null;
        static string f2 = null;
        static string f3 = null;
        static string f4 = null;
        static string f5 = null;
        static string f6 = null;
        public static int s_id;

        public DonationFilters()
        {
            InitializeComponent();
            Instance = this;
        }


        private void DonationFilters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            donation_IDTextBox.Text = DonationMainForm.savedFilter.f1;
            alumni_IDTextBox.Text = DonationMainForm.savedFilter.f2;
            account_NumberTextBox.Text = DonationMainForm.savedFilter.f3;
            donation_DateTextBox.Text = DonationMainForm.savedFilter.f4;
            donation_AmountTextBox.Text = DonationMainForm.savedFilter.f5;
            notesTextBox.Text = DonationMainForm.savedFilter.f6;
            DonationMainForm.savedFilter = (f1, f2, f3, f4, f5, f6);
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
        }

        private void donation_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            f1 = donation_IDTextBox.Text;
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (donation_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != ""
               || donation_AmountTextBox.Text != "" || notesTextBox.Text != "")
            {
                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void alumni_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            f2 = alumni_IDTextBox.Text;
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (donation_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != ""
               || donation_AmountTextBox.Text != "" || notesTextBox.Text != "")
            {
                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void account_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            f3 = account_NumberTextBox.Text;
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (donation_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != ""
               || donation_AmountTextBox.Text != "" || notesTextBox.Text != "")
            {
                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void donation_DateTextBox_TextChanged(object sender, EventArgs e)
        {
            f4 = donation_DateTextBox.Text;
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (donation_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != ""
               || donation_AmountTextBox.Text != "" || notesTextBox.Text != "")
            {
                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void donation_AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            f5 = donation_AmountTextBox.Text;
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (donation_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != ""
               || donation_AmountTextBox.Text != "" || notesTextBox.Text != "")
            {
                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {
            f6 = notesTextBox.Text;
            DonationMainForm.Instance.filterAll(f1, f2, f3, f4, f5, f6);
            if (donation_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || account_NumberTextBox.Text != "" || donation_DateTextBox.Text != ""
               || donation_AmountTextBox.Text != "" || notesTextBox.Text != "")
            {
                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            DonationMainForm.Instance.filterAll(DonationMainForm.savedFilter.f1, DonationMainForm.savedFilter.f2, DonationMainForm.savedFilter.f3, DonationMainForm.savedFilter.f4,
                DonationMainForm.savedFilter.f5, DonationMainForm.savedFilter.f6);
            DonationMainForm.restrictFilter = false;

            if (DonationMainForm.savedFilter.f1 == "")
            {
                DonationMainForm.savedFilter.f1 = null;
            }
            if (DonationMainForm.savedFilter.f2 == "")
            {
                DonationMainForm.savedFilter.f2 = null;
            }
            if (DonationMainForm.savedFilter.f3 == "")
            {
                DonationMainForm.savedFilter.f3 = null;
            }
            if (DonationMainForm.savedFilter.f4 == "")
            {
                DonationMainForm.savedFilter.f4 = null;
            }
            if (DonationMainForm.savedFilter.f5 == "")
            {
                DonationMainForm.savedFilter.f5 = null;
            }
            if (DonationMainForm.savedFilter.f6 == "")
            {
                DonationMainForm.savedFilter.f6 = null;
            }
            if (DonationMainForm.savedFilter.f1 != null || DonationMainForm.savedFilter.f2 != null || DonationMainForm.savedFilter.f3 != null ||
                DonationMainForm.savedFilter.f4 != null || DonationMainForm.savedFilter.f5 != null || DonationMainForm.savedFilter.f6 != null)
            {

                DonationMainForm.savedFilterLabel = "Filters are applied";
                DonationMainForm.Instance.filterLabel();
            }
            else
            {
                DonationMainForm.savedFilterLabel = "";
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void saveFiltersButton_Click(object sender, EventArgs e)
        {
            if (DonationMainForm.savedFilter != (f1, f2, f3, f4, f5, f6))
            {
                DonationMainForm.savedFilter = (f1, f2, f3, f4, f5, f6);
                DonationMainForm.Instance.filterLabel();
            }
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            donation_IDTextBox.Text = null;
            alumni_IDTextBox.Text = null;
            account_NumberTextBox.Text = null;
            donation_DateTextBox.Text = null;
            donation_AmountTextBox.Text = null;
            notesTextBox.Text = null;
            DonationMainForm.savedFilter = (f1, f2, f3, f4, f5, f6);
            DonationMainForm.savedFilterLabel = "";
            DonationMainForm.Instance.filterLabel();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
