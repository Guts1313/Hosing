using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using BussinessLayer.Utilities.Messages;
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
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.FormsUtility
{
    public partial class ShiftAutoAdd : Form
    {
        private DataGridView lbEmployees;
        private ShiftsAutomation shiftsAutomation;
        private readonly ShiftController shiftController;
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
        public ShiftAutoAdd(ShiftController shiftController, DataGridView lbEmployees)
        {
            InitializeComponent();

            shiftsAutomation = new ShiftsAutomation();
            this.FormBorderStyle = FormBorderStyle.None;
            this.lbEmployees = lbEmployees;
            this.shiftController = shiftController;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            var shifts = shiftController.GetAll()
                .Select(shift => new ShiftDisplayInfo
                {
                    Name = shift.Employee.Name,
                    date = shift.Date.DayOfWeek,
                    shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime start = StartCalendar.Value;
            DateTime end = EndCalendar.Value;

            if (start > end)
            {
                RJMessageBox.Show("Start date can`t be in the future compaired to end date");
                this.Close();
            }

            try
            {
                shiftsAutomation.AssignShiftsAutomaticallyByDate(start, end);

                EmployeeController employeeController = new EmployeeController(new DALEmployeeController());

                foreach (var employee in employeeController.GetAll())
                {
                    string subject = string.Format(EmailMessages.AUTO_ASSIGNED_SHIFT_SUBJECT, employee.Name);
                    string body = string.Format(EmailMessages.AUTO_ASSIGNED_SHIFT_BODY, employee.Name);

                    if (employee.Email != null)
                    {
                        EmailSendController emailSendController = new EmailSendController(employee.Email, subject, body);
                        emailSendController.SendEmail();
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
                this.Close();
            }

            showEmployeesMainForm();
            this.Close();
        }

        private void ShiftAutoAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
