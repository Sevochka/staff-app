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
    public partial class FormDesktop : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        public FormDesktop(DB db, FormPanelMenu pm)
        {
            InitializeComponent();
            panelMenu = pm;
            database = db;
            laEmployee.Text = "Здравствуйте, "+ DB.currentEmployee.Field<string>("name")+"!";
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panelMenu.hideAll();
            panelMenu.OpenChildForm(new FormLogin(database, panelMenu));
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormChangePassword(database, panelMenu));
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormPersonalCard(panelMenu, database, 15));
        }
    }
}
