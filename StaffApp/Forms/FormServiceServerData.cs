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
    public partial class FormServiceServerData : Form
    {
        FormPanelMenu panelMenu;
        DB database;
        ServerData server;
        public FormServiceServerData(FormPanelMenu pm, DB db, ServerData serverData)
        {
            panelMenu = pm;
            database = db;
            server = serverData;
            InitializeComponent();

            inputHost.Text = server.host;
            inputPort.Text = server.port;
            inputUser.Text = server.user;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormServiceMenu(panelMenu, database, server));

        }

        [Obsolete]
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string host = inputHost.Text;
            string port = inputPort.Text;
            string user = inputUser.Text;
            string pass = inputPass.Text;

            if(string.IsNullOrWhiteSpace(host) || 
                string.IsNullOrWhiteSpace(port) || 
                string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(pass)
                )
            {
                MessageBox.Show("Заполните все поля!", "Ошибка валидации");
                return;
            }

            
            server.port = port;
            server.host = host;
            server.user = user;
            server.pass = pass;

            File.WriteAllText("serviceData.json", JsonConvert.SerializeObject(server));
            database.setConnectionData();
            panelMenu.OpenChildForm(new FormServiceMenu(panelMenu, database, server));
            
            MessageBox.Show("Данные сервера успешно изменены!", "Сообщение");
        }
    }
}
