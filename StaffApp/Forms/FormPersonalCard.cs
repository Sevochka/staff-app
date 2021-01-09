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
    public partial class FormPersonalCard : Form
    {
        FormPanelMenu panelMenu;
        public FormPersonalCard(FormPanelMenu pm)
        {
            panelMenu = pm;
            InitializeComponent();
            laName.Text = DB.currentEmployee.Field<string>("name");
            laSurname.Text = DB.currentEmployee.Field<string>("surname");
            laPatr.Text = DB.currentEmployee.Field<string>("patronymic");
            laSex.Text = DB.currentEmployee.Field<string>("sex");
            laFamily.Text = DB.currentEmployee.Field<string>("family_status");
            laObraz.Text = DB.currentEmployee.Field<string>("education");
            laSenior.Text = DB.currentEmployee.Field<int>("seniority").ToString();
            laDepartment.Text = DB.currentEmployee.Field<string>("department_name");
            laPosition.Text = DB.currentEmployee.Field<string>("position_name");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.Reset();
        }
    }
}
