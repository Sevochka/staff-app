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
    public partial class FormLeaveOrder : Form
    {
        private int personalNumber;
        private string fullName;
        private string department;
        private string position;
        private FormPanelMenu panelMenu;
        private DB database;
        public FormLeaveOrder(int persNum, string FIO, string dep, 
            string pos, FormPanelMenu pm, DB db)
        {
            personalNumber = persNum;
            fullName = FIO;
            department = dep;
            position = pos;
            panelMenu = pm;
            database = db;
            InitializeComponent();
        }

        private void FormLeaveOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reason = inputReason.Text;
            string osn = inputOsn.Text;

            

            Documents.CreateLeaveOrder(
                        DateTime.Now, DateTime.Now, DateTime.Now,
                        personalNumber, fullName, department, position, reason, osn
                        );

            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
            database.removeUser(personalNumber, fullName);
        }

        private void inputReason_TextChange(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(inputReason.Text) && string.IsNullOrWhiteSpace(inputOsn.Text))
            {
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;
        }

        private void inputOsn_TextChange(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputReason.Text) && string.IsNullOrWhiteSpace(inputOsn.Text))
            {
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }
    }
}
