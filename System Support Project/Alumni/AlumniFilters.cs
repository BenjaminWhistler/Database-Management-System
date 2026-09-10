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

namespace System_Support_Project.Alumni
{
    public partial class AlumniFilters : Form
    {
        string f1 = null;
        string f2 = null;
        string f3 = null;
        string f4 = null;
        string f5 = null;
        string f6 = null;
        string f7 = null;
        string f8 = null;
        string f9 = null;
        string f10 = null;
        Boolean f11 = false;
        Boolean f12 = false;
        string f13 = null;
        string f14 = null;

        public AlumniFilters()
        {
            InitializeComponent();
        }

        private void AlumniFilters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            alumni_IDTextBox.Text = AlumniMainForm1.savedFilter.f1;
            first_NameTextBox.Text = AlumniMainForm1.savedFilter.f2;
            last_NameTextBox.Text = AlumniMainForm1.savedFilter.f3;
            titleTextBox.Text = AlumniMainForm1.savedFilter.f4;
            streetTextBox.Text = AlumniMainForm1.savedFilter.f5;
            mobile_PhoneMaskedTextBox.Text = AlumniMainForm1.savedFilter.f6;
            home_PhoneMaskedTextBox.Text = AlumniMainForm1.savedFilter.f7;
            emailTextBox.Text = AlumniMainForm1.savedFilter.f8;
            cityTextBox.Text = AlumniMainForm1.savedFilter.f9;
            zip_CodeTextBox.Text = AlumniMainForm1.savedFilter.f10;
            active_CheckBox.Checked = AlumniMainForm1.savedFilter.f11;
            inactive_CheckBox.Checked = AlumniMainForm1.savedFilter.f12;
            notesTextBox.Text = AlumniMainForm1.savedFilter.f13;
            stateTextBox.Text = AlumniMainForm1.savedFilter.f14;
            AlumniMainForm1.savedFilter = (f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
        }

