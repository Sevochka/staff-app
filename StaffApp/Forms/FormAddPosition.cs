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
    public partial class FormAddPosition : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        private uint departmentId;
        public FormAddPosition(FormPanelMenu pm, DB db, uint depId, string depName)
        {
            database = db;
            panelMenu = pm;
            departmentId = depId;
            InitializeComponent();
            laDepName.Text = depName;
            dataGridPositions.Columns.Add("Название", "Название");
            dataGridPositions.Columns.Add("Зарплата", "Зарплата");
            fillDataGridPositions();
        }

        private void fillDataGridPositions()
        {
            DataTable positionsIds = database.getPositionsByDepartmentCode(departmentId);
            dataGridPositions.Rows.Clear();

            foreach (DataRow dr in positionsIds.Rows)
            {
                int code = dr.Field<int>(0);
                DataTable posName = database.getPositionByCode(code);
                object[] values = new object[] {
                    posName.Rows[0].Field<string>(0),
                    posName.Rows[0].Field<int>(1).ToString()
                };
                dataGridPositions.Rows.Add(values);
            }

        }

        private void btnCreatePosition_Click(object sender, EventArgs e)
        {
            database.addPosition(inputName.Text, Int32.Parse(inputSalary.Text));
            DataTable position = database.getPositionCodeByData(inputName.Text, Int32.Parse(inputSalary.Text));
            uint positionId = position.Rows[0].Field<uint>(0);
            database.addDepPos(departmentId, positionId);
            fillDataGridPositions();
            inputName.Text = "";
            inputSalary.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database));
        }

        private void checkInputs()
        {
            string name = inputName.Text;
            string salary = inputSalary.Text;

            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(salary) 
                )
            {
                int a;
                if (int.TryParse(salary, out a))
                {
                    btnCreatePosition.Enabled = true;
                    return;
                }

            }
            btnCreatePosition.Enabled = false;
        }

        private void inputName_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputSalary_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }
    }
}
