using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using DesktopAppMediaBazaar.Forms;
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
using BCrypt.Net;
using System.Text.RegularExpressions;

namespace DesktopAppMediaBazaar.FormsUtility
{
    public partial class EmployeesAdd : Form
    {
        private DepartmentController departmentController;
        private EmployeeController employeeController;
        private ListBox lbEmployees;
        private Action refreshEmployeesGrid; // Delegate to refresh DataGridView


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
        public EmployeesAdd(Action refreshEmployeesGrid)
        {
            InitializeComponent();
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.FormBorderStyle = FormBorderStyle.None;
            this.refreshEmployeesGrid = refreshEmployeesGrid;
            employeeController = new(new DALEmployeeController());
            departmentController = new(new DALDepartmentController());
            showDepartments();
        }

        private void showDepartments()
        {
            foreach (Department department in departmentController.GetAll())
            {
                cbxDepartment.Items.Add(department.Name);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int shifts = 0;
            if (cklMorning.Checked == true)
            { shifts.AddShift(ShiftType.Morning); }
            if (cklAfternoon.Checked == true)
            { shifts.AddShift(ShiftType.Afternoon); }
            if (cklEvening.Checked == true)
            { shifts.AddShift(ShiftType.Evening); }
            if (cklEarlyMorning.Checked == true)
            { shifts.AddShift(ShiftType.EarlyMorning); }
            if (cklEarlyAfternoon.Checked == true)
            { shifts.AddShift(ShiftType.EarlyAfternoon); }
            if (cklEarlyEvening.Checked == true)
            { shifts.AddShift(ShiftType.EarlyEvening); }
            if (cklMorning.Checked == false && cklAfternoon.Checked == false && cklEvening.Checked == false &&
                cklEarlyMorning.Checked == false && cklEarlyAfternoon.Checked == false && cklEarlyEvening.Checked == false)
            { RJMessageBox.Show("Please select at least one preferred shift!"); return; }
            if (cklMorning.Checked == true && cklAfternoon.Checked == true && cklEvening.Checked == true &&
                cklEarlyMorning.Checked == true && cklEarlyAfternoon.Checked == true && cklEarlyEvening.Checked == true)
            { RJMessageBox.Show("You cannot select more than 5 preferred shifts!"); return; }

            string _name = tbxName.Texts;
            string _password = tbxPassword.Texts;
            string _username = tbxUsername.Texts;
            string _email = tbxEmail.Texts;
            string _phone = tbxPhone.Texts;
            decimal bsn = 512214;
            string departmentName = null;
            if (cbxDepartment.SelectedItem == null)
            {
                RJMessageBox.Show("Select Department");
                return;
            }
            Department department = departmentController.Get(cbxDepartment.SelectedItem.ToString());

            decimal salary;
            try { salary = Convert.ToDecimal(tbxSalary.Texts); }
            catch { RJMessageBox.Show("Salary should be a number!"); return; }

            if (_name.Length == 0 || _password.Length == 0 || _username.Length == 0)
            { RJMessageBox.Show("Name, username and password cannot be empty!"); return; }
            if (_password.Length < 12 && !Regex.IsMatch(_password,@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{12,}"))
            { RJMessageBox.Show("Password should be atleast 12 symbols, 1 capital letter, 1 small letter and 1 digit!"); return; }
            if (salary == 0)
            { RJMessageBox.Show("Salary cannot be 0!"); return; }

            Encryptor encryptor = new Encryptor();
            byte[] key = encryptor.GenerateKey();
            byte[] iv = encryptor.GenerateIV();
            byte[] encriptedSalary = encryptor.Encrypt(salary, key, iv);
            byte[] bsnKey = encryptor.GenerateKey();
            byte[] bsnIv = encryptor.GenerateIV();
            byte[] encryptedBsn = encryptor.Encrypt(bsn, bsnKey, bsnIv);
            Employee employee = new Employee(_username, _password, department, _name, _email, _phone, encriptedSalary,DateTime.Now, null, shifts,encryptedBsn);
            employee.Password = BCrypt.Net.BCrypt.HashPassword(employee.Password);
            employeeController.AddEmployee(employee, key, iv,bsnKey,bsnIv);

            refreshEmployeesGrid();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
