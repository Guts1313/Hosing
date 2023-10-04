using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using ClassLibrary.DBHelpers;
using ClassLibrary.Interfaces;
using DataAccessLayer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar
{
    public partial class AdminVacationsForm : Form
    {
        private VacationController vacationController = new(new DALVacationController());
        private ShiftController shiftController = new(new DALShiftController());
        private CancelledShiftController cancelledShiftController = new(new DALCancelledShiftController());
        Employee _loggedInEmployee;
        private Vacation vacation = null;
        public AdminVacationsForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;

            foreach (Vacation vacation in vacationController.ReadAll())
            {
                listBoxVacations.Items.Add(vacation.ToString());
            }

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

        private void btnCancelledShifts_Click(object sender, EventArgs e)
        {
            AdminCancelledShiftsForm form = new AdminCancelledShiftsForm(_loggedInEmployee);
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

        private void AdminVacationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            vacation.Pending = false;
            vacation.Approved = false;

            vacationController.Update(vacation);

            btnApprove.Visible = false;
            btnReject.Visible = false;
            labelStatus.Text = "Status: Rejected";
            labelStatus.Visible = true;

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            vacation.Pending = false;
            vacation.Approved = true;

            vacationController.Update(vacation);

            Shift[] shifts = shiftController.GetShiftsFromVacation(vacation);

            foreach (Shift shift in shifts)
            {
                CancelledShift cancelledShift = new CancelledShift();
                cancelledShift.AssignedEmployee = shift.Employee;
                cancelledShift.Shift = shift;
                cancelledShift.Reason = $"Vacation from {vacation.StartDate} until {vacation.EndDate}";
                cancelledShift.IsViewed = true;
                cancelledShiftController.Add(cancelledShift, new DALShiftController());
            }

            btnApprove.Visible = false;
            btnReject.Visible = false;
            labelStatus.Text = "Status: Approved";
            labelStatus.Visible = true;

            CreateAnnouncement(vacation);
        }

        private void listBoxVacations_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelEmployee.Visible = false;
            labelStartDate.Visible = false;
            labelEndDate.Visible = false;
            labelReason.Visible = false;

            btnApprove.Visible = false;
            btnReject.Visible = false;

            labelStatus.Visible = false;



            int id = listBoxVacations.SelectedIndex;
            if (id != -1)
            {
                string[] split = listBoxVacations.SelectedItem.ToString().Split(new char[] { ':' });

                int vacationId = Convert.ToInt32(split[0]);

                vacation = vacationController.ReadById(vacationId);

                labelEmployee.Text = $"Employee: {vacation.Employee.Name}";
                labelStartDate.Text = $"Start date: {vacation.StartDate.ToShortDateString()}";
                labelEndDate.Text = $"End date: {vacation.EndDate.ToShortDateString()}";
                labelReason.Text = $"Reason: {vacation.Reason}";

                labelEmployee.Visible = true;
                labelStartDate.Visible = true;
                labelEndDate.Visible = true;
                labelReason.Visible = true;

                if (vacation.Pending == true)
                {
                    btnApprove.Visible = true;
                    btnReject.Visible = true;
                }
                else
                {
                    if (vacation.Approved)
                    {
                        btnApprove.Visible = false;
                        btnReject.Visible = false;

                        labelStatus.Text = "Status: Approved";
                        labelStatus.Visible = true;
                    }
                    else
                    {
                        btnApprove.Visible = false;
                        btnReject.Visible = false;

                        labelStatus.Text = "Status: Rejected";
                        labelStatus.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list!");
            }
        }

        public void CreateAnnouncement(Vacation vacation)
        {
            AnnouncemetsController announcementsController = new(new DALAnnouncementsController());

            string title = $"Empty shifts between {vacation.StartDate.ToShortDateString()} and {vacation.EndDate.ToShortDateString()}";

            string details = $"Between {vacation.StartDate.ToShortDateString()} and {vacation.EndDate.ToShortDateString()} there will be empty shifts in the {vacation.Employee.Department.Name} department. If you want to take an extra shift, please contact an admin via telephone.";

            DateOnly startDate = DateOnly.FromDateTime(vacation.StartDate.ToDateTime(TimeOnly.MinValue).AddDays(-7));
            DateOnly endDate = vacation.EndDate;

            Announcements announcement = new(title, details, startDate, endDate)
            {
                VacationId = vacation.Id
            };

            announcementsController.CreateAnnouncement(announcement);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminLandingForm form = new AdminLandingForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
