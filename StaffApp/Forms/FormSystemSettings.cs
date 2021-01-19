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
    public partial class FormSystemSettings : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        private DataTable employees;
        private int SelectedIndex;
        private string SelectedAccess;
        private int SelectedPersonalCode;
        public FormSystemSettings(FormPanelMenu pm, DB db)
        {
            panelMenu = pm;
            database = db;
            InitializeComponent();
            getEmployes();
        }
        public void getEmployes()
        {
            employees = database.getEmployeesShort();
            dataEmployees.DataSource = employees;
            if (employees.Rows.Count > 0)
            {
                setValues(0);
            }
        }

        private void dataEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void setComboBoxValue()
        {
            if(SelectedAccess == "USER+")
            {
                dropAccess.SelectedIndex = 1;
                return;
            }
            if (SelectedAccess == "ADMIN")
            {
                dropAccess.SelectedIndex = 2;
                return;
            }
            dropAccess.SelectedIndex = 0;
        }

        private void setValues(int rowIndex)
        {
            SelectedPersonalCode = employees.Rows[rowIndex].Field<Int32>("№");
            SelectedAccess = employees.Rows[rowIndex].Field<string>("Уровень доступа");
            setComboBoxValue();
        }
        private void dataEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            setValues(e.RowIndex);
        }

        
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            database.updateAccess((string)dropAccess.SelectedItem, SelectedPersonalCode);
            getEmployes();
        }

        private void dropAccess_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if ((string)dropAccess.SelectedItem == SelectedAccess)
            {
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            database.removeUser(SelectedPersonalCode);
            getEmployes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            database.clearAllData();
            Application.Exit();
        }

        
    }
}
