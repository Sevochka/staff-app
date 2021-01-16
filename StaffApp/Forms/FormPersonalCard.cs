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
        DB database;
        bool backToArchive;
        public FormPersonalCard(
            FormPanelMenu pm,
            DB db,
            int id,
            bool backToArc = false
            )
        {
            panelMenu = pm;
            database = db;
            backToArchive = backToArc;
            InitializeComponent();

            setEmployeeInfo(id);
        }


        public void setEmployeeInfo(int id)
        {
            DataTable table = database.getEmployeeFullInfo(id);

            DataRow employee = table.Rows[0];

            int personal_num = employee.Field<int>(0);
            string name = employee.Field<string>(1);
            string surname = employee.Field<string>(2);
            string patr = employee.Field<string>(3);
            string sex = employee.Field<string>(4);
            string family = employee.Field<string>(5);
            string education = employee.Field<string>(6);
            int seniority = employee.Field<int>(7);

            string department = employee.Field<string>("department_name");
            string position = employee.Field<string>("position_name");

            this.Text = "Карточка сотрудника #" + personal_num.ToString();
            //laEmployee.Text = surname + " " + name + " " + patr;

            laName.Text = name;
            laSurname.Text = surname;
            laPatr.Text = patr;
            laSex.Text = sex;
            laFamily.Text = family;
            laObr.Text = education;
            laSeniority.Text = seniority.ToString();
            laDepartment.Text = department;
            laPosition.Text = position;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backToArchive)
            {
                panelMenu.OpenChildForm(new FormArchive(panelMenu, database));
                return;
            }
            panelMenu.Reset();
        }
    }
}
