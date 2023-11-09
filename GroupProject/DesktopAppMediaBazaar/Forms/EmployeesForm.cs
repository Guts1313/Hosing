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

namespace DesktopAppMediaBazaar.Forms
{
    public partial class EmployeesForm : Form
    {
        private Employee _loggedInEmployee;
        public EmployeesForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
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
    }
}
