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
    public partial class FormSystemSettings : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        private DataTable employees;
        public FormSystemSettings(FormPanelMenu pm, DB db)
        {
            panelMenu = pm;
            database = db;
            InitializeComponent();
            getEmployes();
        }
        public void getEmployes()
        {
            employees = database.getEmployeesShort();
            dataEmployees.DataSource = employees;
            //dataEmployees.Columns[0].Width = 40;

            //dataEmployees.Rows[0].Cells;
            foreach (DataGridViewRow dr in dataEmployees.Rows)
            {
                DataGridViewComboBoxCell cell = dr.Cells["access2"] as DataGridViewComboBoxCell;
                //cell.DisplayMember = "Сотрудник";

                cell.Value = 1;
                cell.ValueMember = "Key";
                cell.DisplayMember = "Value";
                //cell.Value = cell.Items[1];
            }

            //dataGridPositions.Rows.Add(values);
            //DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
            //DataGridViewComboBoxCell

            //combobox.HeaderText = "Удаление";
            //combobox.Name = "Удалить";
            // combobox.Items.Add("Сотрудник");
            // combobox.Items.Add("Сотрудник отдела кадров");
            //combobox.Items.Add("Админ");


            //dataEmployees.Columns.Add(combobox);
            //bunifuDataGridView1.Columns[bunifuDataGridView1.Columns.Count - 1].Width = 100;
        }

        private void dataEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
