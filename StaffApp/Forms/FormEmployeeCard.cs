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

        public FormEmployeeCard(FormPanelMenu gpf, FormStaff pf, DB db, uint id)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            grandParentForm = gpf;
            parentForm = pf;
            database = db;
            setEmployeeInfo(id);
        }

        public void setEmployeeInfo(uint id)
        {
            DataTable table = database.getEmployeeInfo(id);

            DataRow row = table.Rows[0];
            uint personal_num = row.Field<uint>(0);
            string name = row.Field<string>(1);
            string surname = row.Field<string>(2);
            string patr = row.Field<string>(3);
            string sex = row.Field<string>(4);
            string family = row.Field<string>(5);
            string education = row.Field<string>(6);
            int seniority = row.Field<int>(7);

            this.Text = "Карточка сотрудника #"+personal_num.ToString();
            laEmployee.Text = surname + " " + name + " " + patr;


            inputName.Text = name;
            inputSurname.Text = surname;
            inputPatr.Text = patr;
            dropSex.SelectedIndex = dropSex.Items.IndexOf(sex);
            dropFamily.SelectedIndex = dropFamily.Items.IndexOf(family);
            dropEducation.SelectedIndex = dropEducation.Items.IndexOf(education);
            inputSeniority.Text = seniority.ToString();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grandParentForm.OpenChildForm(new FormStaff(grandParentForm, database));
        }
    }
}
