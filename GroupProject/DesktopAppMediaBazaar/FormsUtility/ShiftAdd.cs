using BussinessLayer.Controllers;
using DataItems.LogicItems;
using System.Runtime.InteropServices;

namespace DesktopAppMediaBazaar.FormsUtility
{
    public partial class ShiftAdd : Form
    {
        private readonly Employee _currentEmployee;
        private readonly DepartmentController _departmentController;
        private readonly EmployeeController _employeeController;
        private readonly ShiftController _shiftController;
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
        public ShiftAdd(DepartmentController departmentController, Employee loggedEmployee,EmployeeController employeeController,ShiftController shiftController)
        {
            InitializeComponent();
            InitializeEventHandlers();
            _departmentController = departmentController;
            _currentEmployee = loggedEmployee;
            _employeeController = employeeController;
            _shiftController = shiftController;

            foreach (Department department in _departmentController.GetAll())
            {
                cbxDepartment.Items.Add(department.Name);
            }
            _shiftController = shiftController;
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

        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shiftType = CheckShiftSelectionType();
            DateTime shiftDate = Calendar.Value;
            Shift shift = new Shift(_currentEmployee,shiftDate,shiftType);
            _shiftController.AddShift(shift);
            lbxEmployees.Items.Add(shift);
        }

        private int CheckShiftSelectionType()
        {
            int shiftType;

            if (cklMorning.Checked)
            {
                shiftType = 1;
                return shiftType;

            }
            else if(cklAfternoon.Checked)
            {
                shiftType= 2;
                return shiftType;

            }
            else
            {
                shiftType = 3;
                return shiftType;
            }
        }
    }
}
