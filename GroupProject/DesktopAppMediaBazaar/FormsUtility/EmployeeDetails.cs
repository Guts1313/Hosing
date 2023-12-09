using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using DataAccessLayer.DAL;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.FormsUtility
{
    public partial class EmployeeDetails : Form
    {
        private DepartmentController departmentController;
        private ShiftController shiftController;
        private EmployeeController employeeController;
        private Employee _employee;
        private ListBox lbEmployees;

        #region FORM CUSTOM STYLE
        //FORM DRAG NO BORDER
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(156, 84, 213);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(229, 229, 229);
        }
        #endregion
        public EmployeeDetails(ListBox lbEmployees, Employee employee)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.lbEmployees = lbEmployees;
            _employee = employee;
            shiftController = new(new DALShiftController());
            departmentController = new(new DALDepartmentController());
            employeeController = new(new DALEmployeeController());
            showAllEmployeeDetails();
        }

        private void showAllEmployeeDetails()
        {
            tbxName.Texts = _employee.Name;
            tbxPhone.Texts = _employee.Phone;
            tbxUsername.Texts = _employee.Username;
            lbRegisterDate.Text = DateOnly.FromDateTime(_employee.HireDate).ToString();
            tbxSalary.Texts = _employee.Salary.ToString();
            showShifts();
            showDepartments();
            showShiftsChecked();
        }

        private void showShifts()
        {
            lbxShifts.Items.Clear();
            if (rbtnAll.Checked == true || (rbtnFuture.Checked == false && rbtnPast.Checked == false))
            {
                foreach (Shift shift in shiftController.GetAll())
                {
                    if (shift.Employee.Id == _employee.Id)
                        lbxShifts.Items.Add(shift);
                }
            }
            else if (rbtnFuture.Checked == true)
            {
                foreach (Shift shift in shiftController.GetAll())
                {
                    if (shift.Employee.Id == _employee.Id && shift.Date >= DateTime.Now)
                        lbxShifts.Items.Add(shift);
                }
            }
            else if (rbtnPast.Checked == true)
            {
                foreach (Shift shift in shiftController.GetAll())
                {
                    if (shift.Employee.Id == _employee.Id && shift.Date < DateTime.Now)
                        lbxShifts.Items.Add(shift);
                }
            }
        }

        private void showDepartments()
        {
            cbxDepartment.Items.Clear();
            foreach (Department department in departmentController.GetAll())
            {
                cbxDepartment.Items.Add(department.Name);
            }
            cbxDepartment.SelectedIndex = _employee.Department.Id - 1;
        }

        private void showShiftsChecked()
        {
            if (_employee.Shifts.HasShift(ShiftType.Morning))
            {
                cklMorning.Checked = true;
            }
            if (_employee.Shifts.HasShift(ShiftType.Afternoon))
            {
                cklAfternoon.Checked = true;
            }
            if (_employee.Shifts.HasShift(ShiftType.Evening))
            {
                cklEvening.Checked = true;
            }
        }

        private void showEmployees()
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in employeeController.GetAll())
            {
                if (employee.Department.Id > 2) lbEmployees.Items.Add(employee);
            }
        }

        private void rbtnPast_CheckedChanged(object sender, EventArgs e)
        {
            showShifts();
        }

        private void rbtnFuture_CheckedChanged(object sender, EventArgs e)
        {
            showShifts();
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            showShifts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int shifts = 0;
            if (cklMorning.Checked == true)
            { shifts.AddShift(ShiftType.Morning); }
            if (cklAfternoon.Checked == true)
            { shifts.AddShift(ShiftType.Afternoon); }
            if (cklEvening.Checked == true)
            { shifts.AddShift(ShiftType.Evening); }
            if (cklMorning.Checked == false && cklAfternoon.Checked == false && cklEvening.Checked == false)
            { RJMessageBox.Show("Please select at least one preferred shift!"); return; }
            if (cklMorning.Checked == true && cklAfternoon.Checked == true && cklEvening.Checked == true)
            { RJMessageBox.Show("You cannot select more than 2 preferred shifts!"); return; }

            Department department = departmentController.Get(cbxDepartment.SelectedItem.ToString());

            string name = tbxName.Texts;
            string username = tbxUsername.Texts;
            string phone = tbxPhone.Texts;
            decimal salary;

            try { salary = Convert.ToDecimal(tbxSalary.Texts); }
            catch { RJMessageBox.Show("Salary should be a number!"); return; }

            Employee employee = new Employee(_employee.Id, username, _employee.Password, department, name, _employee.Email, phone, salary, _employee.HireDate, _employee.ProfilePicture, shifts);
            employeeController.UpdateEmployee(employee);

            showEmployees();
            this.Close();
        }
    }
}
