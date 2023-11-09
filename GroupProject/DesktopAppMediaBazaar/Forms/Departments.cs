using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.Forms
{
    public partial class Departments : Form
    {
        private DepartmentController DepartmentController;
        private Employee _loggedInEmployee;

        public Departments(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            DepartmentController = new(new DALDepartmentController());
            showDepartments();
        }

        private void showDepartments()
        {
            foreach (Department department in DepartmentController.GetAll())
            {
                lbDepartments.Items.Add(department.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Texts != string.Empty)
            {
                Department department = new Department(tbxName.Texts);
                DepartmentController.Create(department);
                lbDepartments.Items.Add(department.Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbDepartments.SelectedIndex != -1)
            {
                Department dep = DepartmentController.Get(lbDepartments.SelectedItem.ToString());
                DepartmentController.Remove(dep);
                lbDepartments.Items.Clear();
                showDepartments();
            }
        }
    }
}
