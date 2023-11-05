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

namespace DesktopAppMediaBazaar
{
	public partial class ChooseEmployeeByDepartmentForm : Form
	{
		public EmployeeController EmployeeController { get; private set; } = new (new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        Employee[] _employees;
		Employee _loggedInEmployee;
		List<Employee> _temporaryEmployess = new();
		DateTime _date;
		ShiftType _shiftType;

		public ChooseEmployeeByDepartmentForm(Employee loggedInEmployee, Department department, DateTime date, ShiftType shiftType)
		{
			InitializeComponent();
			_loggedInEmployee = loggedInEmployee;
			_date = date;
			_shiftType = shiftType;
			_employees = EmployeeController.GetAllByDepartment(department);

			foreach (Employee employee in _employees)
			{
				lbxEmployees.Items.Add(employee);
				_temporaryEmployess.Add(employee);
			}
		}

		private void txbSearch_TextChanged(object sender, EventArgs e)
		{
			lbxEmployees.Items.Clear();
			_temporaryEmployess.Clear();

			foreach (var employee in _employees)
			{
				if (employee.Name.Contains(txbSearch.Text))
				{
					lbxEmployees.Items.Add(employee);
					_temporaryEmployess.Add(employee);
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(lbxEmployees.SelectedIndex == -1)
			{
				MessageBox.Show("The employee was not selected");
				return;
			}
			Employee employee = _temporaryEmployess[lbxEmployees.SelectedIndex];
			Shift shift = new Shift(employee, _date, (int)_shiftType);
			if (ShiftController.AddShift(shift))
				MessageBox.Show("The shift has been created successfully! Please refresh the Shifts Form to see it.");
			else
				MessageBox.Show("Error creating shift");

			//AdminShiftsForm form = new AdminShiftsForm(_login);
			this.Close();
			//form.ShowDialog();
		}
	}
}
