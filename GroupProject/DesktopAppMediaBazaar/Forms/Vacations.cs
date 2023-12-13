using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using BussinessLayer.Controllers.Shifts;

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

            InitializeDataGridView(); // Call this method to set up the DataGridView
        }

        private void InitializeDataGridView()
        {
            dgvVacations.AutoGenerateColumns = false;
            dgvVacations.DataSource = vacationController.ReadAll();

            // Define columns for DataGridView
            dgvVacations.Columns.Add("EmployeeName", "Employee");
            dgvVacations.Columns["EmployeeName"].DataPropertyName = "Employee";

            // Add Status column
            dgvVacations.Columns.Add("Status", "Status");
            dgvVacations.Columns["Status"].DataPropertyName = "Approved";

            // Cell formatting for color coding
            dgvVacations.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvVacations_CellFormatting);

            InitializeDataGridViewStyles();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ShowVacationDetails();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvVacations.SelectedRows.Count > 0)
            {
                vacation = dgvVacations.SelectedRows[0].DataBoundItem as Vacation;

                if (!vacation.Approved || vacation.Pending)
                {
                    vacation.Pending = false;
                    vacation.Approved = true;
                    vacationController.Update(vacation);

                    Shift[] shifts = shiftController.GetShiftsFromVacation(vacation);
                    CreateAnnouncement(vacation);
                    RJMessageBox.Show("Vacation has been approved.");
                }
                else
                {
                    RJMessageBox.Show("This vacation is already approved.");
                }

                RefreshVacationList();
                dgvVacations.Refresh();
            }
            else
            {
                RJMessageBox.Show("No vacation selected.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvVacations.SelectedRows.Count > 0)
            {
                vacation = dgvVacations.SelectedRows[0].DataBoundItem as Vacation;

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
                dgvVacations.Refresh();
            }
            else
            {
                RJMessageBox.Show("No vacation selected.");
            }
        }


        private void ShowVacationDetails()
        {
            if (dgvVacations.SelectedRows.Count > 0)
            {
                vacation = dgvVacations.SelectedRows[0].DataBoundItem as Vacation;
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

        private void RefreshVacationList()
        {
            int? selectedVacationId = vacation?.Id;

            var vacations = vacationController.ReadAll();
            dgvVacations.DataSource = null;
            dgvVacations.DataSource = vacations;

            if (selectedVacationId.HasValue)
            {
                foreach (DataGridViewRow row in dgvVacations.Rows)
                {
                    Vacation v = row.DataBoundItem as Vacation;
                    if (v.Id == selectedVacationId.Value)
                    {
                        dgvVacations.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void InitializeDataGridViewStyles()
        {
            #region COLORS DATAGRID
            dgvVacations.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dgvVacations.DefaultCellStyle.SelectionForeColor = dgvVacations.DefaultCellStyle.ForeColor;
            dgvVacations.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dgvVacations.RowHeadersDefaultCellStyle.SelectionForeColor = dgvVacations.RowHeadersDefaultCellStyle.ForeColor;
            dgvVacations.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVacations.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dgvVacations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVacations.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dgvVacations.BackgroundColor = Color.FromArgb(156, 84, 213);
            dgvVacations.GridColor = Color.FromArgb(156, 84, 213);
            dgvVacations.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dgvVacations.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dgvVacations.DefaultCellStyle.ForeColor = Color.FromArgb(215, 215, 215);
            dgvVacations.DefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dgvVacations.DefaultCellStyle.SelectionForeColor = Color.FromArgb(127, 131, 140);
            dgvVacations.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(215, 215, 215);
            dgvVacations.EnableHeadersVisualStyles = false;
            dgvVacations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVacations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvVacations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVacations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVacations.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dgvVacations.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dgvVacations.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dgvVacations.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }

            #endregion

        }

        private void dgvVacations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVacations.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                Vacation vacation = dgvVacations.Rows[e.RowIndex].DataBoundItem as Vacation;
                if (vacation != null)
                {
                    Color backColor = vacation.Approved ? Color.Green : Color.Red;
                    Color foreColor = Color.White; // For better visibility

                    dgvVacations.Rows[e.RowIndex].Cells["Status"].Style.BackColor = backColor;
                    dgvVacations.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = foreColor;
                }
            }
        }
        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVacations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
