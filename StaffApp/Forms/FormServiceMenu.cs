using StaffApp.Classes;
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
    public partial class FormServiceMenu : Form
    {
        FormPanelMenu panelMenu;
        DB database;
        ServerData server;
        public FormServiceMenu(FormPanelMenu pm, DB db, ServerData serverData)
        {
            panelMenu = pm;
            database = db;
            server = serverData;
            InitializeComponent();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormServiceServerData(panelMenu, database, server));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormServiceChangeServAdmin(panelMenu, database, server));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormLogin(database, panelMenu));
        }
    }
}