        private void alumniIDTextBox_TextChanged(object sender, EventArgs e)
        {
            f1 = alumni_IDTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (alumni_IDTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            f2 = first_NameTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (first_NameTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
                
            }
        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            f3 = last_NameTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (last_NameTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            f4 = titleTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (titleTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            f5 = streetTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (streetTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void mobile_PhoneTextBox_TextChanged(object sender, EventArgs e) {
            f6 = mobile_PhoneMaskedTextBox.Text;

            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (mobile_PhoneMaskedTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void home_PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (home_PhoneMaskedTextBox.Text == "")
            {
                f7 = null;
            }
            else
            {
                f7 = home_PhoneMaskedTextBox.Text;
            }
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (home_PhoneMaskedTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            f8 = emailTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (emailTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            f9 = cityTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (cityTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }

        }

        private void zip_CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            f10 = zip_CodeTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (zip_CodeTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || active_CheckBox.Checked is true
               || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void active_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            f11 = active_CheckBox.Checked;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (active_CheckBox.Checked is true)
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void inactive_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            f12 = inactive_CheckBox.Checked;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (inactive_CheckBox.Checked is true)
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
                || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
                || active_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {
            f13 = notesTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (notesTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
                || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
                || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            f14 = stateTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
                || mobile_PhoneMaskedTextBox.Text != "" || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
                || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
        }

        private void first_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void last_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void streetLabel_Click(object sender, EventArgs e)
        {

        }

        private void mobile_PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void home_PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void zip_CodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void alumni_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            AlumniMainForm1.Instance.filterAll(AlumniMainForm1.savedFilter.f1, AlumniMainForm1.savedFilter.f2, AlumniMainForm1.savedFilter.f3, AlumniMainForm1.savedFilter.f4, AlumniMainForm1.savedFilter.f5, AlumniMainForm1.savedFilter.f6, AlumniMainForm1.savedFilter.f7, AlumniMainForm1.savedFilter.f8,
                AlumniMainForm1.savedFilter.f9, AlumniMainForm1.savedFilter.f10, AlumniMainForm1.savedFilter.f11, AlumniMainForm1.savedFilter.f12, AlumniMainForm1.savedFilter.f13, AlumniMainForm1.savedFilter.f14);
            AlumniMainForm1.restrictFilter = false;
            {
                if (AlumniMainForm1.savedFilter.f1 == "")
                {
                    AlumniMainForm1.savedFilter.f1 = null;
                }
                if (AlumniMainForm1.savedFilter.f2 == "")
                {
                    AlumniMainForm1.savedFilter.f2 = null;
                }
                if (AlumniMainForm1.savedFilter.f3 == "")
                {
                    AlumniMainForm1.savedFilter.f3 = null;
                }
                if (AlumniMainForm1.savedFilter.f4 == "")
                {
                    AlumniMainForm1.savedFilter.f4 = null;
                }
                if (AlumniMainForm1.savedFilter.f5 == "")
                {
                    AlumniMainForm1.savedFilter.f5 = null;
                }
                if (AlumniMainForm1.savedFilter.f6 == "")
                {
                    AlumniMainForm1.savedFilter.f6 = null;
                }
                if (AlumniMainForm1.savedFilter.f7 == "")
                {
                    AlumniMainForm1.savedFilter.f7 = null;
                }
                if (AlumniMainForm1.savedFilter.f8 == "")
                {
                    AlumniMainForm1.savedFilter.f8 = null;
                }
                if (AlumniMainForm1.savedFilter.f9 == "")
                {
                    AlumniMainForm1.savedFilter.f9 = null;
                }
                if (AlumniMainForm1.savedFilter.f10 == "")
                {
                    AlumniMainForm1.savedFilter.f10 = null;
                }
                if (AlumniMainForm1.savedFilter.f13 == "")
                {
                    AlumniMainForm1.savedFilter.f13 = null;
                }
                if (AlumniMainForm1.savedFilter.f14 == "")
                {
                    AlumniMainForm1.savedFilter.f14 = null;
                }
                if (AlumniMainForm1.savedFilter.f1 != null || AlumniMainForm1.savedFilter.f2 != null || AlumniMainForm1.savedFilter.f3 != null ||
                AlumniMainForm1.savedFilter.f4 != null || AlumniMainForm1.savedFilter.f5 != null || AlumniMainForm1.savedFilter.f6 != null || AlumniMainForm1.savedFilter.f7 != null ||
                AlumniMainForm1.savedFilter.f8 != null || AlumniMainForm1.savedFilter.f9 != null || AlumniMainForm1.savedFilter.f10 != null || AlumniMainForm1.savedFilter.f11 != false ||
                AlumniMainForm1.savedFilter.f12 != false || AlumniMainForm1.savedFilter.f13 != null || AlumniMainForm1.savedFilter.f14 != null)
                {

                    AlumniMainForm1.savedFilterLabel = "Filters are applied";
                    AlumniMainForm1.Instance.filterLabel();
                }
                else
                {
                    AlumniMainForm1.savedFilterLabel = "";
                    AlumniMainForm1.Instance.filterLabel();
                }
            }
        }

        private void saveFiltersButton_Click(object sender, EventArgs e)
        { if (AlumniMainForm1.savedFilter != (f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14))
            {
                AlumniMainForm1.savedFilter = (f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
                AlumniMainForm1.Instance.filterLabel();
            }
            
        }

        private void clearFiltersButton_Click(object sender, EventArgs e)
        {
            alumni_IDTextBox.Text = null;
            first_NameTextBox.Text = null;
            last_NameTextBox.Text = null;
            titleTextBox.Text = null;
            streetTextBox.Text = null;
            mobile_PhoneMaskedTextBox.Text = null;
            home_PhoneMaskedTextBox.Text = null;
            emailTextBox.Text = null;
            cityTextBox.Text = null;
            zip_CodeTextBox.Text = null;
            active_CheckBox.Checked = false;
            inactive_CheckBox.Checked = false;
            notesTextBox.Text = null;
            stateTextBox.Text = null;
            AlumniMainForm1.savedFilter = (f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            AlumniMainForm1.savedFilterLabel = "";
            AlumniMainForm1.Instance.filterLabel();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mobile_PhoneMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /*
            f6 = mobile_PhoneMaskedTextBox.Text;
            AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
            if (mobile_PhoneMaskedTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
               || home_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
               || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
            {
                AlumniMainForm1.savedFilterLabel = "Filters are applied";
                AlumniMainForm1.Instance.filterLabel();
            }
            else
            {
                AlumniMainForm1.savedFilterLabel = "";
                AlumniMainForm1.Instance.filterLabel();
            }
            */
        }

        private void home_PhoneMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /*    f7 = home_PhoneMaskedTextBox.Text;
                AlumniMainForm1.Instance.filterAll(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14);
                if (home_PhoneMaskedTextBox.Text != "")
                {
                    AlumniMainForm1.savedFilterLabel = "Filters are applied";
                    AlumniMainForm1.Instance.filterLabel();
                }
                else if (alumni_IDTextBox.Text != "" || first_NameTextBox.Text != "" || last_NameTextBox.Text != "" || titleTextBox.Text != "" || streetTextBox.Text != ""
                   || mobile_PhoneMaskedTextBox.Text != "" || emailTextBox.Text != "" || cityTextBox.Text != "" || zip_CodeTextBox.Text != ""
                   || active_CheckBox.Checked is true || inactive_CheckBox.Checked is true || notesTextBox.Text != "" || stateTextBox.Text != "")
                {
                    AlumniMainForm1.savedFilterLabel = "Filters are applied";
                    AlumniMainForm1.Instance.filterLabel();
                }
                else
                {
                    AlumniMainForm1.savedFilterLabel = "";
                    AlumniMainForm1.Instance.filterLabel();
                }
                */
        }
    }
}
