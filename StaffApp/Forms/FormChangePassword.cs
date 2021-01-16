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
    public partial class FormChangePassword : Form
    {
        private DB database;
        private FormPanelMenu panelMenu;
        public FormChangePassword(DB db, FormPanelMenu pM)
        {
            database = db;
            panelMenu = pM;
            InitializeComponent();
        }

        private void inputOldPass_TextChange(object sender, EventArgs e)
        {
            inputOldPass.PasswordChar = '*';
        }

        private void inputNewPass1_Enter(object sender, EventArgs e)
        {
            inputNewPass1.PasswordChar = '*';
        }

        private void InputNewPass2_TextChange(object sender, EventArgs e)
        {
            InputNewPass2.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPass = inputOldPass.Text;
            string newPass1 = inputNewPass1.Text;
            string newPass2 = InputNewPass2.Text;

            if (String.IsNullOrWhiteSpace(oldPass) || 
                String.IsNullOrWhiteSpace(newPass1) ||
                String.IsNullOrWhiteSpace(newPass2))
            {
                MessageBox.Show("Прежде чем сохранить, заполните все поля!", "Ошибка валидации");
                return;
            }

            if (newPass1 != newPass2)
            {
                MessageBox.Show("Новые пароли не совпадают!", "Ошибка валидации");
                return;
            }

            if(oldPass != DB.currentEmployee.Field<string>("autorization_pass"))
            {
                MessageBox.Show("Текущий пароль не такой!", "Ошибка валидации");
                return;
            }

            database.changePassword(newPass1);
            panelMenu.Reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelMenu.Reset();
        }
    }
}
