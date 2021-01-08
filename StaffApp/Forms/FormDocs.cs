﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateEngine.Docx;

namespace StaffApp.Forms
{
    public partial class FormDocs : Form
    {
        private FormPanelMenu panelMenu;
        private DB database;

        public FormDocs(FormPanelMenu pM, DB db)
        {
            panelMenu = pM;
            database = db;
            InitializeComponent();
        }

        private string getMainDate()
        {
            return DateTime.Now.Date.ToString("dd MMMM yyyy");
        }
        public static string GetDeclension(int number, string nominativ, string genetiv, string plural)
        {
            number = number % 100;
            if (number >= 11 && number <= 19)
            {
                return plural;
            }

            var i = number % 10;
            switch (i)
            {
                case 1:
                    return nominativ;
                case 2:
                case 3:
                case 4:
                    return genetiv;
                default:
                    return plural;
            }

        }

        private void btnReportAllEmployees_Click(object sender, EventArgs e)
        {
            string mainDate = getMainDate();
            DataTable employees = database.getEmployeesForReport();
            TableContent tableEvent = new TableContent("Team Members");
            int length = employees.Rows.Count;

            foreach (DataRow dtRow in employees.Rows)
            {
                string personalNumber = dtRow["personal_number"].ToString();
                string name = dtRow["name"].ToString();
                string surname = dtRow["surname"].ToString();
                //string patronymic = dtRow["patronymic"].ToString();
                string positionName = dtRow["positionName"].ToString();
                string departmentName = dtRow["departmentName"].ToString();

                string employeeWord = GetDeclension(length, "сотрудник", "сотрудника", "сотрудников");

                tableEvent.AddRow(
                    new FieldContent("personalNumber", personalNumber),
                    new FieldContent("Full Name", surname + " " + name),
                    new FieldContent("Role", positionName),
                    new FieldContent("department", departmentName),
                    new FieldContent("Count", length.ToString() + " " + employeeWord)
                );
            }

            var valuesToFill = new TemplateEngine.Docx.Content(
                tableEvent,
                new FieldContent("Report date", mainDate)
             );

            string destinationFolderPath = @"D:\Documents\Отчеты о составе команды";
            string templatePath = @"D:\Documents Templates\Отчет о сотрудниках.docx";
            string newFilePath = @"D:\Documents\Отчеты о составе команды\Отчет о составе команды от " + mainData + ".docx";

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            File.Delete(newFilePath);
            File.Copy(templatePath, newFilePath);

            using (var outputDocument = new TemplateProcessor(newFilePath)
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
            Process.Start(newFilePath);

        }
    }
}
