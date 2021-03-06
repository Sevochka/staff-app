﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace StaffApp
{
    public partial class FormPanelMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private DB database;

        public FormPanelMenu(DB db)
        {
            InitializeComponent();
            database = db;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            openLoginForm();
        }
        //Structs
        //Colors for active buttons
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(171, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 251);
            public static Color color5 = Color.FromArgb(208, 108, 235);
            public static Color color6 = Color.FromArgb(107, 139, 207);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //disable prev btn
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                labelTitleChildForm.Text = currentBtn.Text;
                iconCurrentChildForm.IconColor = color;
            }
        }

 
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }


        public void Reset()
        {
            ActivateButton(btnMenu, RGBColors.color1);
            OpenChildForm(new Forms.FormDesktop(database, this));
        }
        public void InitializeSignIn()
        {
            DB.access = DB.currentEmployee.Field<string>("access");
            string access = DB.access;
            if (access == "USER+" || access == "ADMIN")
            {
                if (access == "ADMIN")
                {
                    btnSettings.Visible = true;
                }
                btnArchive.Visible = true;
                btnDocuments.Visible = true;
                btnPosition.Visible = true;
                btnStaff.Visible = true;
                btnMenu.Visible = true;
            }
            if (access == "USER")
            {
                btnMenu.Visible = true;
                btnDocuments.Visible = true;
                btnStaff.Visible = true;
            }
           
            Reset();
        }

        public void hideAll()
        {
            btnSettings.Visible = false;
            btnDocuments.Visible = false;
            btnPosition.Visible = false;
            btnStaff.Visible = false;
            btnMenu.Visible = false;
            btnArchive.Visible = false;
        }

        public Boolean isBtnsAreEqual(object sender)
        {
            //return ((IconButton)sender == currentBtn);
            return false;
        }

        private void openLoginForm()
        {
            OpenChildForm(new FormLogin(database, this));
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (isBtnsAreEqual(sender))
                return;
            Reset();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (isBtnsAreEqual(sender))
                return;
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormStaff(this, database));
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (isBtnsAreEqual(sender))
                return;
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormPosition(this, database, true));
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            if (isBtnsAreEqual(sender))
                return;
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.FormDocs(this, database));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (isBtnsAreEqual(sender))
                return;
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.FormSystemSettings(this, database));
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (isBtnsAreEqual(sender))
                return;
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormArchive(this, database));
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (!DB.isLogged)
            {
                return;
            }
            Reset();
        }

        //Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
        //Control buttons
        private void ResetBtnColor(IconPictureBox button)
        {
            button.ForeColor = Color.Gainsboro;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            ResetBtnColor(btnClose);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.ForeColor = Color.FromArgb(17, 135, 221);
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            ResetBtnColor(btnMaximize);
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(9, 203, 203);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            ResetBtnColor(btnMinimize);
        }

        private void panelActiveTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
