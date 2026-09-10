using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Support_Project.Account;

namespace System_Support_Project.Donation
{
    public partial class DonationMainForm : Form
    {

        public static DonationMainForm Instance;
        public static Boolean restrictAdd = false;
        public static Boolean restrictEdit = false;
        public static Boolean restrictView = false;
        public static Boolean restrictFilter = false;
        public static (string f1, string f2, string f3, string f4, string f5, string f6) savedFilter;
        public static string savedFilterLabel;
        public DonationMainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void DonationMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Account);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            savedFilterLabel = filtersAppliedLabel.Text;
        }

        public void loadData()
        {
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
        }

        public void filterLabel()
        {
            filtersAppliedLabel.Text = savedFilterLabel;
        }

        private void DonationMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            restrictAdd = false;
            restrictEdit = false;
            restrictView = false;
            restrictFilter = false;
        }

        public void filterAll(string f1 = null, string f2 = null, string f3 = null, string f4 = null, string f5 = null, string f6 = null)
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(f1))
                filters.Add("Convert([Donation_ID], 'System.String') LIKE '" + f1 + "%'");

            if (!string.IsNullOrWhiteSpace(f2))
                filters.Add("Convert([Alumni_ID], 'System.String') LIKE '" + f2 + "%'");

            if (!string.IsNullOrWhiteSpace(f3))
                filters.Add("[Account_Number] LIKE '%" + f3 + "%'");

            if (int.TryParse(f4, out int date))
                filters.Add("[Donation_Date]>= #01/01/" + date + "# AND [Donation_Date] < #01/01/" + (date + 1) + "#");

            if (!string.IsNullOrWhiteSpace(f5))
                filters.Add("Convert([Donation_Amount], 'System.String') LIKE '" + f5 + "%'");

            if (!string.IsNullOrWhiteSpace(f6))
                filters.Add("[Notes] LIKE '%" + f6 + "%'");
            try
            {
                donationBindingSource.Filter = string.Join(" AND ", filters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying filters: " + ex.Message);
            }
        }

        private void addARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictAdd == false)
            {
                restrictAdd = true;
                DonationAddForm frm = new DonationAddForm();
                frm.Show();
                frm.Owner = this;
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void editARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonationEditForm frm = new DonationEditForm();

            int rowCount = donationDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only edit one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an alumni record in the grid to edit.");
            }
            else if (restrictEdit == false)
            {
                int m_id = (int)(donationDataGridView.CurrentRow.Cells[0].Value);
                if (m_id == (int)donationDataGridView.Rows[0].Cells[0].Value)
                {
                    frm.stupid = true;
                }
                frm.e_id = m_id;
                restrictEdit = true;
                frm.Owner = this;
                frm.Show();
                this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void viewARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonationViewForm frm = new DonationViewForm();

            int rowCount = donationDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only view one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an donation record in the grid to view.");
            }
            else if (restrictView == false)
            {
                int m_id = (int)(donationDataGridView.CurrentRow.Cells[0].Value);
                frm.e_id = m_id;
                restrictView = true;
                frm.Owner = this;
                frm.Show();
                this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void deleteARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowCount = donationDataGridView.SelectedRows.Count;
            if (rowCount > 1)
                MessageBox.Show("Too many rows selected. You may only delete one record at a time.");
            else if (rowCount < 1)
                MessageBox.Show("Use the mouse to select an donation record in the grid to delete.");
            else
            {
                int m_id = (int)(donationDataGridView.CurrentRow.Cells[0].Value);
                string prompt = "You are about to delete the Donation with id " + m_id + ", Are you sure?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.donationBindingSource.Position = donationBindingSource.Find("Donation_ID", m_id);
                    this.donationBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.alumni_Association_DocumentationDataSet);
                    this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
                }
            }
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictFilter == false)
            {
                restrictFilter = true;
                DonationFilters frm = new DonationFilters();
                frm.Show();
                frm.Owner = this;

            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportFunction()
        {
            if (donationDataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        if (donationDataGridView.SelectedRows.Count > 0)
                        {
                            try
                            {
                                int columnCount = donationDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[donationDataGridView.SelectedRows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += donationDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < donationDataGridView.SelectedRows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += donationDataGridView.SelectedRows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show("Note: only the selected rows were exported. Data Exported Successfully!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                        else if (donationDataGridView.SelectedRows.Count == 0)
                        {
                            try
                            {
                                int columnCount = donationDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[donationDataGridView.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += donationDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < donationDataGridView.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += donationDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }

                                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Records to export.", "Info");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filtersAppliedLabel.Text != "")
            {
                string prompt = "You have filters applied. Only the filtered data will be exported, would you like to proceed?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    exportFunction();
                }
            }
            else if (filtersAppliedLabel.Text == "")
            {
                exportFunction();
            }
        }
    }
}
