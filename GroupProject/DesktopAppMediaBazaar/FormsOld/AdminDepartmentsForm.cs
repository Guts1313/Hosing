using BussinessLayer.Controllers;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using Microsoft.VisualBasic.Logging;
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
    public partial class AdminDepartmentsForm : Form
    {
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        Employee _loggedInEmployee;
        public AdminDepartmentsForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            foreach (Department department in DepartmentController.GetAll())
            {
                lbDepartments.Items.Add(department.Name);
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeesForm form = new AdminEmployeesForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnShifts_Click(object sender, EventArgs e)
        {
            AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            AdminDepartmentsForm form = new AdminDepartmentsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (tbDepartmentName.Text != string.Empty)
            {
                Department department = new Department(tbDepartmentName.Text);
                DepartmentController.Create(department);
                lbDepartments.Items.Add(department.Name);
            }
        }

/*        private void btnCancelledShifts_Click(object sender, EventArgs e)
        {
            AdminCancelledShiftsForm form = new AdminCancelledShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }*/

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonVacations_Click(object sender, EventArgs e)
        {
            AdminVacationsForm form = new(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbDepartments.SelectedIndex != -1)
            {
                Department dep = DepartmentController.Get(lbDepartments.SelectedItem.ToString());
                DepartmentController.Remove(dep);
                lbDepartments.Items.Clear();
                foreach (Department department in DepartmentController.GetAll())
                {
                    lbDepartments.Items.Add(department.Name);
                }
            }
        }
    }
}
