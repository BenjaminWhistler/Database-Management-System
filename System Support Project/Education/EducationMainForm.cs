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
using System_Support_Project.Donation;

namespace System_Support_Project.Education
{
    public partial class EducationMainForm : Form
    {

        public static EducationMainForm Instance;
        public static Boolean restrictAdd = false;
        public static Boolean restrictEdit = false;
        public static Boolean restrictView = false;
        public static Boolean restrictFilter = false;
        public static (string f1, string f2, string f3, string f4, string f5) savedFilter;
        public static string savedFilterLabel;
        public EducationMainForm()
        {
            InitializeComponent();
            Instance = this;
        }


        private void EducationMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alumni_Association_DocumentationDataSet.Education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);

        }

        public void loadData()
        {
            this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
        }

        private void EducationMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EducationMainForm.restrictAdd = false;
            EducationMainForm.restrictEdit = false;
            EducationMainForm.restrictFilter = false;
            EducationMainForm.restrictView = false;
        }

        public void filterAll(string f1 = null, string f2 = null, string f3 = null, string f4 = null, string f5 = null)
        {
            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(f1))
                filters.Add("Convert([Education_ID], 'System.String') LIKE '" + f1 + "%'");

            if (!string.IsNullOrWhiteSpace(f2))
                filters.Add("Convert([Alumni_ID], 'System.String') LIKE '" + f2 + "%'");

            if (!string.IsNullOrWhiteSpace(f3))
                filters.Add("[Degree] LIKE '%" + f3 + "%'");

            if (!string.IsNullOrWhiteSpace(f4))
                filters.Add("[Institution] LIKE '%" + f4 + "%'");

            if (int.TryParse(f5, out int date))
                filters.Add("[Graduation_Date]>= #01/01/" + date + "# AND [Graduation_Date] < #01/01/" + (date + 1) + "#");

            try
            {
                educationBindingSource.Filter = string.Join(" AND ", filters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying filters: " + ex.Message);
            }
        }

        public void filterLabel()
        {
            filtersAppliedLabel.Text = savedFilterLabel;
        }

        private void addARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictAdd == false)
            {
                restrictAdd = true;
                EducationAddForm frm = new EducationAddForm();
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
            EducationEditForm frm = new EducationEditForm();

            int rowCount = educationDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only edit one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an education record in the grid to edit.");
            }
            else if (restrictEdit == false)
            {
                int m_id = (int)(educationDataGridView.CurrentRow.Cells[0].Value);
                frm.e_id = m_id;
                restrictEdit = true;
                frm.Owner = this;
                frm.Show();
                this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void viewARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationViewForm frm = new EducationViewForm();

            int rowCount = educationDataGridView.SelectedRows.Count;

            if (rowCount > 1)
            {
                MessageBox.Show("Too many rows selected. You may only view one record at a time.");
            }
            else if (rowCount < 1)
            {
                MessageBox.Show("Use the mouse to select an education record in the grid to view.");
            }
            else if (restrictView == false)
            {
                int m_id = (int)(educationDataGridView.CurrentRow.Cells[0].Value);
                frm.e_id = m_id;
                restrictView = true;
                frm.Owner = this;
                frm.Show();
                this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
            }
            else
            {
                MessageBox.Show("This window is already open!");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowCount = educationDataGridView.SelectedRows.Count;
            if (rowCount > 1)
                MessageBox.Show("Too many rows selected. You may only delete one record at a time.");
            else if (rowCount < 1)
                MessageBox.Show("Use the mouse to select an education record in the grid to delete.");
            else
            {
                int m_id = (int)(educationDataGridView.CurrentRow.Cells[0].Value);
                string prompt = "You are about to delete the Education with id " + m_id + ", Are you sure?";
                DialogResult result = MessageBox.Show(prompt, "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.educationBindingSource.Position = educationBindingSource.Find("Education_ID", m_id);
                    this.educationBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.alumni_Association_DocumentationDataSet);
                    this.educationTableAdapter.Fill(this.alumni_Association_DocumentationDataSet.Education);
                }
            }
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (restrictFilter == false)
            {
                restrictFilter = true;
                EducationFilters frm = new EducationFilters();
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
            if (educationDataGridView.Rows.Count > 0)
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
                        if (educationDataGridView.SelectedRows.Count > 0)
                        {
                            try
                            {
                                int columnCount = educationDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[educationDataGridView.SelectedRows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += educationDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < educationDataGridView.SelectedRows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += educationDataGridView.SelectedRows[i - 1].Cells[j].Value.ToString() + ",";
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
                        else if (educationDataGridView.SelectedRows.Count == 0)
                        {
                            try
                            {
                                int columnCount = educationDataGridView.Columns.Count;
                                string columnNames = "";
                                string[] outputCsv = new string[educationDataGridView.Rows.Count + 1];
                                for (int i = 0; i < columnCount; i++)
                                {
                                    columnNames += educationDataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                                outputCsv[0] += columnNames;

                                for (int i = 1; (i - 1) < educationDataGridView.Rows.Count; i++)
                                {
                                    for (int j = 0; j < columnCount; j++)
                                    {
                                        outputCsv[i] += educationDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
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
