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
    public partial class FormAddDepartment : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        private DataTable departments;
        public FormAddDepartment(FormPanelMenu pm, DB db)
        {
            database = db;
            panelMenu = pm;
            InitializeComponent();
            getDepartments();
        }

        public void getDepartments()
        {
            departments = database.getPretifyDepartments();
            dataGridDepartments.DataSource = departments;
            dataGridDepartments.Columns[0].Width = 50;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            database.addDepartment(inputName.Text, inputPhone.Text);
            getDepartments();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database));
        }
    }
}
