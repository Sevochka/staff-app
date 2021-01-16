using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffApp.Forms
{
    public partial class FormArchive : Form
    {
        FormPanelMenu panelMenu;
        DB database;
        DataTable employees;
        private string searchText;
        public FormArchive(FormPanelMenu pm, DB db)
        {
            panelMenu = pm;
            database = db;
            InitializeComponent();
            employees = database.getEmployees(true);
            dataGridEmployees.DataSource = employees;
            dataGridEmployees.Columns[0].Width = 50;
        }

        private void dataGridEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int empId = employees.Rows[e.RowIndex].Field<Int32>("№");
            //panelMenu.OpenChildForm(new FormEmployeeCard(formParent, this, database, empId));
            panelMenu.OpenChildForm(new FormPersonalCard(panelMenu, database, empId, true));
        }

        private void btnArchivePositionsDepartments_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database, false));
        }
        private void searchDataGrid(string searchValue)
        {
            for (int i = 0; i < dataGridEmployees.RowCount; i++)
            {
                for (int j = 0; j < dataGridEmployees.ColumnCount; j++)
                {
                    if (dataGridEmployees[j, i].FormattedValue.ToString().ToLower().
                    Contains(searchValue.Trim().ToLower()))
                    {
                        dataGridEmployees.CurrentCell = dataGridEmployees[0, i];
                        return;
                    }
                }
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            searchText = inputSearch.Text;
            bool isEnabled = !String.IsNullOrWhiteSpace(searchText);

            btnSearch.Enabled = isEnabled;
            btnCancel.Enabled = isEnabled;
        }

        private void inputSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrWhiteSpace(searchText))
            {
                searchDataGrid(searchText);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            searchText = "";
            inputSearch.Text = searchText;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchDataGrid(searchText);
        }
    }
}
