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
    public partial class FormLeave : Form
    {
        FormPanelMenu panelMenu;
        DB database;
        public FormLeave(FormPanelMenu pm, DB db)
        {
            panelMenu = pm;
            database = db;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormDocs(panelMenu, database));
        }

        private void inputReason_TextChange(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(inputReason.Text))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = DB.currentEmployee.Field<string>("surname") + " " +
                DB.currentEmployee.Field<string>("name") + " " + DB.currentEmployee.Field<string>("patronymic");
            string position = DB.currentEmployee.Field<string>("position_name");
            string department = DB.currentEmployee.Field<string>("department_name");
            DateTime data_when = dpLeave.Value;
            string reason = inputReason.Text;
            DateTime currentDate = DateTime.Now;

            Documents.CreateLeave(fullName, position, department, data_when, reason, currentDate);

            panelMenu.OpenChildForm(new FormDocs(panelMenu, database));
        }
    }
}
