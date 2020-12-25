using FontAwesome.Sharp;
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

namespace StaffApp
{
    public partial class FormLogin : Form
    {
        private DB database;
        public FormLogin(DB db)
        {
            InitializeComponent();
            database = db;
        }


        private void iconUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `personal_number` = @uL AND `autorization_pass` = @uP", database.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Удачная авторизация! Добро пожаловать!");
                this.Hide();
                FormPanelMenu panelMenu = new FormPanelMenu(database);
                panelMenu.Show();
            }
            else
                MessageBox.Show("Проверьте правильность вводимых данных");
        }

        //Control buttons
        private void ResetBtnColor(IconPictureBox button)
        {
            button.ForeColor = Color.Gainsboro;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            ResetBtnColor(btnClose);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.ForeColor = Color.FromArgb(17, 135, 221);
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            ResetBtnColor(btnMaximize);
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(9, 203, 203);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            ResetBtnColor(btnMinimize);
        }
    }
}
