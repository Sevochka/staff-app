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
    public partial class FormAddStaff_PassData : Form
    {
        private String name;
        private String surname;
        private String patronymic;
        private String sex;
        private String family;
        private String education;
        private int seniority;
        private Int32 depposCode;
        private UInt32 departmentCode;
        private Int32 positionCode;
        private DB database;
        private FormPanelMenu panelMenu;

        public FormAddStaff_PassData(
             String n,
             String sn,
             String patr,
             String s,
             String f,
             String ed,
             int sen,
             Int32 depposc,
             UInt32 departmentC,
             Int32 positionC,
             DB db,
             FormPanelMenu pm
            )
        {
            name = n;
            surname = sn;
            patronymic = patr;
            sex = s;
            family = f;
            education = ed;
            seniority = sen;
            depposCode = depposc;
            departmentCode = departmentC;
            positionCode = positionC;
            database = db;
            panelMenu = pm;

            InitializeComponent();
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            String series = inputSeries.Text;
            String number = inputNumber.Text;
            DateTime date = inputDate.Value;
            String body = inputBody.Text;
            String address = inputAddress.Text;

            

            panelMenu.OpenChildForm(new FormAddStaff_Documents(
                name, surname, patronymic,
                sex, family, education, seniority,
                depposCode, departmentCode, positionCode,
                series, number, date, body, address,
                database, panelMenu
                ));
        }
    }
}
