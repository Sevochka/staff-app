using MySql.Data.MySqlClient;
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
    public partial class FormPosition : Form
    {
        private DataTable departments;
        private FormPanelMenu formParent;
        private DB database;
        private uint SelectedDepartmentID;
        private string SelectedDepartmentName;
        private bool isEditable;

        private string searchStrDepartment;
        private string searchStrPosition;

        public FormPosition(FormPanelMenu parentForm, DB db, Boolean isEdit)
        {
            formParent = parentForm;
            database = db;
            InitializeComponent();
            dataGridPositions.Columns.Add("Название", "Название");
            dataGridPositions.Columns.Add("Оклад", "Оклад");
            isEditable = isEdit;
            getDepartments();
           

            
            if (isEditable)
            {
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
            }
            else
            {
                btnAddDepartment.Visible = false;
                btnAddPosition.Visible = false;
            }
            
            //Значение должностей из первого row

            if(departments.Rows.Count == 0)
            {
                return;
            }
            SelectedDepartmentID = departments.Rows[0].Field<UInt32>("№");
            SelectedDepartmentName = departments.Rows[0].Field<string>(1);
            DataTable positionsIds = database.getPositionsByDepartmentCode(SelectedDepartmentID);
            dataGridPositions.Rows.Clear();


            foreach (DataRow dr in positionsIds.Rows)
            {
                uint code = dr.Field<uint>("position_code");
               
                DataTable posName = database.getPositionByCode(code);

                object[] values = new object[] {
                    posName.Rows[0].Field<string>(0),
                    posName.Rows[0].Field<int>(1).ToString()
                };
                dataGridPositions.Rows.Add(values);
            }
        }

        

        public void getDepartments()
        {
           
            departments = database.getPretifyDepartments(!isEditable);

            List<uint> departmentsCodes = new List<uint>();

            if (!isEditable)
            {
                foreach (DataRow item in departments.Rows)
                {
                    departmentsCodes.Add(item.Field<uint>("№"));
                }
                var positions = database.getHiddenPositions();
                foreach (DataRow item in positions.Rows)
                {
                    uint departmentCode = uint.Parse(item.Field<int>("department_code").ToString());
                    if (!departmentsCodes.Contains(departmentCode))
                    {
                        object[] values = new object[] {
                            departmentCode,
                            item.Field<string>("department_name"),
                            item.Field<string>("department_phone")
                        };
                        departments.Rows.Add(values);
                        departmentsCodes.Add(departmentCode);
                    }
                }
            }
            

            dataGridDepartments.DataSource = departments;

            dataGridDepartments.Columns[0].Width = 50;
            if (isEditable)
            {
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
                dataGridDepartments.Columns.Add(btn);
                dataGridDepartments.Columns[3].Width = 180;
            }
        }

        private void dataGridDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1)
            {
                return;
            }
            SelectedDepartmentID = departments.Rows[e.RowIndex].Field<UInt32>(0);
            SelectedDepartmentName = departments.Rows[e.RowIndex].Field<string>(1);

            fillPositionGrid();
        }

        private void fillPositionGrid()
        {
            DataTable positions = database.getPositionsByDepartmentCode(SelectedDepartmentID, !isEditable);
            dataGridPositions.Rows.Clear();

            foreach (DataRow dr in positions.Rows)
            {
                object[] values = new object[] {
                    dr.Field<string>("name"),
                    dr.Field<int>("salary").ToString()
                };
                dataGridPositions.Rows.Add(values);
            }
        }
        private void dataGridDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDepartments.Columns[e.ColumnIndex].Name == "Удалить" && e.RowIndex != -1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить департамент? Связанные должности так же будут удалены!", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string depId = dataGridDepartments.Rows[e.RowIndex].Cells[1].Value.ToString();
                    database.deleteAllDepPosByDepartmentCode(depId);
                    database.deleteDepartmentByDepartmentCode(depId);
                    database.deletePositionsByDepartmenCode(depId);

                    departments = database.getPretifyDepartments();
                    dataGridDepartments.DataSource = departments;
                }
            }
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            formParent.OpenChildForm(new FormAddPosition(formParent, database, SelectedDepartmentID, SelectedDepartmentName));
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            formParent.OpenChildForm(new FormAddDepartment(formParent, database));
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

        private void dataGridDepartments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || !isEditable)
            {
                return;
            }
            uint depId = departments.Rows[e.RowIndex].Field<UInt32>(0);
            string name = departments.Rows[e.RowIndex].Field<string>(1);
            string phone = departments.Rows[e.RowIndex].Field<string>(2);

            formParent.OpenChildForm(new FormDepartmentCard(formParent, database, depId, name, phone));
        }

        private void inputSearchDepartment_TextChanged(object sender, EventArgs e)
        {
            searchStrDepartment = inputSearchDepartment.Text;

            bool isEnabled = !String.IsNullOrWhiteSpace(searchStrDepartment);

            btnSearchDepartment.Enabled = isEnabled;
            btnCancelDepartment.Enabled = isEnabled;
        }
        private void searchDataGrid(string searchValue, Bunifu.UI.WinForms.BunifuDataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (dataGridView[j, i].FormattedValue.ToString().ToLower().
                    Contains(searchValue.Trim().ToLower()))
                    {
                        dataGridView.CurrentCell = dataGridView[0, i];
                        return;
                    }
                }
            }
        }

        private void inputSearchDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrWhiteSpace(searchStrDepartment))
            {
                searchDataGrid(searchStrDepartment, dataGridDepartments);
            }
        }

        private void btnSearchDepartment_Click(object sender, EventArgs e)
        {
            searchDataGrid(searchStrDepartment, dataGridDepartments);
        }

        private void btnCancelDepartment_Click(object sender, EventArgs e)
        {
            searchStrDepartment = "";
            inputSearchDepartment.Text = searchStrDepartment;
        }

        private void inputSearchPosition_TextChanged(object sender, EventArgs e)
        {
            searchStrPosition = inputSearchPosition.Text;

            bool isEnabled = !String.IsNullOrWhiteSpace(searchStrPosition);

            btnSearchPosition.Enabled = isEnabled;
            btnCancelPosition.Enabled = isEnabled;
        }

        private void inputSearchPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrWhiteSpace(searchStrPosition))
            {
                searchDataGrid(searchStrPosition, dataGridPositions);
            }
        }

        private void btnSearchPosition_Click(object sender, EventArgs e)
        {
            searchDataGrid(searchStrPosition, dataGridPositions);
        }

        private void btnCancelPosition_Click(object sender, EventArgs e)
        {
            searchStrPosition = "";
            inputSearchPosition.Text = searchStrPosition;
        }
    }
}
