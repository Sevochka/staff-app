﻿using System;
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
        private string position;
        private string department;

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
             FormPanelMenu pm,
             String pos,
             String dep
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

            position = pos;
            department = dep;

            InitializeComponent();

            if (!DB.IsEmpty(DB.chosenEmployeeAlreadyWorked))
            {
                DataRow emp = DB.chosenEmployeeAlreadyWorked;
                inputSeries.Text = emp.Field<string>("pass_series");
                inputNumber.Text = emp.Field<string>("pass_num");
                inputDate.Value = emp.Field<DateTime>("pass_date");
                inputBody.Text = emp.Field<string>("pass_body");
                inputAddress.Text = emp.Field<string>("reg_address");

                DB.chosenEmployeeAlreadyWorked = null;
                checkInputs();
            }
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
                database, panelMenu,
                position, department
                ));
        }
        private void checkInputs()
        {
            string series = inputSeries.Text;
            string number = inputNumber.Text;
            string body = inputBody.Text;
            string address = inputAddress.Text;

            
            if (!string.IsNullOrWhiteSpace(address) &&
                !string.IsNullOrWhiteSpace(body) &&
                series.Length == 4 &&
                number.Length == 6
                )
            {
                int a;
                int b;
                if(int.TryParse(series, out a) && int.TryParse(number, out b))
                {
                    btnCreateEmp.Enabled = true;
                    return;
                }
                
            }
            btnCreateEmp.Enabled = false;
        }

        private void inputSeries_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputNumber_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputBody_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void inputAddress_TextChange(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }
    }
}
