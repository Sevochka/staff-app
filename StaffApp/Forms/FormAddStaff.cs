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
        private DataTable positions;
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

            if (!DB.IsEmpty(DB.chosenEmployeeAlreadyWorked))
            {
                DataRow emp = DB.chosenEmployeeAlreadyWorked;
                inputName.Text = emp.Field<string>("name");
                inputSurname.Text = emp.Field<string>("surname");
                inputPatronymic.Text = emp.Field<string>("patronymic");
                dropSex.SelectedItem = emp.Field<string>("sex");
                dropFamily.SelectedItem = emp.Field<string>("family_status");
                dropEducation.SelectedItem = emp.Field<string>("education");
                inputSeniority.Text = emp.Field<int>("seniority").ToString();
                string departmentName = emp.Field<string>("department_name").ToString();
                if (dropDepartment.Items.IndexOf(departmentName) != -1)
                {
                    dropDepartment.SelectedIndex = dropDepartment.Items.IndexOf(departmentName);
                }
                checkInputs();
            }
        }

        private void dropSeniority_SelectedIndexChanged(object sender, EventArgs e)
        {
            UInt32 id = departmentsTable.Rows[dropDepartment.SelectedIndex].Field<UInt32>(0);
            
            positions = database.getPositionsByDepartmentCode(id);
            dropPosition.Items.Clear();
            if (positions.Rows.Count == 0)
            {
                laPos.Visible = true;
                dropPosition.Visible = false;
                return;
            }
            foreach (DataRow dr in positions.Rows)
            {
                int code = dr.Field<int>(0);
                //DataTable positionName = database.getPositionByCode(code);
                dropPosition.Items.Add(dr.Field<string>("name"));
            }
            laPos.Visible = false;
            dropPosition.Visible = true;
            if (!DB.IsEmpty(DB.chosenEmployeeAlreadyWorked))
            {
                string posName = DB.chosenEmployeeAlreadyWorked.Field<string>("position_name").ToString();
                if (dropPosition.Items.IndexOf(posName) != -1)
                {
                    dropPosition.SelectedIndex = dropPosition.Items.IndexOf(posName);
                }
                else
                {
                    dropPosition.SelectedIndex = 0;
                }
            }
            else
            {
                dropPosition.SelectedIndex = 0;
            }
                
        }

        private void checkInputs()
        {
            string name = inputName.Text;
            string surname = inputSurname.Text;
            string patr = inputPatronymic.Text;
            string seniority = inputSeniority.Text;

            
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(patr) ||
                string.IsNullOrWhiteSpace(seniority)
                )
            {
                btnCreateEmp.Enabled = false;
            }
            else
            {
                btnCreateEmp.Enabled = true;
            }
        }
        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            int a;

            if (!int.TryParse(inputSeniority.Text, out a))
            {
                MessageBox.Show("Значение в поле стаж не может быть преобразовано в число");
                return;
            }

             //deppos id
            Int32 depposCode = positions.Rows[dropPosition.SelectedIndex].Field<Int32>("id");
            UInt32 departmentCode = departmentsTable.Rows[dropDepartment.SelectedIndex].Field<UInt32>(0);
            uint positionCode = positions.Rows[dropPosition.SelectedIndex].Field<uint>("position_code");

            String position = dropPosition.SelectedItem.ToString();
            String department = dropDepartment.SelectedItem.ToString();

            String name = inputName.Text;
            String surname = inputSurname.Text;
            String patronymic = inputPatronymic.Text;
            String sex = dropSex.Text;
            String family = dropFamily.Text;
            String education = dropEducation.Text;

            
            int seniority = Int32.Parse(inputSeniority.Text);

            parentForm.OpenChildForm(new FormAddStaff_PassData(
                name, surname, patronymic, 
                sex, family, education, seniority, 
                depposCode, departmentCode, int.Parse(positionCode.ToString()),
                database, parentForm,
                position, department
                ));
        }

        private void inputName_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputSurname_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputPatronymic_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputSeniority_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void btnUserWorked_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new FormAddStaff_HiddenUser(parentForm, database));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new FormStaff(parentForm, database));
        }
    }
}
