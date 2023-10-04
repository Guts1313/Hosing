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

    public partial class AdminEmployeesForm : Form
    {
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        Employee _loggedInEmployee;
        public AdminEmployeesForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;

            lbxEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 2) lbxEmployees.Items.Add(employee.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminAddingEmployeeForm form = new AdminAddingEmployeeForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            if (lbxEmployees.SelectedIndex != -1)
            {
                string[] split = lbxEmployees.SelectedItem.ToString().Split(new char[] { ':' });

                int _index = Convert.ToInt32(split[0]);

                Employee _employee = EmployeeController.GetById(_index);

                AdminEmployeeDetails form = new AdminEmployeeDetails(_loggedInEmployee, _employee);
                this.Hide();
                form.ShowDialog();
            }
            else MessageBox.Show("Please select an employee!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxEmployees.SelectedIndex != -1)
            {
                string[] split = lbxEmployees.SelectedItem.ToString().Split(new char[] { ':' });

                int _index = Convert.ToInt32(split[0]);

                Employee _employee = EmployeeController.GetById(_index);
                EmployeeController.RemoveEmployee(_employee);
                lbxEmployees.Items.Clear();
                foreach (Employee employee in EmployeeController.GetAll())
                    if (employee.Department.Id > 2) lbxEmployees.Items.Add(employee.ToString());
            }
            else MessageBox.Show("Please select an employee!");


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 2 && employee.ToString().ToLower().Contains(tbxSearch.Text.ToLower()))
                    lbxEmployees.Items.Add(employee.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = string.Empty;
            lbxEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 2)
                    lbxEmployees.Items.Add(employee.ToString());
            }
        }


        private void AdminEmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void btnCancelledShifts_Click(object sender, EventArgs e)
        {
            AdminCancelledShiftsForm form = new AdminCancelledShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            LoginForm form = new LoginForm();
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

        private void btnDepartments_Click_1(object sender, EventArgs e)
        {
            AdminDepartmentsForm form = new AdminDepartmentsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnShifts_Click_1(object sender, EventArgs e)
        {
            AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnCancelledShifts_Click_1(object sender, EventArgs e)
        {
            AdminCancelledShiftsForm form = new AdminCancelledShiftsForm(_loggedInEmployee);
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

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}

