using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using ClassLibrary.DBHelpers;

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
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
