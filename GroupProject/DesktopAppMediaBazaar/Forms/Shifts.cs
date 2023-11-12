using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DataItems.LogicItems;

namespace DesktopAppMediaBazaar.Forms
{
    public partial class Shifts : Form
    {
        private Employee _loggedInEmployee;
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        Department _selectedDepartment;
        DateTime _selectedDate;

        public Shifts(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            foreach (var shift in ShiftController.GetAll())
            {
                Calendar.Value = shift.Date; //no methods available to add dates in the custom datepicker
                lbEmployees.Items.Add(shift);
            }

            foreach (Department department in DepartmentController.GetAll())
            {
                cbxDepartment.Items.Add(department.Name);
            }
            cbxDepartment.SelectedIndex = -1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Calendar_ValueChanged(object sender, EventArgs e)
        {
            _selectedDate = Calendar.Value.Date; // custom calendar has no methods to choose dates
        }

        private void cbxDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string departmentName = cbxDepartment.SelectedItem.ToString();
            _selectedDepartment = DepartmentController.Get(departmentName);
            Shift[] shifts = ShiftController.GetAllByDateAndDepartment(_selectedDate, _selectedDepartment);
            lbEmployees.Items.Clear();
            foreach (var shift in shifts)
            {
                lbEmployees.Items.Add(shift);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbEmployees.Items.Clear();
            if (_selectedDate == default(DateTime))
            {
                MessageBox.Show("The date was not selected!");
                return;
            }
            if (cbxDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("The department was not selected!");
                return;
            }

            Shift[] shifts = ShiftController.GetAllByDateAndDepartment(_selectedDate, _selectedDepartment);

            //lblSelectedDate.Text = _selectedDate.ToShortDateString();

            foreach (Shift shift in shifts)
            {

                lbEmployees.Items.Add(shift);

            }
        }



        private void tbxName__TextChanged(object sender, EventArgs e)
        {
            //alorithm gets the employee by name fragment and then returns the shifts assigned to him
            //then we filter them by shift type and display them
            string searchText = tbxName.Texts.ToLower();
            if (searchText.Length > 1)
            {
                lbEmployees.Items.Clear();

            }// Assuming tbxName.Texts is the correct way to get the text from your 
            foreach (Employee employee in EmployeeController.GetAll())
            {
                // Assuming employee.Name is the property that holds the employee's name
                if (employee.Department.Id > 2 && employee.Name.ToLower().Contains(searchText))
                {
                    List<Shift> employeeShifts = ShiftController.GetAllAssigned(employee).ToList();
                    foreach (Shift shift in employeeShifts)
                    {
                        if (morningCheckBox.Checked)
                        {
                            if (shift.Type == 1)
                            {
                                lbEmployees.Items.Add($"{employee.Name} - {shift.ToString()}");

                            }
                        }
                        if (afterNoonCheckBox.Checked)
                        {
                            if (shift.Type==2)
                            {
                                lbEmployees.Items.Add($"{employee.Name} - {shift.ToString()}");

                            }
                        }
                        if (eveningCheckBox.Checked)
                        {
                            if (shift.Type ==3)
                            {
                                lbEmployees.Items.Add($"{employee.Name} - {shift.ToString()}");

                            }
                        }
                        
                    }
                }
            }
            if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked)
            {
                MessageBox.Show("Before you search by an employee,select shift type \n(morning/afternoon/evening) ");
            }
        }
    }
}
