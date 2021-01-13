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
    public partial class FormEmployeeCard : Form
    {
        private FormPanelMenu grandParentForm;
        private FormStaff parentForm;
        private DB database;
        private bool editFlag = false;
        private DataTable departmentsTable;
        private DataTable position;
        private DataRow employee;

        public FormEmployeeCard(FormPanelMenu gpf, FormStaff pf, DB db, int id)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            grandParentForm = gpf;
            parentForm = pf;
            database = db;

            departmentsTable = database.getDepartments();

            foreach (DataRow dr in departmentsTable.Rows)
            {
                dropDep.Items.Add(dr.Field<string>(1));
            }
            
            setEmployeeInfo(id);
        }

        public void setEmployeeInfo(int id)
        {
            DataTable table = database.getEmployeeFullInfo(id);

            employee = table.Rows[0];
           
            int personal_num = employee.Field<int>(0);
            string name = employee.Field<string>(1);
            string surname = employee.Field<string>(2);
            string patr = employee.Field<string>(3);
            string sex = employee.Field<string>(4);
            string family = employee.Field<string>(5);
            string education = employee.Field<string>(6);
            int seniority = employee.Field<int>(7);

            string department = employee.Field<string>("department_name");
            string position = employee.Field<string>("position_name");

            this.Text = "Карточка сотрудника #"+personal_num.ToString();
            laEmployee.Text = surname + " " + name + " " + patr;


            inputName.Text = name;
            inputSurname.Text = surname;
            inputPatr.Text = patr;
            dropSex.SelectedIndex = dropSex.Items.IndexOf(sex);
            dropFamily.SelectedIndex = dropFamily.Items.IndexOf(family);
            dropEducation.SelectedIndex = dropEducation.Items.IndexOf(education);
            inputSeniority.Text = seniority.ToString();

            dropDep.SelectedIndex = dropDep.Items.IndexOf(department);
            dropPos.SelectedIndex = dropPos.Items.IndexOf(position);
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
        private void makeDefaultInputView(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox input)
        {
            input.BorderColorActive = Color.DodgerBlue;
            input.BorderColorHover = Color.LightBlue;
            //input.BorderColorIdle = Color.White;

            input.Cursor = Cursors.IBeam;
            input.ReadOnly = false;
        }

        private void makeReadonlyInputView(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox input)
        {
            input.BorderColorActive = Color.FromArgb(34, 33, 74);
            input.BorderColorHover = Color.FromArgb(34, 33, 74);
            //input.BorderColorIdle = Color.FromArgb(34, 33, 74);

            input.Cursor = Cursors.Default;
            input.ReadOnly = true;
        }

        private void changeInputView(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox input)
        {
            if (editFlag)
            {
                makeDefaultInputView(input);
            }
            else
            {
                makeReadonlyInputView(input);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editFlag = !editFlag;
            Color btnBackColor;
            FontAwesome.Sharp.IconChar currentIcon;
            if (editFlag)
            {
                btnBackColor = Color.Red;
                currentIcon = FontAwesome.Sharp.IconChar.Undo;
            }
            else
            {
                btnBackColor = Color.FromArgb(54, 91, 226);
                currentIcon = FontAwesome.Sharp.IconChar.Edit;
            }

            btnEdit.IconChar = currentIcon;
            btnEdit.BackColor = btnBackColor;

            changeInputView(inputName);
            changeInputView(inputSurname);
            changeInputView(inputPatr);
            changeInputView(inputSeniority);

            dropSex.Enabled = editFlag;
            dropEducation.Enabled = editFlag;
            dropFamily.Enabled = editFlag;
            dropDep.Enabled = editFlag;
            dropPos.Enabled = editFlag;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grandParentForm.OpenChildForm(new FormStaff(grandParentForm, database));
        }

        private void dropDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                UInt32 id = departmentsTable.Rows[dropDep.SelectedIndex].Field<UInt32>(0);

                position = database.getPositionsByDepartmentCode(id);
                dropPos.Items.Clear();
            
            if(position.Rows.Count == 0)
            {
                laPos.Visible = true;
                dropPos.Visible = false;
                return;
            } 
            foreach (DataRow dr in position.Rows)
               {
                    int code = dr.Field<int>(0);
                    //DataTable positionName = database.getPositionByCode(code);
                    dropPos.Items.Add(position.Rows[0].Field<string>("name"));
                }
            laPos.Visible = false;
            dropPos.Visible = true;
            dropPos.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UInt32 depCode = departmentsTable.Rows[dropDep.SelectedIndex].Field<UInt32>(0);
            int posCode = position.Rows[dropPos.SelectedIndex].Field<int>("position_code");

            DataTable deppostable = database.getDepPosByCodes(depCode, posCode);

            int depposId = deppostable.Rows[0].Field<int>(0);

            string name = inputName.Text;
            string surname = inputSurname.Text;
            string patr = inputPatr.Text;
            string sex = dropSex.Text;
            string family = dropFamily.Text;
            string edu = dropEducation.Text;
            string seniority = inputSeniority.Text;

            int personal_num = employee.Field<int>(0);

            database.updateEmployee(
                personal_num,
                name, surname, patr, sex, family, edu, seniority, depCode, posCode, depposId
                );

            grandParentForm.OpenChildForm(new FormStaff(grandParentForm, database));
        }
    }
}
