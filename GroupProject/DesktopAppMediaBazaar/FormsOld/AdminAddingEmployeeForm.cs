using BussinessLayer.Controllers;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;

namespace DesktopAppMediaBazaar
{
    public partial class AdminAddingEmployeeForm : Form
    {
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        Employee _loggedInEmployee;
        public AdminAddingEmployeeForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            foreach (Department department in DepartmentController.GetAll())
            {
                comboBoxDepartment.Items.Add(department.Name);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string _name = tbxName.Text;
            string _password = tbxPassword.Text;
            string _username = tbxUsername.Text;
            decimal _salary = numUpDownSalary.Value;
            string _email = tbxEmail.Text;
            string _phone = tbxPhone.Text;
            string departmentName = null;
            if (comboBoxDepartment.SelectedIndex != -1)
            {
                departmentName = comboBoxDepartment.SelectedItem.ToString();
            }
            Department? _department = DepartmentController.Get(departmentName);
            int _shifts = 0;

            if (_name.Length == 0 || _password.Length == 0 || _username.Length == 0)
            {
                MessageBox.Show("Name, username and password cannot be empty!");
                return;
            }

            if (_salary == 0)
            {
                MessageBox.Show("Salary cannot be 0!");
                return;
            }

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
                        _shifts.AddShift(ShiftType.Morning);
                        _shifts.AddShift(ShiftType.Afternoon);

                    }
                    else if (cklMorning.Checked == true && cklEvening.Checked == true)
                    {
						_shifts.AddShift(ShiftType.Morning);
						_shifts.AddShift(ShiftType.Evening);
					}
                    else if (cklAfternoon.Checked == true && cklEvening.Checked == true)
                    {
						_shifts.AddShift(ShiftType.Afternoon);
						_shifts.AddShift(ShiftType.Evening);
					}
                    else if (cklMorning.Checked == true) _shifts.AddShift(ShiftType.Morning);
					else if (cklAfternoon.Checked == true) _shifts.AddShift(ShiftType.Afternoon);
					else if (cklEvening.Checked == true) _shifts.AddShift(ShiftType.Evening);
                }
            }

			Employee employee = new Employee(_username, _password, _department, _name, _email, _phone, _salary, _shifts);



			if (EmployeeController.AddEmployee(employee))
            {
                MessageBox.Show("Employee has been added successfully");
            }
            else
            {
                MessageBox.Show("Error creating employee");
            }

            AdminEmployeesForm form = new AdminEmployeesForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminEmployeesForm form = new AdminEmployeesForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
        }

        private void AdminAddingEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
