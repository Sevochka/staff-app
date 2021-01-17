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

namespace StaffApp.Forms
{
    public partial class FormServiceChangeServAdmin : Form
    {
        FormPanelMenu panelMenu;
        DB database;
        ServerData server;
        public FormServiceChangeServAdmin(FormPanelMenu pm, DB db, ServerData serverData)
        {
            panelMenu = pm;
            database = db;
            server = serverData;
            InitializeComponent();
            inputLogin.Text = server.adminLogin;
            inputPassword.Text = server.adminPassword;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormServiceMenu(panelMenu, database, server));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string login = inputLogin.Text;
            string pass = inputPassword.Text;
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Поля пустые.", "Ошибка валидации");
                return;
            }
            if (login == server.adminLogin && pass == server.adminPassword)
            {
                MessageBox.Show("Данные не были изменены.", "Ошибка валидации");
                return;
            }
            server.adminLogin = login;
            server.adminPassword = pass;

            File.WriteAllText("serviceData.json", JsonConvert.SerializeObject(server));
        }
    }
}
