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
    public partial class FormAddStaff_LaborContract : Form
    {
        private string empFullName;
        private string newFullName;
        private string department;
        private string position;
        private string series;
        private string number;
        private string body;
        private string register;
        private DateTime passDate;
        private DB database;
        private FormPanelMenu panelMenu;
        public FormAddStaff_LaborContract(
            string efn,
            string nfn,
            string d,
            string p,
            string ser,
            string num,
            string bod,
            string reg,
            DateTime passdate,
            FormPanelMenu pm,
            DB db
            )
        {

            empFullName = efn;
            newFullName = nfn;
            department = d;
            position = p;
            database = db;
            panelMenu = pm;
            series = ser;
            number = num;
            body = bod;
            register = reg;
            passDate = passdate;

            InitializeComponent();

            dropContractType.SelectedIndex = 0;
            dropContactType2.SelectedIndex = 0;
            reshim.SelectedIndex = 0;
        }

        private void btnCreateEmp_Click(object sender, EventArgs e)
        {

            string type1 = dropContractType.SelectedItem.ToString();
            string type2 = dropContactType2.SelectedItem.ToString();
            string duty = inputDuty.Text;
            string mode = reshim.SelectedItem.ToString();
            string days = inputDays.Text;

            Documents.createLaborContract(
                empFullName,
                newFullName,
                department,
                position,
                type1,
                type2,
                dpStart.Value,
                dpFinish.Value,
                duty,
                mode,
                days,
                series,
                number,
                body,
                register,
                passDate
                );

            panelMenu.OpenChildForm(new FormStaff(panelMenu, database));
        }
    }
}
