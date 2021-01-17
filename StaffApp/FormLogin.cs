using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using StaffApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffApp
{
    public partial class FormLogin : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        public FormLogin(DB db, FormPanelMenu pM)
        {
            InitializeComponent();
            database = db;
            panelMenu = pM;

            try
            {
                database.getDepartments();
                laConnection.Text = "Подключение к серверу стабильное.";
                laConnection.ForeColor = Color.Green;
            }
            catch
            {
                laConnection.Text = "Подключение к серверу отсутсвует.";
                laConnection.ForeColor = Color.Red;
            }
        }


        private void iconUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;
            if (String.IsNullOrWhiteSpace(loginUser) || String.IsNullOrWhiteSpace(passUser))
            {
                MessageBox.Show("Для входа в систему необходимо заполнить оба поля.", "Ошибка валидации");
                return;
            }

            ServerData server = DB.server;


            if (loginUser == server.adminLogin && passUser == server.adminPassword)
            {
                panelMenu.OpenChildForm(new Forms.FormServiceMenu(panelMenu, database, server));
                return;
            }

            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT e.personal_number, e.name, e.surname, e.patronymic, e.sex, e.family_status, e.education, e.seniority, e.autorization_pass, e.deppos_id, e.position_code, e.department_code, e.pass_series,e.pass_num,e.pass_body,e.reg_address,e.pass_date,e.access,d.name as 'department_name',d.phone as 'department_phone',p.name as 'position_name',p.salary as 'position_salary'FROM employee e JOIN position p ON e.position_code = p.position_code JOIN department d ON e.department_code = d.department_code WHERE e.personal_number = @uL AND e.autorization_pass = @uP", database.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к серверу. Воспользуйтесь сервисным меню, введя логин и пароль сервисного администратора!", "Ошибка подключения");
                return;
            }
           

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Удачная авторизация! Добро пожаловать!");
                DB.currentEmployee = table.Rows[0];
                DB.isLogged = true;
                panelMenu.InitializeSignIn();
               // this.Hide();
                //FormPanelMenu panelMenu = new FormPanelMenu(database);
                //panelMenu.Show();
            }
            else
                MessageBox.Show("Проверьте правильность вводимых данных");
        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox2.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bunifuCheckBox2.Checked = !bunifuCheckBox2.Checked;
        }

        //Control buttons

    }
}
