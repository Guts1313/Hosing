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
using BussinessLayer.Controllers.Shifts;

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
            InitializeDataGridViewStyles();
        }

        // In your EmployeesForm
        private void showEmployees()
        {
            var employees = EmployeeController.GetAll()
                .Where(employee => employee.Department.Id > 2)
                .Select(employee => new EmployeeDisplayInfo
                {
                    Name = employee.Name,
                    Username = employee.Username,
                    Email = employee.Email,
                    ClosestShiftDate = EmployeeController.GetClosestShiftDate(employee.Id) ?? DateTime.MinValue // Default if no shift
                })
                .ToList();

            dgvEmployees.DataSource = employees;
            AdjustDataGridViewColumns();
        }
        // Method to adjust column headers and visibility
        private void AdjustDataGridViewColumns()
        {
            dgvEmployees.Columns["Name"].HeaderText = "Name";
            dgvEmployees.Columns["Username"].HeaderText = "Username";
            dgvEmployees.Columns["Email"].HeaderText = "Email";
            dgvEmployees.Columns["ClosestShiftDate"].HeaderText = "Closest Shift Date";
        }

        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var displayInfo = (EmployeeDisplayInfo)dgvEmployees.CurrentRow.DataBoundItem;
                Employee selectedEmployee = EmployeeController.GetEmployeeByUsername(displayInfo.Username);
                if (selectedEmployee != null)
                {

                    byte[] key = EmployeeController.GetKeybyName(displayInfo.Username);
                    byte[] iv = EmployeeController.GetIvByName(displayInfo.Username);

                    EmployeeDetails form = new EmployeeDetails(dgvEmployees, selectedEmployee, showEmployees, key, iv);
                    form.ShowDialog();
                }
            }
            else
            {
                RJMessageBox.Show("Please select an employee!");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeesAdd form = new EmployeesAdd(showEmployees);
            form.ShowDialog();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var displayInfo = (EmployeeDisplayInfo)dgvEmployees.CurrentRow.DataBoundItem;
                Employee selectedEmployee = EmployeeController.GetEmployeeByUsername(displayInfo.Username);
                if (selectedEmployee != null)
                {
                    EmployeeController.RemoveEmployee(selectedEmployee);
                    showEmployees();
                }
            }
            else
            {
                RJMessageBox.Show("Please select an employee!");
            }
        }


        private void tbxName__TextChanged(object sender, EventArgs e)
        {
            var searchQuery = tbxName.Texts.ToLower();
            var filteredEmployees = EmployeeController.GetAll()
                .Where(employee => employee.Department.Id > 2 &&
                                   (employee.Name.ToLower().Contains(searchQuery) || employee.Username.ToLower().Contains(searchQuery)))
                .Select(employee => new EmployeeDisplayInfo
                {
                    Name = employee.Name,
                    Username = employee.Username,
                    Email = employee.Email,
                    ClosestShiftDate = EmployeeController.GetClosestShiftDate(employee.Id) ?? DateTime.MinValue
                })
                .ToList();

            dgvEmployees.DataSource = filteredEmployees;
        }

        private void InitializeDataGridViewStyles()
        {
            #region COLORS DATAGRID
            dgvEmployees.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dgvEmployees.DefaultCellStyle.SelectionForeColor = dgvEmployees.DefaultCellStyle.ForeColor;
            dgvEmployees.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dgvEmployees.RowHeadersDefaultCellStyle.SelectionForeColor = dgvEmployees.RowHeadersDefaultCellStyle.ForeColor;
            dgvEmployees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmployees.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmployees.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dgvEmployees.BackgroundColor = Color.FromArgb(156, 84, 213);
            dgvEmployees.GridColor = Color.FromArgb(156, 84, 213);
            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dgvEmployees.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dgvEmployees.DefaultCellStyle.ForeColor = Color.FromArgb(215, 215, 215);
            dgvEmployees.DefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.FromArgb(127, 131, 140);
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(215, 215, 215);
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEmployees.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dgvEmployees.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dgvEmployees.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            #endregion
        }
    }

    public class EmployeeDisplayInfo
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime ClosestShiftDate { get; set; } // Assuming you have a way to determine this
    }
}
