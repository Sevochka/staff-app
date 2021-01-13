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
        public FormArchive(FormPanelMenu pm, DB db)
        {
            panelMenu = pm;
            database = db;
            InitializeComponent();
            employees = database.getEmployees(true);
            dataGridEmployees.DataSource = employees;
            dataGridEmployees.Columns[0].Width = 40;
        }

        private void dataGridEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int empId = employees.Rows[e.RowIndex].Field<Int32>("№");
            //panelMenu.OpenChildForm(new FormEmployeeCard(formParent, this, database, empId));
            panelMenu.OpenChildForm(new FormPersonalCard(panelMenu, database, empId));
        }

        private void btnArchivePositionsDepartments_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database, false));
        }
    }
}
