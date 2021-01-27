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
    public partial class FormPositionCard : Form
    {
        private bool editFlag = false;
        FormPanelMenu panelMenu;
        DB database;
        uint id;
        string name;
        string salary;
        uint departmentCode;
        bool hidden;

        public FormPositionCard(
            FormPanelMenu pm, 
            DB db,
            uint posId, 
            string posName, 
            string posSalary,
            uint depCode,
            bool hid
            )
        {
            panelMenu = pm;
            database = db;
            id = posId;
            name = posName;
            salary = posSalary;
            hidden = hid;
            departmentCode = depCode;

            InitializeComponent();
            setPositionInfo();
        }

        public void setPositionInfo()
        {

            this.Text = "Карточка должности - " + name;
            laPosition.Text = name;

            inputName.Text = name;
            inputSalary.Text = salary;

            DataTable employees = database.getEmployeesByPosition(id, hidden);

            if (employees.Rows.Count < 1)
            {
                laNoEmployees.Visible = true;
                dataGridStaff.Visible = false;
            }

            dataGridStaff.DataSource = employees;

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
            changeInputView(inputSalary);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database, !hidden));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iName = inputName.Text;
            string iSalary = inputSalary.Text;
            if (iName == name && iSalary == salary)
            {
                MessageBox.Show("Данные не были изменены, сохранение не возможно!", "Ошибка валидации");
                return;
            }
            if (string.IsNullOrWhiteSpace(iName) || string.IsNullOrWhiteSpace(iSalary))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка валидации");
                return;
            }

            int res;
            if (!int.TryParse(iSalary, out res))
            {
                MessageBox.Show("Поле оклад должно принимать числовое значение!", "Ошибка валидации");
                return;
            }

            database.updatePosition(id, iName, iSalary);
            database.addPosition(name, int.Parse(salary), true);
            DataTable table = database.getPositionCodeByData(name, int.Parse(salary));
            uint posCode = table.Rows[0].Field<uint>("position_code");
            database.addDepPos(departmentCode, posCode, true);
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database, !hidden));
        }
    }
}
