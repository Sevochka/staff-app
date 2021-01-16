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
    public partial class FormEmployeeCard_PassData : Form
    {
        int personal_num;
        string name;
        string surname;
        string patr;
        string sex;
        string family;
        string edu;
        string seniority;
        uint depCode;
        int posCode;
        int depposId;
        DataRow employee;
        FormPanelMenu panelMenu;
        DB database;

        public FormEmployeeCard_PassData(
            int personal, 
            string n,
            string sur,
            string p,
            string s,
            string fam,
            string ed, 
            string sen, 
            uint depCod, 
            int posCod, 
            int deppos,
            DataRow emp, 
            FormPanelMenu pm, 
            DB db
            )
        {
            InitializeComponent();

            personal_num = personal;
            name = n;
            surname = sur;
            patr = p;
            sex = s;
            family = fam;
            edu = ed;
            seniority = sen;
            depCode = depCod;
            posCode = posCod;
            depposId = deppos;
            employee = emp;
            panelMenu = pm;
            database = db;

            inputSeries.Text = employee.Field<string>("pass_series");
            inputBody.Text = employee.Field<string>("pass_body");
            inputNumber.Text = employee.Field<string>("pass_num");
            inputAddress.Text = employee.Field<string>("reg_address");
            inputDate.Value = employee.Field<DateTime>("pass_date");
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            string series = inputSeries.Text;
            string body = inputBody.Text;
            string number = inputNumber.Text;
            string address = inputAddress.Text;
            DateTime date = inputDate.Value;

            database.updateEmployee(
               personal_num,
               name, surname, patr, sex, family, edu, 
               seniority, depCode, posCode, depposId,
               series, body, number, address, date
               );

            database.addEmployee(
                employee.Field<string>("name"),
                employee.Field<string>("surname"),
                employee.Field<string>("patronymic"),
                employee.Field<string>("sex"),
                employee.Field<string>("family_status"),
                employee.Field<string>("education"),
                employee.Field<int>("seniority"),
                employee.Field<int>("deppos_id"),
                 uint.Parse(employee.Field<int>("department_code").ToString()),
                employee.Field<int>("position_code"),
                employee.Field<string>("pass_series"),
                employee.Field<string>("pass_num"),
                employee.Field<DateTime>("pass_date"), 
                employee.Field<string>("pass_body"),
                employee.Field<string>("reg_address"), 
                employee.Field<string>("access"), 
                "hidden", true
                );

            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }
    }
}
