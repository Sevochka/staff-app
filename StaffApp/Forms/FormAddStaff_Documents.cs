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
    public partial class FormAddStaff_Documents : Form
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
        string series;
        string number;
        DateTime date;
        string body;
        string address;
        private DB database;
        private FormPanelMenu panelMenu;

        public FormAddStaff_Documents(
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
             string ser, 
             string num,
             DateTime da, 
             string bo,
             string add,
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
            series = ser;
            number = num;
            date = da;
            body = bo;
            address = add;

            InitializeComponent();
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {
            database.addEmployee(
                name, surname, patronymic,
                sex, family, education, seniority,
                depposCode, departmentCode,
                positionCode, series, number, date, body, address);

            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }

        private void btnAgrement_Click(object sender, EventArgs e)
        {
            Documents.createСonsentProcessingOfPersonalData(
                dpDocument.Value,
                surname + " "+name + " " + patronymic,
                address,
                series,
                number,
                date,
                body
                );
            btnLaborContract.Enabled = true;
        }

        private void btnLaborContract_Click(object sender, EventArgs e)
        {
            btnCreateEmp.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }
    }
}
