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

namespace System_Support_Project.Alumni
{
    public partial class AlumniMainForm1 : Form
    {
        public static AlumniMainForm1 Instance;

        public static Boolean restrictAdd = false;
        public static Boolean restrictEdit = false;
        public static Boolean restrictView = false;
        public static Boolean restrictFilter = false;
        public static (string f1, string f2, string f3, string f4, string f5, string f6,
         string f7, string f8, string f9, string f10, bool f11,
         bool f12, string f13, string f14) savedFilter;
        public static string savedFilterLabel;

        public AlumniMainForm1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void AlumniMainForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Donation);
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Alumni' table. You can move, or remove it, as needed.
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            savedFilterLabel = filtersAppliedLabel1.Text;

        }

        private void AlumniMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AlumniMainForm1.restrictAdd = false;
            AlumniMainForm1.restrictEdit = false;
            AlumniMainForm1.restrictFilter = false;
            AlumniMainForm1.restrictView = false;
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData()
        {
            this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
        }

        private void addARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictAdd == false)
            {
                restrictAdd = true;
                AlumniAddForm frm = new AlumniAddForm();
                frm.Owner = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void editARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumniEditForm frm = new AlumniEditForm();

            int rowCount = alumniDataGridView.SelectedRows.Count;

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
                int m_id = (int)(alumniDataGridView.CurrentRow.Cells[0].Value);
                frm.e_id = m_id;
                restrictEdit = true;
                frm.Owner = this;
                frm.Show();
                this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void viewARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumniViewForm frm = new AlumniViewForm();

            int rowCount = alumniDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only view one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an alumni record in the grid to view.");
            }
            else if (restrictView == false)
            {
                int m_id = (int)(alumniDataGridView.CurrentRow.Cells[0].Value);
                frm.e_id = m_id;
                restrictView = true;
                frm.Owner = this;
                frm.Show();
                this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void deleteARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowCount = alumniDataGridView.SelectedRows.Count;
            if (rowCount > 1)
                MessageBox.Show("Too many rows selected. You may only delete one record at a time.");
            else if (rowCount < 1)
                MessageBox.Show("Use the mouse to select an alumni record in the grid to delete.");
            else
            {
                int m_id = (int)(alumniDataGridView.CurrentRow.Cells[0].Value);
                string prompt = "You are about to delete the Alumni with id " + m_id + " and all their donation and education records. Are you sure?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.alumniBindingSource.Position = alumniBindingSource.Find("Alumni_ID", m_id);
                    this.educationTableAdapter.DeleteEducationSubRecords(m_id);
                    this.donationTableAdapter.DeleteDonationSubRecords(m_id);
                    this.alumniBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.alumni_Association_DocumentationDataSet);
                    this.alumniTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Alumni);
                }
            }
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictFilter == false)
            {
                restrictFilter = true;
                AlumniFilters frm = new AlumniFilters();
                frm.Show();
                frm.Owner = this;
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void exportFunction()
        {
            if (alumniDataGridView.Rows.Count > 0)
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
                        if (alumniDataGridView.SelectedRows.Count > 0)
                        {
                            try
                            {
                                int columnCount = alumniDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[alumniDataGridView.SelectedRows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += alumniDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < alumniDataGridView.SelectedRows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += alumniDataGridView.SelectedRows[i - 1].Cells[j].Value.ToString() + ",";
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
                        else if (alumniDataGridView.SelectedRows.Count == 0)
                        {
                            try
                            {
                                int columnCount = alumniDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[alumniDataGridView.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += alumniDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < alumniDataGridView.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += alumniDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
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
            if (filtersAppliedLabel1.Text != "")
            {
                string prompt = "You have filters applied. Only the filtered data will be exported, would you like to proceed?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    exportFunction();
                }
            }
            else if (filtersAppliedLabel1.Text == "")
            {
                exportFunction();
            }
        }

        public void filterAll(string f1 = null, string f2 = null, string f3 = null, string f4 = null, string f5 = null, string f6 = null, string f7 = null,
            string f8 = null, string f9 = null, string f10 = null, Boolean f11 = true, Boolean f12 = true, string f13 = null, string f14 = null)
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(f1))
                filters.Add("Convert([Alumni_ID], 'System.String') LIKE '" + f1 + "%'");

            if (!string.IsNullOrWhiteSpace(f2))
                filters.Add("[First_Name] LIKE '%" + f2 + "%'");

            if (!string.IsNullOrWhiteSpace(f3))
                filters.Add("[Last_Name] LIKE '%" + f3 + "%'");

            if (!string.IsNullOrWhiteSpace(f4))
                filters.Add("[Title] LIKE '%" + f4 + "%'");

            if (!string.IsNullOrWhiteSpace(f5))
                filters.Add("[Street] LIKE '%" + f5 + "%'");

            if (!string.IsNullOrWhiteSpace(f6))
                    filters.Add("[Mobile_Phone] LIKE '%" + f6 + "%'");

            if (!string.IsNullOrWhiteSpace(f7))
                    filters.Add("[Home_Phone] LIKE '%" + f7 + "%'");

            if (!string.IsNullOrWhiteSpace(f8))
                filters.Add("[Email] LIKE '%" + f8 + "%'");

            if (!string.IsNullOrWhiteSpace(f9))
                filters.Add("[City] LIKE '%" + f9 + "%'");

            if (!string.IsNullOrWhiteSpace(f10))
                filters.Add("[Zip_Code] LIKE '%" + f10 + "%'");

            if (f11 == true)
                filters.Add("[Active?] = False");
            if (f12 == true)
                filters.Add("[Active?] = True");

            if (!string.IsNullOrWhiteSpace(f13))
                filters.Add("[Notes] LIKE '%" + f13 + "%'");

            if (!string.IsNullOrWhiteSpace(f14))
                filters.Add("[State] LIKE '%" + f14 + "%'");

            alumniBindingSource.Filter = string.Join(" AND ", filters);
        }

        public void filterLabel()
        {
            filtersAppliedLabel1.Text = savedFilterLabel;
        }
    }
}
