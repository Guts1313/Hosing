using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using DataAccessLayer;
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
    public partial class AdminCancelledShiftsForm : Form
    {
        CancelledShiftController _cancelledShiftController = new(new DALCancelledShiftController());
        Employee _loggedInEmployee;
        CancelledShift _cancelledShift;
        CancelledShift[] _cancelledShiftsShown;
        public AdminCancelledShiftsForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;

            _cancelledShiftsShown = _cancelledShiftController.GetAll();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void btnCancelledShifts_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployeesForm form = new AdminEmployeesForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnShifts_Click(object sender, EventArgs e)
        {
            AdminShiftsForm form = new AdminShiftsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            AdminDepartmentsForm form = new AdminDepartmentsForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void lbxCancelledShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxCancelledShifts.SelectedIndex;
            if (index != -1)
            {
                string[] split = lbxCancelledShifts.SelectedItem.ToString().Split(new char[] { ':' });

                int id = Convert.ToInt32(split[0]);

                _cancelledShift = _cancelledShiftController.GetById(id);

                labelShift.Text = $"{_cancelledShift.Shift.Date.ToShortDateString()} " +
                    $"in the {_cancelledShift.Shift.GetType()}";
                labelAssignedEmpName.Text = _cancelledShift.AssignedEmployee.Name;
                if (_cancelledShift.NewEmployee == null && _cancelledShift.Shift.Date >= DateTime.Now.Date)
                {
                    labelNewEmp.Text = "Not assigned";
                    btnAssign.Visible = true;
                }
                else if (_cancelledShift.NewEmployee != null)
                {
                    labelNewEmp.Text = _cancelledShift.NewEmployee.Name;
                    btnAssign.Visible = false;
                }
                else if (_cancelledShift.NewEmployee == null && _cancelledShift.Shift.Date <= DateTime.Now.Date)
                {
                    labelNewEmp.Text = "Not assigned";
                    btnAssign.Visible = false;
                }

                if (_cancelledShift.IsViewed)
                {
                    labelStatus.Text = "Viewed";
                    btnMarkViewed.Visible = false;
                }
                else
                {
                    labelStatus.Text = "Sent";
                    btnMarkViewed.Visible = true;
                }
                labelReason.Text = _cancelledShift.Reason;
            }
        }

        private void btnMarkViewed_Click(object sender, EventArgs e)
        {
            _cancelledShift.IsViewed = true;

            if (_cancelledShiftController.Update(_cancelledShift))
                btnMarkViewed.Visible = false;
            else
                MessageBox.Show("Could not change the status of the cancelled shift");

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int index = lbxCancelledShifts.SelectedIndex;
            if (index != -1)
            {
                string[] split = lbxCancelledShifts.SelectedItem.ToString().Split(new char[] { ':' });
                int id = Convert.ToInt32(split[0]);
                _cancelledShift = _cancelledShiftController.GetById(id);

                ChooseEmployeeByAvailability form = new ChooseEmployeeByAvailability(_loggedInEmployee, _cancelledShift);
                //this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("The cancelled shift was not selected!"); // maybe not needed
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            rbtnAssigned.Checked = false;
            rbtnCurrent.Checked = false;
            rbtnNotAssigned.Checked = false;
            rbtnPast.Checked = false;
            rbtnSent.Checked = false;
            rbtnViewed.Checked = false;

            lbxCancelledShifts.Items.Clear();
            _cancelledShiftsShown = _cancelledShiftController.GetAll();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }


        private void rbtnPast_CheckedChanged(object sender, EventArgs e)
        {
            _cancelledShiftsShown = _cancelledShiftController.GetAllInThePast();

            lbxCancelledShifts.Items.Clear();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void rbtnCurrent_CheckedChanged(object sender, EventArgs e)
        {
            _cancelledShiftsShown = _cancelledShiftController.GetAllInTheFuture();

            lbxCancelledShifts.Items.Clear();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void rbtnSent_CheckedChanged(object sender, EventArgs e)
        {
            _cancelledShiftsShown = _cancelledShiftController.GetAllByStatus(false);


            lbxCancelledShifts.Items.Clear();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void rbtnViewed_CheckedChanged(object sender, EventArgs e)
        {
            _cancelledShiftsShown = _cancelledShiftController.GetAllByStatus(true);


            lbxCancelledShifts.Items.Clear();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void rbtnAssigned_CheckedChanged(object sender, EventArgs e)
        {
            _cancelledShiftsShown = _cancelledShiftController.GetAllIfNewEmpAssigned(true);

            lbxCancelledShifts.Items.Clear();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void rbtnNotAssigned_CheckedChanged(object sender, EventArgs e)
        {
            _cancelledShiftsShown = _cancelledShiftController.GetAllIfNewEmpAssigned(false);

            lbxCancelledShifts.Items.Clear();
            foreach (var shift in _cancelledShiftsShown)
                lbxCancelledShifts.Items.Add(shift.GetShortToString());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonVacations_Click(object sender, EventArgs e)
        {
            AdminVacationsForm form = new(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
