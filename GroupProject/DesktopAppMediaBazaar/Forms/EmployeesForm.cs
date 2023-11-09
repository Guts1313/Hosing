using DataItems.LogicItems;
using DesktopAppMediaBazaar.ChildFormsUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppMediaBazaar.FormsUtility;
using BussinessLayer.Controllers;
using DesktopAppMediaBazaar.CustomElements;
using DataAccessLayer.DAL;

namespace DesktopAppMediaBazaar.Forms
{
    public partial class EmployeesForm : Form
    {
        private EmployeeController EmployeeController;
        private Employee _loggedInEmployee;

        public EmployeesForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            EmployeeController = new(new DALEmployeeController());
            showEmployees();
        }

        private void showEmployees()
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 2) lbEmployees.Items.Add(employee);
            }
        }

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            EmployeeDetails form = new EmployeeDetails();
            //form.FormClosed += (s, args) => RefreshEmployeeListAsync();
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeesAdd form = new EmployeesAdd();
            //form.FormClosed += (s, args) => RefreshEmployeeListAsync();
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                Employee _employee = (Employee)lbEmployees.SelectedItem;
                EmployeeController.RemoveEmployee(_employee);
                showEmployees();
            }
            else RJMessageBox.Show("Please select an employee!");
        }

        private void tbxName__TextChanged(object sender, EventArgs e)
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in EmployeeController.GetAll())
            {
                if (employee.Department.Id > 2 && employee.ToString().ToLower().Contains(tbxName.Texts.ToLower()))
                   lbEmployees.Items.Add(employee.ToString());
            }
        }
    }
}
