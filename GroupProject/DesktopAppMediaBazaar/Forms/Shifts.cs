using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using DesktopAppMediaBazaar.FormsUtility;

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

            getAllShifts();

            foreach (Department department in DepartmentController.GetAll())
            {
                cbxDepartment.Items.Add(department.Name);
            }
            cbxDepartment.SelectedIndex = -1;

        }

        private void getAllShifts()
        {
            lbEmployees.Items.Clear();
            foreach (var shift in ShiftController.GetAll())
            {
                //Calendar.Value = shift.Date; //no methods available to add dates in the custom datepicker
                lbEmployees.Items.Add(shift);
            }
        }

        private void btnAutoShifts_Click(object sender, EventArgs e)
        {
            ShiftAutoAdd form = new ShiftAutoAdd(ShiftController, lbEmployees);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShiftAdd form = new ShiftAdd(DepartmentController, _loggedInEmployee, EmployeeController, ShiftController, lbEmployees);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex != -1)
            {
                var shiftItem = (Shift)lbEmployees.SelectedItem;
                ShiftController.DeleteShift(shiftItem);

                getAllShifts();
            }
            else { RJMessageBox.Show("No shift is selected"); }
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
                RJMessageBox.Show("The date was not selected!");
                return;
            }
            if (cbxDepartment.SelectedIndex == -1)
            {
                RJMessageBox.Show("The department was not selected!");
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

            }
            foreach (Employee employee in EmployeeController.GetAll())
            {

                if (employee.Department.Id > 2 && employee.Name.ToLower().Contains(searchText))
                {
                    List<Shift> employeeShifts = ShiftController.GetAllAssigned(employee).ToList();
                    foreach (Shift shift in employeeShifts)
                    {

                        FilterByShiftType(shift, employee);
                    }
                }
            }
            if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked)
            {
                RJMessageBox.Show("Before you search by an employee,select shift type \n(morning/afternoon/evening) ");
            }
        }


        public void FilterByShiftType(Shift shift, Employee employee)
        {
            if (morningCheckBox.Checked)
            {
                if (shift.Type == (int)ShiftType.Morning)
                {
                    lbEmployees.Items.Add($"{employee.Name} - {shift.ToString()}");

                }
            }
            if (afterNoonCheckBox.Checked)
            {
                if (shift.Type == (int)ShiftType.Afternoon)
                {
                    lbEmployees.Items.Add($"{employee.Name} - {shift.ToString()}");

                }
            }
            if (eveningCheckBox.Checked)
            {
                if (shift.Type == (int)ShiftType.Evening)
                {
                    lbEmployees.Items.Add($"{employee.Name} - {shift.ToString()}");

                }
            }
        }

        private void getSpecificShift()
        {
            lbEmployees.Items.Clear();

            string searchText = tbxName.Texts.ToLower();
            foreach (Employee employee in EmployeeController.GetAll())
            {

                if (employee.Department.Id > 2 && employee.Name.ToLower().Contains(searchText))
                {
                    List<Shift> employeeShifts = ShiftController.GetAllAssigned(employee).ToList();
                    foreach (Shift shift in employeeShifts)
                    {
                        FilterByShiftType(shift, employee);
                    }
                }
            }
        }

        private void morningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (morningCheckBox.Checked)
            {
                getSpecificShift();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked) 
            {
                getAllShifts();
            }
        }

        private void afterNoonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (afterNoonCheckBox.Checked)
            {
                getSpecificShift();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void eveningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eveningCheckBox.Checked)
            {
                getSpecificShift();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }
    }
}
