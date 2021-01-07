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
    public partial class FormAddStaff : Form
    {
        private DataTable departmentsTable;
        private DataTable positionsCodes;
        private DB database;
        private FormPanelMenu parentForm;
        public FormAddStaff(DB db, FormPanelMenu pF)
        {
            InitializeComponent();
            database = db;
            parentForm = pF;
            departmentsTable = database.getDepartments();

            foreach (DataRow dr in departmentsTable.Rows)
            {
                dropDepartment.Items.Add(dr.Field<string>(1));
            }
            dropDepartment.SelectedIndex = 0;
            dropSex.SelectedIndex = 0;
            dropFamily.SelectedIndex = 0;
            dropEducation.SelectedIndex = 0;
        }

        private void dropSeniority_SelectedIndexChanged(object sender, EventArgs e)
        {
            UInt32 id = departmentsTable.Rows[dropDepartment.SelectedIndex].Field<UInt32>(0);
            
            positionsCodes = database.getPositionsByDepartmentCode(id);
            dropPosition.Items.Clear();
            foreach (DataRow dr in positionsCodes.Rows)
            {
                int code = dr.Field<int>(0);
                DataTable positionName = database.getPositionByCode(code);
                dropPosition.Items.Add(positionName.Rows[0].Field<string>(0));
            }

            dropPosition.SelectedIndex = 0;
           // MessageBox.Show(dropDepartment.SelectedIndex.ToString());
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            //deppos id
            Int32 depposCode = positionsCodes.Rows[dropPosition.SelectedIndex].Field<Int32>(1);
            UInt32 departmentCode = departmentsTable.Rows[dropDepartment.SelectedIndex].Field<UInt32>(0);
            Int32 positionCode = positionsCodes.Rows[dropPosition.SelectedIndex].Field<Int32>(0);

            String name = inputName.Text;
            String surname = inputSurname.Text;
            String patronymic = inputPatronymic.Text;
            String sex = dropSex.Text;
            String family = dropFamily.Text;
            String education = dropEducation.Text;
            int seniority = Int32.Parse(inputSeniority.Text);
            database.addEmployee(name, surname, patronymic, sex, family, education, seniority, depposCode, departmentCode, positionCode);
            parentForm.OpenChildForm(new FormStaff(parentForm, database));
        }
    }
}
