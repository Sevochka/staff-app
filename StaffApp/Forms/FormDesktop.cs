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
    public partial class FormDesktop : Form
    {
        private DB database;
        public FormDesktop(DB db)
        {
            InitializeComponent();

             
            database = db;
           
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
