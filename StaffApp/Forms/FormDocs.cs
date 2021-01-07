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

        private void btnReportAllEmployees_Click(object sender, EventArgs e)
        {

            DataTable employees = database.getEmployees();


            TableContent tblSEQOfEvents = new TableContent("Team Members");

            foreach (DataRow dtRow in employees.Rows)
            {
                string name = dtRow[1].ToString();
                //tblSEQOfEvents.AddRow(new FieldContent("Full Name", SOE_DT));
            }

            var valuesToFill = new TemplateEngine.Docx.Content(
                tblSEQOfEvents
             );


            File.Delete(@"D:\Documents\Отчет о сотрудниках.docx");
            File.Copy(@"D:\Documents Templates\Отчет о сотрудниках.docx", @"D:\Documents\Отчет о сотрудниках.docx");

            using (var outputDocument = new TemplateProcessor(@"D:\Documents\Отчет о сотрудниках.docx")
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
        
    }
    }
}
