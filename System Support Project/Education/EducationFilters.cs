using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Account;

namespace System_Support_Project.Education
{
    public partial class EducationFilters : Form
    {
        static string f1 = null;
        static string f2 = null;
        static string f3 = null;
        static string f4 = null;
        static string f5 = null;
        public static int s_id;
        public EducationFilters()
        {
            InitializeComponent();
        }

        private void EducationFilters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            education_IDTextBox.Text = EducationMainForm.savedFilter.f1;
            alumni_IDTextBox.Text = EducationMainForm.savedFilter.f2;
            degreeTextBox.Text = EducationMainForm.savedFilter.f3;
            institutionTextBox.Text = EducationMainForm.savedFilter.f4;
            graduation_DateTextBox.Text = EducationMainForm.savedFilter.f5;
            EducationMainForm.savedFilter = (f1, f2, f3, f4, f5);
            EducationMainForm.Instance.filterAll(f1, f2, f3, f4, f5);
        }

        private void education_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            f1 = education_IDTextBox.Text;
            EducationMainForm.Instance.filterAll(f1, f2, f3, f4, f5);
            if (education_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || degreeTextBox.Text != "" || institutionTextBox.Text != "" ||
                graduation_DateTextBox.Text != "")
            {
                EducationMainForm.savedFilterLabel = "Filters are applied";
                EducationMainForm.Instance.filterLabel();
            }
            else
            {
                EducationMainForm.savedFilterLabel = "";
                EducationMainForm.Instance.filterLabel();
            }
        }

        private void alumni_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            f2 = alumni_IDTextBox.Text;
            EducationMainForm.Instance.filterAll(f1, f2, f3, f4, f5);
            if (education_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || degreeTextBox.Text != "" || institutionTextBox.Text != "" ||
                graduation_DateTextBox.Text != "")
            {
                EducationMainForm.savedFilterLabel = "Filters are applied";
                EducationMainForm.Instance.filterLabel();
            }
            else
            {
                EducationMainForm.savedFilterLabel = "";
                EducationMainForm.Instance.filterLabel();
            }
        }

        private void degreeTextBox_TextChanged(object sender, EventArgs e)
        {
            f3 = degreeTextBox.Text;
            EducationMainForm.Instance.filterAll(f1, f2, f3, f4, f5);
            if (education_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || degreeTextBox.Text != "" || institutionTextBox.Text != "" ||
                graduation_DateTextBox.Text != "")
            {
                EducationMainForm.savedFilterLabel = "Filters are applied";
                EducationMainForm.Instance.filterLabel();
            }
            else
            {
                EducationMainForm.savedFilterLabel = "";
                EducationMainForm.Instance.filterLabel();
            }
        }

        private void institutionTextBox_TextChanged(object sender, EventArgs e)
        {
            f4 = institutionTextBox.Text;
            EducationMainForm.Instance.filterAll(f1, f2, f3, f4, f5);
            if (education_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || degreeTextBox.Text != "" || institutionTextBox.Text != "" ||
                graduation_DateTextBox.Text != "")
            {
                EducationMainForm.savedFilterLabel = "Filters are applied";
                EducationMainForm.Instance.filterLabel();
            }
            else
            {
                EducationMainForm.savedFilterLabel = "";
                EducationMainForm.Instance.filterLabel();
            }
        }

        private void graduation_DateTextBox_TextChanged(object sender, EventArgs e)
        {
            f5 = graduation_DateTextBox.Text;
            EducationMainForm.Instance.filterAll(f1, f2, f3, f4, f5);
            if (education_IDTextBox.Text != "" || alumni_IDTextBox.Text != "" || degreeTextBox.Text != "" || institutionTextBox.Text != "" ||
                graduation_DateTextBox.Text != "")
            {
                EducationMainForm.savedFilterLabel = "Filters are applied";
                EducationMainForm.Instance.filterLabel();
            }
            else
            {
                EducationMainForm.savedFilterLabel = "";
                EducationMainForm.Instance.filterLabel();
            }
        }

        private void EducationFilters_FormClosing(object sender, FormClosingEventArgs e)
        {
            EducationMainForm.Instance.filterAll(EducationMainForm.savedFilter.f1, EducationMainForm.savedFilter.f2, EducationMainForm.savedFilter.f3, EducationMainForm.savedFilter.f4,
                EducationMainForm.savedFilter.f5);
            EducationMainForm.restrictFilter = false;

            if (EducationMainForm.savedFilter.f1 == "")
            {
                EducationMainForm.savedFilter.f1 = null;
            }
            if (EducationMainForm.savedFilter.f2 == "")
            {
                EducationMainForm.savedFilter.f2 = null;
            }
            if (EducationMainForm.savedFilter.f3 == "")
            {
                EducationMainForm.savedFilter.f3 = null;
            }
            if (EducationMainForm.savedFilter.f4 == "")
            {
                EducationMainForm.savedFilter.f4 = null;
            }
            if (EducationMainForm.savedFilter.f5 == "")
            {
                EducationMainForm.savedFilter.f5 = null;
            }
            if (EducationMainForm.savedFilter.f1 != null || AccountMainForm.savedFilter.f2 != null || EducationMainForm.savedFilter.f3 != null ||
                AccountMainForm.savedFilter.f4 != null || EducationMainForm.savedFilter.f5 != null)
            {

                EducationMainForm.savedFilterLabel = "Filters are applied";
                EducationMainForm.Instance.filterLabel();
            }
            else
            {
                EducationMainForm.savedFilterLabel = "";
                EducationMainForm.Instance.filterLabel();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            education_IDTextBox.Text = null;
            alumni_IDTextBox.Text = null;
            degreeTextBox.Text = null;
            institutionTextBox.Text = null;
            graduation_DateTextBox.Text = null;
            EducationMainForm.savedFilter = (f1, f2, f3, f4, f5);
            EducationMainForm.savedFilterLabel = "";
            EducationMainForm.Instance.filterLabel();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (EducationMainForm.savedFilter != (f1, f2, f3, f4, f5))
            {
                EducationMainForm.savedFilter = (f1, f2, f3, f4, f5);
                EducationMainForm.Instance.filterLabel();
            }
        }
    }
}
