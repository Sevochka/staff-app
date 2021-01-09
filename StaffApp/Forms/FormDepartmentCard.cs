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
    public partial class FormDepartmentCard : Form
    {
        private FormPanelMenu panelMenu;
       
        private DB database;
        private bool editFlag = false;
        private uint id;
        private string name;
        private string phone;

        public FormDepartmentCard(FormPanelMenu pm, DB db, uint depId, string depName, string depPhone)
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            panelMenu = pm;
            database = db;
            id = depId;
            name = depName;
            phone = depPhone;
            setDepartmentInfo();


            dataGridPositions.Columns.Add("Название", "Название");
            dataGridPositions.Columns.Add("Оклад", "Оклад");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Удаление";
            btn.Name = "Удалить";
            btn.Text = "Удалить";
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;

            //btn.DefaultCellStyle.ForeColor = Color.White;
            //btn.DefaultCellStyle.BackColor = Color.Red;
            btn.DefaultCellStyle.SelectionBackColor = Color.Red;
            btn.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridPositions.Columns.Add(btn);
            dataGridPositions.Columns[1].Width = 100;
            dataGridPositions.Columns[2].Width = 180;

            fillPositionGrid();
        }

        public void setDepartmentInfo()
        {

            this.Text = "Карточка Департамента - " + name;
            laDepartment.Text = name;

            inputName.Text = name;
            inputPhone.Text = phone;
           
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
            changeInputView(inputPhone);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setPreviousPage();
        }

        private void setPreviousPage()
        {
            panelMenu.OpenChildForm(new FormPosition(panelMenu, database));
        }

        private void fillPositionGrid()
        {
            DataTable positionsIds = database.getPositionsByDepartmentCode(id);
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

        private void dataGridPositions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridPositions.Columns[e.ColumnIndex].Name == "Удалить" && e.RowIndex != -1)
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить должность?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string posName = dataGridPositions.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string salary = dataGridPositions.Rows[e.RowIndex].Cells[1].Value.ToString();

                        DataTable position = database.getPositionCodeByData(posName, int.Parse(salary));
                        uint positionId = position.Rows[0].Field<uint>(0);
                        database.deleteAllDepPosByPositionCode(positionId);
                        database.deletePositionByCode(positionId);
                        fillPositionGrid();
                    }
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.updateDepartment(id, inputName.Text, inputPhone.Text);
            setPreviousPage();
        }
    }
}
