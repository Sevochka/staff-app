using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace StaffApp.Forms
{
    public partial class FormStaff : Form
    {
        private DataTable employees;

        public void getEmployes()
        {
            employees = database.getEmployees();
            bunifuDataGridView1.DataSource = employees;
            bunifuDataGridView1.Columns[0].Width = 40;
            if (DB.access == "USER")
            {
                return;
            }
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
            bunifuDataGridView1.Columns.Add(btn);
            bunifuDataGridView1.Columns[bunifuDataGridView1.Columns.Count-1].Width = 100; 
        }

        private FormPanelMenu formParent;
        private DB database;
        public FormStaff(FormPanelMenu parentForm, DB db)
        {
            InitializeComponent();
            formParent = parentForm;
            database = db;
            if(DB.access == "USER")
            {
                btnAddEmp.Visible = false;
            }
            getEmployes();
        }


        private void bunifuDataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            int empId = employees.Rows[e.RowIndex].Field<Int32>("№");
            formParent.OpenChildForm(new FormEmployeeCard(formParent, this, database, empId));
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DB.access == "USER")
            {
                return;
            }

            if (bunifuDataGridView1.Columns[e.ColumnIndex].Name == "Удалить" && e.RowIndex != -1)
            {
                if(MessageBox.Show("Вы уверены, что хотите удалить сотрудника?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //string personal_number2 = bunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string personal_number = employees.Rows[e.RowIndex].Field<int>("№").ToString();
                    

                    MySqlCommand command = new MySqlCommand("DELETE from `employee` WHERE `personal_number` = @ul", database.getConnection());
                    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = personal_number;

                    database.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Удалено успешно");
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                    database.closeConnection();
                    bunifuDataGridView1.DataSource = null;
                    bunifuDataGridView1.Columns.Clear();
                    bunifuDataGridView1.Refresh();
                    getEmployes();
                }
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            //FormPanelMenu d = new FormPanelMenu();
            formParent.OpenChildForm(new FormAddStaff(database, formParent));
        }
    }
}
