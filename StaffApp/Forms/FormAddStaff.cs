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
    public partial class FormAddStaff : Form
    {
        private DataTable departmentsTable;
        private DB database;
        public FormAddStaff(DB db)
        {
            InitializeComponent();
            database = db;
            departmentsTable = database.getDepartments();

            foreach (DataRow dr in departmentsTable.Rows)
            {
                dropDepartment.Items.Add(dr.Field<string>(1));
            }
            dropDepartment.SelectedIndex = 0;
        }

        private void dropSeniority_SelectedIndexChanged(object sender, EventArgs e)
        {
            UInt32 id = departmentsTable.Rows[dropDepartment.SelectedIndex].Field<UInt32>(0);
            
            DataTable positionsCodes = database.getPositionsByDepartmentCode(id);
            dropPosition.Items.Clear();
           foreach (DataRow dr in positionsCodes.Rows)
           {
                int code = dr.Field<int>(0);
                DataTable positionName = database.getPositionByCode(code);
                dropPosition.Items.Add(positionName.Rows[0].Field<string>(0));
            }
            

           // MessageBox.Show(dropDepartment.SelectedIndex.ToString());
        }
    }
}
