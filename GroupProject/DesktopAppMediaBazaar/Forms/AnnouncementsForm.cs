using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.ChildFormsUtility;
using DesktopAppMediaBazaar.Classes;
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

namespace DesktopAppMediaBazaar.ChildForms
{
    public partial class AnnouncementsForm : Form
    {
        private Employee _loggedInEmployee;
        private AnnouncementsManager _announcementsManager;
        private Announcements _selectedAnnouncement;
        public AnnouncementsForm(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
            _announcementsManager = new AnnouncementsManager();
        }

        private async void AnnouncementsForm_Load(object sender, EventArgs e)
        {
            await RefreshAnnouncementsListAsync();
        }

        private async Task RefreshAnnouncementsListAsync()
        {
            lbAnnouncements.Items.Clear();
            var announcements = _announcementsManager.GetAllAnnouncements();
            foreach (var announcement in announcements)
            {
                lbAnnouncements.Items.Add(announcement);
            }
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnnouncements.SelectedItem is Announcements announcement)
            {
                _selectedAnnouncement = announcement;
            }
        }

        private void lbAnnouncements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectedAnnouncement != null)
            {
                RJMessageBox.Show(_selectedAnnouncement.Details, "Announcement Details");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnnouncementsAddEdit form = new AnnouncementsAddEdit(AnnouncementsAddEdit.FormMode.Add);
            form.FormClosed += (s, args) => RefreshAnnouncementsListAsync();
            form.ShowDialog();
        }

        private int selectedAnnouncementId = -1;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedAnnouncement != null)
            {
                AnnouncementsAddEdit form = new AnnouncementsAddEdit(AnnouncementsAddEdit.FormMode.Edit, _selectedAnnouncement);
                form.FormClosed += (s, args) => RefreshAnnouncementsListAsync();
                form.ShowDialog();
            }
            else
            {
                RJMessageBox.Show("Please select an announcement to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAnnouncement != null)
            {
                if (RJMessageBox.Show("Are you sure you want to delete this announcement?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_announcementsManager.DeleteAnnouncement(_selectedAnnouncement))
                    {
                        RJMessageBox.Show("Announcement deleted successfully.");
                        RefreshAnnouncementsListAsync();
                    }
                    else
                    {
                        RJMessageBox.Show("There was a problem deleting the announcement.");
                    }
                }
            }
            else
            {
                RJMessageBox.Show("Please select an announcement to delete.");
            }
        }

        private void FilterAnnouncements(Func<Announcements, bool> filter)
        {
            lbAnnouncements.Items.Clear();
            var filteredAnnouncements = _announcementsManager.GetAllAnnouncements().Where(filter);
            foreach (var announcement in filteredAnnouncements)
            {
                lbAnnouncements.Items.Add(announcement);
            }
        }

        private void rBtnPast_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPast.Checked)
            {
                FilterAnnouncements(a => a.EndDate < DateOnly.FromDateTime(DateTime.Today));
            }
        }


        private void rBtnCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCurrent.Checked)
            {
                FilterAnnouncements(a => a.StartDate <= DateOnly.FromDateTime(DateTime.Today) &&
                                         a.EndDate >= DateOnly.FromDateTime(DateTime.Today));
            }
        }

        private void rBtnFuture_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFuture.Checked)
            {
                FilterAnnouncements(a => a.StartDate > DateOnly.FromDateTime(DateTime.Today));
            }
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                RefreshAnnouncementsListAsync();
            }
        }
    }
}
