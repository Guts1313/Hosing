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
using DesktopAppMediaBazaar.CustomElements;
using BussinessLayer.Controllers;
using DataAccessLayer.DAL;

namespace DesktopAppMediaBazaar.Forms
{
    public partial class Vacations : Form
    {
        private VacationController vacationController = new(new DALVacationController());
        private ShiftController shiftController = new(new DALShiftController());
        //private CancelledShiftController cancelledShiftController = new(new DALCancelledShiftController());
        Employee _loggedInEmployee;
        private Vacation vacation = null;
        public Vacations(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;

            var vacations = vacationController.ReadAll();
            lbVacation.DataSource = vacations;
            lbVacation.DisplayMember = "DisplayInfo";
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ShowVacationDetails();
        }

        private void lbVacation_DoubleClick(object sender, EventArgs e)
        {
            ShowVacationDetails();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (vacation != null)
            {
                if (!vacation.Approved || vacation.Pending)
                {
                    vacation.Pending = false;
                    vacation.Approved = true;
                    vacationController.Update(vacation);

                    Shift[] shifts = shiftController.GetShiftsFromVacation(vacation);
                    /* foreach (Shift shift in shifts)
                    {
                        // CancelledShift cancelledShift = new CancelledShift();
                        // cancelledShift.AssignedEmployee = shift.Employee;
                        // cancelledShift.Shift = shift;
                        // cancelledShift.Reason = $"Vacation from {vacation.StartDate} until {vacation.EndDate}";
                        // cancelledShift.IsViewed = true;
                        // cancelledShiftController.Add(cancelledShift, new DALShiftController());
                    } */

                    CreateAnnouncement(vacation);
                    RJMessageBox.Show("Vacation has been approved.");
                }
                else
                {
                    RJMessageBox.Show("This vacation is already approved.");
                }

                RefreshVacationList();
            }
            else
            {
                RJMessageBox.Show("No vacation selected.");
            }
        }


        private void btnReject_Click(object sender, EventArgs e)
        {
            if (vacation != null)
            {
                if (vacation.Approved || vacation.Pending)
                {
                    vacation.Pending = false;
                    vacation.Approved = false;
                    vacationController.Update(vacation);

                    RJMessageBox.Show("Vacation has been rejected.");
                }
                else
                {
                    RJMessageBox.Show("This vacation is already rejected.");
                }

                RefreshVacationList();
            }
            else
            {
                RJMessageBox.Show("No vacation selected.");
            }
        }


        private void ShowVacationDetails()
        {
            if (vacation != null)
            {
                string details = $"Employee: {vacation.Employee.Name}\n" +
                                 $"Start Date: {vacation.StartDate}\n" +
                                 $"End Date: {vacation.EndDate}\n" +
                                 $"Reason: {vacation.Reason}\n" +
                                 $"Approved: {vacation.Approved}\n" +
                                 $"Pending: {vacation.Pending}";
                RJMessageBox.Show(details, "Vacation Details");
            }
            else
            {
                RJMessageBox.Show("No vacation selected.");
            }
        }

        public void CreateAnnouncement(Vacation vacation)
        {
            AnnouncemetsController announcementsController = new(new DALAnnouncementsController());

            string title = $"Empty shifts between {vacation.StartDate.ToShortDateString()} and {vacation.EndDate.ToShortDateString()}";

            string details = $"Between {vacation.StartDate.ToShortDateString()} and {vacation.EndDate.ToShortDateString()} there will be empty shifts in the {vacation.Employee.Department.Name} department. If you want to take an extra shift, please contact an admin via email.";

            DateOnly startDate = vacation.StartDate;
            DateOnly endDate = vacation.EndDate;

            Announcements announcement = new(title, details, startDate, endDate)
            {
                VacationId = vacation.Id
            };

            announcementsController.CreateAnnouncement(announcement);
        }

        private void lbVacation_SelectedIndexChanged(object sender, EventArgs e)
        {
            vacation = lbVacation.SelectedItem as Vacation;

            if (vacation != null)
            {
                btnApprove.Visible = !vacation.Approved || vacation.Pending;
                btnReject.Visible = vacation.Approved || vacation.Pending;
            }
            else
            {
                btnApprove.Visible = false;
                btnReject.Visible = false;
            }
        }

        private void RefreshVacationList()
        {
            int? selectedVacationId = vacation?.Id;

            var vacations = vacationController.ReadAll();
            lbVacation.DataSource = null;
            lbVacation.DataSource = vacations;
            lbVacation.DisplayMember = "DisplayInfo";

            if (selectedVacationId.HasValue)
            {
                foreach (var v in vacations)
                {
                    if (v.Id == selectedVacationId.Value)
                    {
                        lbVacation.SelectedItem = v;
                        break;
                    }
                }
            }
        }
    }
}
