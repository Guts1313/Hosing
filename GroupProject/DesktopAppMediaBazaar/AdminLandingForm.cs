using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using ClassLibrary.DBHelpers;
using DataAccessLayer;

namespace DesktopAppMediaBazaar
{
    public partial class AdminLandingForm : Form
    {
        private Employee _loggedInEmployee;
        private Announcements _announcements = null;
        public AnnouncemetsController AnnouncementsController { get; private set; } = new(new DALAnnouncementsController());

        public AdminLandingForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            labelWelcome.Text = "Welcome, " + _loggedInEmployee.Username + "!";
            foreach (Announcements announcements in AnnouncementsController.GetAll())
            {
                lbAnnouncements.Items.Add(announcements.ToString());
            }
        }

        private void AdminLandingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private int selectedAnnouncementId = -1;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTitle.Hide();
            tbDetails.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            btnSubmit.Hide();
            buttonCancel.Hide();

            int index = lbAnnouncements.SelectedIndex;
            if (index != -1)
            {
                string[] split = lbAnnouncements.SelectedItem.ToString().Split(new char[] { ':' });
                int announcementId = Convert.ToInt32(split[0]);
                _announcements = AnnouncementsController.GetById(announcementId);
                lblTitle.Text = "Title: " + _announcements.Title;
                lblDetails.Text = "Details: " + _announcements.Details;
                lblStart.Text = "Start Date: " + _announcements.StartDate.ToString();
                lblEndDate.Text = "End Date: " + _announcements.EndDate.ToString();

                lblTitle.Show();
                lblDetails.Show();
                lblStart.Show();
                lblEndDate.Show();
                btnEdit.Show();
                btnDelete.Show();

                selectedAnnouncementId = announcementId; // Update the selected announcement ID
            }
            else
            {
                MessageBox.Show("Please select an item from the list!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] split = lbAnnouncements.SelectedItem.ToString().Split(new char[] { ':' });
            int announcementId = Convert.ToInt32(split[0]);
            Announcements announcements = AnnouncementsController.GetById(announcementId);
            if (AnnouncementsController.DeleteAnnouncement(announcements))
            {
                MessageBox.Show("Announcement deleted");
                lbAnnouncements.Items.Clear();
                foreach (Announcements announcement in AnnouncementsController.GetAll())
                {
                    lbAnnouncements.Items.Add(announcement.ToString());
                }
                return;
            }
            else
            {
                MessageBox.Show("Error deleting announcement");
                return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAnnouncementForm form = new CreateAnnouncementForm(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedAnnouncementId != -1)
            {
                Announcements announcements = AnnouncementsController.GetById(selectedAnnouncementId);
                lblTitle.Show();
                lblTitle.Text = "Title: ";
                lblDetails.Show();
                lblDetails.Text = "Details: ";
                lblStart.Show();
                lblStart.Text = "Start Date: ";
                lblEndDate.Show();
                lblEndDate.Text = "End Date: ";

                tbTitle.Text = announcements.Title;
                tbDetails.Text = announcements.Details;
                dateTimePicker1.Value = announcements.StartDate.ToDateTime(TimeOnly.MinValue);
                dateTimePicker2.Value = announcements.EndDate.ToDateTime(TimeOnly.MinValue);

                btnEdit.Show();
                btnDelete.Show();
                tbTitle.Show();
                tbDetails.Show();
                dateTimePicker1.Show();
                dateTimePicker2.Show();
                btnSubmit.Show();
                buttonCancel.Show();

            }
            else
            {
                MessageBox.Show("Please select an item from the list!");
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] split = lbAnnouncements.SelectedItem.ToString().Split(new char[] { ':' });
            int announcementId = Convert.ToInt32(split[0]);
            Announcements announcements = AnnouncementsController.GetById(announcementId);
            if (announcements.EndDate < DateOnly.FromDateTime(DateTime.Today))
            {
                MessageBox.Show("Cannot edit announcement in the past");
                return;
            }
            else
            {
                announcements.Title = tbTitle.Text;
                announcements.Details = tbDetails.Text;
                announcements.StartDate = DateOnly.FromDateTime(dateTimePicker1.Value);
                announcements.EndDate = DateOnly.FromDateTime(dateTimePicker2.Value);
                if (AnnouncementsController.UpdateAnnouncement(announcements))
                {
                    MessageBox.Show("Announcement updated");
                    buttonCancel_Click(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("Error creating announcement");
                    return;
                }
            }
        }

        private void rBtnPast_CheckedChanged(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            foreach (Announcements announcements in AnnouncementsController.GetAll())
            {
                if (announcements.EndDate < DateOnly.FromDateTime(DateTime.Today))
                    lbAnnouncements.Items.Add(announcements.ToString());
            }
        }

        private void rBtnFuture_CheckedChanged(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            foreach (Announcements announcements in AnnouncementsController.GetAll())
            {
                if (announcements.StartDate > DateOnly.FromDateTime(DateTime.Today))
                    lbAnnouncements.Items.Add(announcements.ToString());
            }
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            foreach (Announcements announcements in AnnouncementsController.GetAll())
            {
                lbAnnouncements.Items.Add(announcements.ToString());
            }
        }

        private void rBtnCurrent_CheckedChanged(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            foreach (Announcements announcements in AnnouncementsController.GetAll())
            {
                if (announcements.StartDate <= DateOnly.FromDateTime(DateTime.Today) && announcements.EndDate >= DateOnly.FromDateTime(DateTime.Today))
                    lbAnnouncements.Items.Add(announcements.ToString());
            }
        }

        private void buttonVacations_Click(object sender, EventArgs e)
        {
            AdminVacationsForm form = new(_loggedInEmployee);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            tbTitle.Hide();
            tbDetails.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            btnSubmit.Hide();
            buttonCancel.Hide();

            int index = lbAnnouncements.SelectedIndex;
            if (index != -1)
            {
                string[] split = lbAnnouncements.SelectedItem.ToString().Split(new char[] { ':' });
                int announcementId = Convert.ToInt32(split[0]);
                _announcements = AnnouncementsController.GetById(announcementId);
                lblTitle.Text = "Title: " + _announcements.Title;
                lblDetails.Text = "Details: " + _announcements.Details;
                lblStart.Text = "Start Date: " + _announcements.StartDate.ToString();
                lblEndDate.Text = "End Date: " + _announcements.EndDate.ToString();

                lblTitle.Show();
                lblDetails.Show();
                lblStart.Show();
                lblEndDate.Show();
                btnEdit.Show();
                btnDelete.Show();

                selectedAnnouncementId = announcementId;
            }
        }
    }
}
