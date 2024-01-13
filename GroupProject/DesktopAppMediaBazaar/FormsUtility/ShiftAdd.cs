using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using DesktopAppMediaBazaar.Forms;
using System.Runtime.InteropServices;

namespace DesktopAppMediaBazaar.FormsUtility
{
    public partial class ShiftAdd : Form
    {
        private readonly Employee _currentEmployee;
        private readonly DepartmentController _departmentController;
        private readonly EmployeeController _employeeController;
        private readonly ShiftController _shiftController;
        private DataGridView lbEmployees;
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
        public ShiftAdd(DepartmentController departmentController, Employee loggedEmployee, EmployeeController employeeController, ShiftController shiftController, DataGridView lbEmployees)
        {
            InitializeComponent();
            InitializeEventHandlers();
            _departmentController = departmentController;
            _currentEmployee = loggedEmployee;
            _employeeController = employeeController;
            _shiftController = shiftController;
            this.lbEmployees = lbEmployees;

            /*            foreach (Department department in _departmentController.GetAll())
                        {
                            cbxDepartment.Items.Add(department.Name);
                        }*/
            _shiftController = shiftController;
            showEmployees();
        }

        private void showEmployees()
        {
            lbxEmployees.Items.Clear();
            foreach (Employee employee in _employeeController.GetAll())
            {
                if (employee.Department.Id > 2) lbxEmployees.Items.Add(employee);
            }
        }

        private string GetShiftTypeDisplayName(ShiftType shiftType)
        {
            switch (shiftType)
            {
                case ShiftType.Morning:
                    return "Late Morning";
                case ShiftType.EarlyMorning:
                    return "Early Morning";
                case ShiftType.Afternoon:
                    return "Late Afternoon";
                case ShiftType.EarlyAfternoon:
                    return "Early Afternoon";
                case ShiftType.Evening:
                    return "Late Evening";
                case ShiftType.EarlyEvening:
                    return "Early Evening";
                default:
                    return shiftType.ToString();
            }
        }

        private void showEmployeesMainForm()
        {
            var shifts = _shiftController.GetAll()
                .Select(shift => new ShiftDisplayInfo
                {
                    Name = shift.Employee.Name,
                    shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
                    date = shift.Date,
                })
                .ToList();

            lbEmployees.Columns.Clear();
            lbEmployees.DataSource = shifts;
            AdjustDataGridViewColumns();
        }

        private void AdjustDataGridViewColumns()
        {
            lbEmployees.Columns.Add("Name", "Name");
            lbEmployees.Columns.Add("shiftType", "Shift Type");
            lbEmployees.Columns.Add("date", "Date");

            lbEmployees.Columns["Name"].DataPropertyName = "Name";
            lbEmployees.Columns["shiftType"].DataPropertyName = "shiftType";
            lbEmployees.Columns["date"].DataPropertyName = "date";

            lbEmployees.Columns["Name"].HeaderText = "Name";
            lbEmployees.Columns["shiftType"].HeaderText = "Shift Type";
            lbEmployees.Columns["Date"].HeaderText = "Date";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeEventHandlers()
        {
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e) { }

        private void tbxName__TextChanged_1(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            foreach (Employee employee in _employeeController.GetAll())
            {
                if (employee.Department.Id > 2 &&
                    employee.ToString().ToLower().Contains(tbxName.Texts.ToLower()))
                { lbxEmployees.Items.Add(employee); }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shiftType = CheckShiftSelectionType();
            DateTime shiftDate = Calendar.Value;

            if (lbxEmployees.SelectedIndex != -1)
            {
                Employee _employee = (Employee)lbxEmployees.SelectedItem;
                Shift shift = new Shift(_employee, shiftDate, shiftType);
                _shiftController.AddShift(shift);
                lbxEmployees.Items.Add(shift);
                showEmployeesMainForm();
                this.Close();
            }
            else { RJMessageBox.Show("Please select an employee!"); }
        }

        private int CheckShiftSelectionType()
        {
            ShiftType shiftType;

            if (cklMorning.Checked)
            {
                shiftType = ShiftType.Morning;
            }
            else if (cklAfternoon.Checked)
            {
                shiftType = ShiftType.Afternoon;
            }
            else if (cklEvening.Checked)
            {
                shiftType = ShiftType.Evening;
            }
            else if (cklEarlyMorning.Checked)
            {
                shiftType = ShiftType.EarlyMorning;
            }
            else if (cklEarlyAfternoon.Checked)
            {
                shiftType = ShiftType.EarlyAfternoon;
            }
            else if (cklEarlyEvening.Checked)
            {
                shiftType = ShiftType.EarlyEvening;
            }
            else
            {
                shiftType = ShiftType.Morning;
            }

            return (int)shiftType;
        }
    }
}
