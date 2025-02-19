﻿using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar
{
    public partial class ManagerLandingForm : Form
    {
        private Employee _loggedInEmployee;

        public ManagerLandingForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            labelWelcome.Text = "Welcome, " + _loggedInEmployee.Username + "!";
        }

        private void ManagerLandingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
