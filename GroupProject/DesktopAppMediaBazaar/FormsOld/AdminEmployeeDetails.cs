using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using Microsoft.Identity.Client;

namespace DesktopAppMediaBazaar
{
    public partial class AdminEmployeeDetails : Form
	{
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        Employee _employee;
		Employee _loggedInEmployee;
		private Encryptor encryptor = new Encryptor();

		public AdminEmployeeDetails(Employee loggedInEmployee, Employee employee, byte[] key, byte[] iv)
		{
			InitializeComponent();
			_loggedInEmployee = loggedInEmployee;
			_employee = employee;

			tbxName.Text = _employee.Name;
			tbxPhone.Text = _employee.Phone;
			tbxUsername.Text = _employee.Username;
			lblResistrationDate.Text = DateOnly.FromDateTime(_employee.HireDate).ToString();
			numUpDownSalary.Value = encryptor.Decrypt(_employee.Salary, key, iv);
			
			lbxShiftsWorked.Items.Clear();
			lbxFutureShifts.Items.Clear();

			foreach (Department department in DepartmentController.GetAll())
			{
				comboBoxDepartment.Items.Add(department.Name);
			}

			comboBoxDepartment.SelectedIndex = _employee.Department.Id - 1;

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

			foreach (Shift shift in ShiftController.GetAll())
			{
				if (shift.Date <= DateTime.Now)
				{
					if (shift.Employee.Id == employee.Id) lbxShiftsWorked.Items.Add(shift);
				}
				else
				{
                    if (shift.Employee.Id == employee.Id) lbxFutureShifts.Items.Add(shift);
				}
			}

		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminEmployeesForm form = new AdminEmployeesForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string name = tbxName.Text;
			string username = tbxUsername.Text;
			string phone = tbxPhone.Text;
			decimal salary = numUpDownSalary.Value;
			int shifts = 0;

			string departmentName = null;
			if (comboBoxDepartment.SelectedIndex != -1)
			{
				departmentName = comboBoxDepartment.SelectedItem.ToString();
			}
			Department? department = DepartmentController.Get(departmentName);

			if (cklMorning.Checked == true && cklAfternoon.Checked == true && cklEvening.Checked == true)
			{
				MessageBox.Show("You cannot select more than 2 preferred shifts!");
				return;
			}
			else
			{
				if (cklMorning.Checked == false && cklAfternoon.Checked == false && cklEvening.Checked == false)
				{
					MessageBox.Show("Please select at least one preferred shift!");
					return;
				}
				else
				{
					if (cklMorning.Checked == true && cklAfternoon.Checked == true)
					{
						shifts.AddShift(ShiftType.Morning);
						shifts.AddShift(ShiftType.Afternoon);

					}
					else if (cklMorning.Checked == true && cklEvening.Checked == true)
					{
						shifts.AddShift(ShiftType.Morning);
						shifts.AddShift(ShiftType.Evening);
					}
					else if (cklAfternoon.Checked == true && cklEvening.Checked == true)
					{
						shifts.AddShift(ShiftType.Afternoon);
						shifts.AddShift(ShiftType.Evening);
					}
					else if (cklMorning.Checked == true) shifts.AddShift(ShiftType.Morning);
					else if (cklAfternoon.Checked == true) shifts.AddShift(ShiftType.Afternoon);
					else if (cklEvening.Checked == true) shifts.AddShift(ShiftType.Evening);
				}
			}

            Encryptor encryptor = new Encryptor();
            byte[] key = encryptor.GenerateKey();
            byte[] iv = encryptor.GenerateIV();
            byte[] encriptedSalary = encryptor.Encrypt(salary, key, iv);

            Employee employee = new Employee(_employee.Id, username, _employee.Password, department, name, _employee.Email, phone, encriptedSalary, _employee.HireDate, _employee.ProfilePicture, shifts);

			_employee = employee;

			EmployeeController.UpdateEmployee(_employee, key, iv);

			AdminEmployeesForm form = new AdminEmployeesForm(_loggedInEmployee);
			this.Hide();
			form.ShowDialog();
		}

		private void AdminEmployeeDetails_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
