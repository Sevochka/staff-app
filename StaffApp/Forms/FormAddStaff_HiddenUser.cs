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
    public partial class FormAddStaff_HiddenUser : Form
    {
        FormPanelMenu panelMenu;
        DB database;
        DataTable employees;
        int chosenEmpCode;
        private string searchText;
        public FormAddStaff_HiddenUser(FormPanelMenu pm, DB db)
        {
            panelMenu = pm;
            database = db;
            InitializeComponent();
            employees = database.getEmployees(true);
            dataGridEmployees.DataSource = employees;
            dataGridEmployees.Columns[0].Width = 50;

            if (employees.Rows.Count > 0)
            {
                dataGridEmployees.CurrentCell = dataGridEmployees[0, 0];
                setInputChosen(0);
            }
        }

        private void setInputChosen(int index)
        {
            chosenEmpCode = employees.Rows[index].Field<Int32>("№");
            string name = employees.Rows[index].Field<string>("Имя");
            string surname = employees.Rows[index].Field<string>("Фамилия");

            inputFullName.Text = surname + " " + name;
        }
        private void dataGridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            setInputChosen(e.RowIndex);
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormAddStaff(database, panelMenu));
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            DB.chosenEmployeeAlreadyWorked = database.getEmployeeFullInfo(chosenEmpCode).Rows[0];
            panelMenu.OpenChildForm(new FormAddStaff(database, panelMenu));
        }
    }
}
