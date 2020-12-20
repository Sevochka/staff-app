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
        private DataTable table;
        public FormStaff()
        {
            InitializeComponent();

            DB db = new DB();

            table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT personal_number AS 'Таб.номер', name AS 'Имя', surname AS 'Фамилия' FROM `employee`", db.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);
           

            bunifuDataGridView1.DataSource = table;

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

        }


        private void bunifuDataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            this.Hide();
            FormDocs form = new FormDocs();
            form.Show();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            //MessageBox.Show(bunifuDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());



            if (bunifuDataGridView1.Columns[e.ColumnIndex].Name == "Удалить")
            {
                if(MessageBox.Show("Вы уверены, что хотите удалить сотрудника?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DB db = new DB();
                   
                    string personal_number = bunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    
                    MySqlCommand command = new MySqlCommand("DELETE from `employee` WHERE `personal_number` = @ul", db.getConnection());
                   command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = personal_number;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Удалено успешно");
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                    db.closeConnection();
                }
            }
        }
    }
}
