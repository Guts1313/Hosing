using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DesktopAppMediaBazaar.Classes;
using BussinessLayer.Utilities.Messages;
using BussinessLayer.Controllers;
using DataAccessLayer.DAL;

namespace DesktopAppMediaBazaar.ChildFormsUtility
{
    public partial class AnnouncementsAddEdit : Form
    {
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

        public enum FormMode { Add, Edit }

        private readonly FormMode _mode;
        private readonly Announcements _announcementToEdit;
        private readonly AnnouncementsManager _announcementss;
        private Employee _loggedInEmpl;
        private EmployeeController employeeController;

        public AnnouncementsAddEdit(FormMode mode, Announcements announcementToEdit = null, Employee loggedInEmpl = null)
        {
            InitializeComponent();
            _mode = mode;
            _announcementToEdit = announcementToEdit;
            _announcementss = new AnnouncementsManager();
            employeeController = new EmployeeController(new DALEmployeeController());
            _loggedInEmpl = loggedInEmpl;

            if (mode == FormMode.Edit && announcementToEdit != null)
            {
                tbxTitle.Texts = _announcementToEdit.Title.Trim();
                tbxDescription.Texts = _announcementToEdit.Details.Trim();
                startDate.Value = _announcementToEdit.StartDate.ToDateTime(TimeOnly.MinValue);
                endDate.Value = _announcementToEdit.EndDate.ToDateTime(TimeOnly.MinValue);
            }

            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool TrySaveAnnouncement(out string errorMessage)
        {
            errorMessage = "";
            try
            {
                bool success;

                if (_mode == FormMode.Add)
                {
                    Announcements newAnnouncement = new Announcements
                    {
                        Title = tbxTitle.Texts,
                        Details = tbxDescription.Texts,
                        StartDate = DateOnly.FromDateTime(startDate.Value),
                        EndDate = DateOnly.FromDateTime(endDate.Value)
                    };

                    try
                    {
                        foreach (var employee in employeeController.GetAll())
                        {
                            string subject = string.Format(EmailMessages.ANNOUNCEMENT_SUBJECT, employee.Name, "admin1");
                            string body = string.Format(EmailMessages.ANNOUNCEMENT_BODY, tbxDescription.Texts);

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
                    }

                    success = _announcementss.AddAnnouncement(newAnnouncement);
                }
                else
                {
                    _announcementToEdit.Title = tbxTitle.Texts;
                    _announcementToEdit.Details = tbxDescription.Texts;
                    _announcementToEdit.StartDate = DateOnly.FromDateTime(startDate.Value);
                    _announcementToEdit.EndDate = DateOnly.FromDateTime(endDate.Value);

                    success = _announcementss.UpdateAnnouncement(_announcementToEdit);
                }

                return success;
            }
            catch (Exception ex)
            {
                errorMessage = $"An error occurred while saving the announcement: {ex.Message}";
                return false;
            }
        }

        private void SendEmail()
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxTitle.Texts) || string.IsNullOrWhiteSpace(tbxDescription.Texts))
            {
                RJMessageBox.Show("Title and description cannot be empty.");
                return;
            }

            if (startDate.Value.Date > endDate.Value.Date)
            {
                RJMessageBox.Show("Start date must be before end date.");
                return;
            }

            if (TrySaveAnnouncement(out string errorMessage))
            {
                RJMessageBox.Show("Announcement saved successfully.");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                RJMessageBox.Show(errorMessage);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
    }
}
