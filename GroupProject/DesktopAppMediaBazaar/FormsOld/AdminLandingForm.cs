using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Controllers;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.ChildFormsUtility;
using DesktopAppMediaBazaar.Classes;

namespace DesktopAppMediaBazaar
{
    public partial class AdminLandingForm : Form
    {
        private Employee _loggedInEmployee;
        private Announcements _announcements = null;
        private AnnouncementsManager _announcementss;

        public AdminLandingForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            _announcementss = new AnnouncementsManager(); // Initialize your new class
            labelWelcome.Text = $"Welcome, {_loggedInEmployee.Username}!";
            RefreshAnnouncementsList();
        }

        private void RefreshAnnouncementsList()
        {
            lbAnnouncements.Items.Clear();
            foreach (var announcement in _announcementss.GetAllAnnouncements())
            {
                lbAnnouncements.Items.Add(announcement.ToString());
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

        /*        private void btnCancelledShifts_Click(object sender, EventArgs e)
                {
                    AdminCancelledShiftsForm form = new AdminCancelledShiftsForm(_loggedInEmployee);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }*/

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInEmployee = null;
            Login form = new Login();
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
                _announcements = _announcementss.GetAnnouncementById(announcementId);
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
            if (lbAnnouncements.SelectedItem != null)
            {
                string[] split = lbAnnouncements.SelectedItem.ToString().Split(':');
                int announcementId = Convert.ToInt32(split[0]);
                Announcements announcementToDelete = _announcementss.GetAnnouncementById(announcementId);
                if (_announcementss.DeleteAnnouncement(announcementToDelete))
                {
                    MessageBox.Show("Announcement deleted");
                    RefreshAnnouncementsList();
                }
                else
                {
                    MessageBox.Show("Error deleting announcement");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list!");
            }
        }

        /*        private void btnCreate_Click(object sender, EventArgs e)
                {
                    CreateAnnouncementForm form = new CreateAnnouncementForm(_loggedInEmployee);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }*/

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedAnnouncementId != -1)
            {
                // Use _announcementss to get the announcement by ID
                Announcements announcements = _announcementss.GetAnnouncementById(selectedAnnouncementId);

                if (announcements != null)
                {
                    // Open the Announcement_Add_Edit form in Edit mode with the selected announcement
                    AnnouncementsAddEdit form = new AnnouncementsAddEdit(AnnouncementsAddEdit.FormMode.Edit, announcements);
                    form.FormClosed += (s, args) => RefreshAnnouncementsList();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Announcement not found!");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list!");
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lbAnnouncements.SelectedItem != null)
            {
                string[] split = lbAnnouncements.SelectedItem.ToString().Split(new char[] { ':' });
                int announcementId = Convert.ToInt32(split[0]);
                Announcements announcements = _announcementss.GetAnnouncementById(announcementId);
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
                    if (_announcementss.UpdateAnnouncement(announcements))
                    {
                        MessageBox.Show("Announcement updated");
                        RefreshAnnouncementsList(); // Assuming you have a method to refresh the list
                        buttonCancel_Click(sender, e); // This resets the form, you might want to call a different method to just reset the UI without losing selection
                    }
                    else
                    {
                        MessageBox.Show("Error updating announcement");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list!");
            }
        }


        private void rBtnPast_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPast.Checked)
            {
                lbAnnouncements.Items.Clear();
                foreach (var announcement in _announcementss.GetAllAnnouncements())
                {
                    if (announcement.EndDate < DateOnly.FromDateTime(DateTime.Today))
                        lbAnnouncements.Items.Add(announcement.ToString());
                }
            }
        }

        private void rBtnFuture_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnFuture.Checked)
            {
                lbAnnouncements.Items.Clear();
                foreach (var announcement in _announcementss.GetAllAnnouncements())
                {
                    if (announcement.StartDate > DateOnly.FromDateTime(DateTime.Today))
                        lbAnnouncements.Items.Add(announcement.ToString());
                }
            }
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAll.Checked)
            {
                RefreshAnnouncementsList();
            }
        }

        private void rBtnCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCurrent.Checked)
            {
                lbAnnouncements.Items.Clear();
                foreach (var announcement in _announcementss.GetAllAnnouncements())
                {
                    if (announcement.StartDate <= DateOnly.FromDateTime(DateTime.Today) && announcement.EndDate >= DateOnly.FromDateTime(DateTime.Today))
                        lbAnnouncements.Items.Add(announcement.ToString());
                }
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
            // Hide editing controls
            tbTitle.Hide();
            tbDetails.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            btnSubmit.Hide();
            buttonCancel.Hide();

            // Clear details labels
            lblTitle.Text = "";
            lblDetails.Text = "";
            lblStart.Text = "";
            lblEndDate.Text = "";

            // If an announcement is selected, display its details
            int index = lbAnnouncements.SelectedIndex;
            if (index != -1)
            {
                string[] split = lbAnnouncements.SelectedItem.ToString().Split(new char[] { ':' });
                int announcementId = Convert.ToInt32(split[0]);
                _announcements = _announcementss.GetAnnouncementById(announcementId);
                if (_announcements != null)
                {
                    lblTitle.Text = "Title: " + _announcements.Title;
                    lblDetails.Text = "Details: " + _announcements.Details;
                    lblStart.Text = "Start Date: " + _announcements.StartDate.ToString();
                    lblEndDate.Text = "End Date: " + _announcements.EndDate.ToString();
                }
                else
                {
                    MessageBox.Show("Announcement not found.");
                }

                // Show details labels and edit/delete buttons
                lblTitle.Show();
                lblDetails.Show();
                lblStart.Show();
                lblEndDate.Show();
                btnEdit.Show();
                btnDelete.Show();

                // Update the selected announcement ID
                selectedAnnouncementId = announcementId;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
