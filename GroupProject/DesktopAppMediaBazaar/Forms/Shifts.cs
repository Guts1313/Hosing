using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using DesktopAppMediaBazaar.CustomElements;
using DesktopAppMediaBazaar.FormsUtility;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.Forms
{
    public partial class Shifts : Form
    {
        private Employee _loggedInEmployee;
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public ShiftController ShiftController { get; private set; } = new(new DALShiftController());
        public DepartmentController DepartmentController { get; private set; } = new(new DALDepartmentController());
        Department _selectedDepartment;
        DateTime _selectedDate;

        public Shifts(Employee loggedInEmployee)
        {
            InitializeComponent();
            InitializeDataGridViewStyles();

            _loggedInEmployee = loggedInEmployee;

            getAllShifts();

            foreach (Department department in DepartmentController.GetAll())
            {
                cbxDepartment.Items.Add(department.Name);
            }
            cbxDepartment.SelectedIndex = -1;
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

        private void getAllShifts()
        {
            var shifts = ShiftController.GetAll()
                .Select(shift => new ShiftDisplayInfo
                {
                    id = shift.Id,
                    time = shift.Date,
                    date = shift.Date.DayOfWeek,
                    shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
                    Name = shift.Employee.Name,
                })
                .ToList();

            dataGridViewShifts.Columns.Clear();
            dataGridViewShifts.DataSource = shifts;
            AdjustDataGridViewColumns();
        }

        private void AdjustDataGridViewColumns()
        {
            dataGridViewShifts.Columns.Add("time", "Date");
            dataGridViewShifts.Columns.Add("date", "Day of Week");
            dataGridViewShifts.Columns.Add("shiftType", "Shift Type");
            dataGridViewShifts.Columns.Add("Name", "Name");

            dataGridViewShifts.Columns["time"].DataPropertyName = "time";
            dataGridViewShifts.Columns["date"].DataPropertyName = "date";
            dataGridViewShifts.Columns["shiftType"].DataPropertyName = "shiftType";
            dataGridViewShifts.Columns["Name"].DataPropertyName = "Name";

            dataGridViewShifts.Columns["time"].HeaderText = "Date";
            dataGridViewShifts.Columns["date"].HeaderText = "Day of Week";
            dataGridViewShifts.Columns["shiftType"].HeaderText = "Shift Type";
            dataGridViewShifts.Columns["Name"].HeaderText = "Name";
        }

        private void btnAutoShifts_Click(object sender, EventArgs e)
        {
            ShiftAutoAdd form = new ShiftAutoAdd(ShiftController, dataGridViewShifts);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShiftAdd form = new ShiftAdd(DepartmentController, _loggedInEmployee, EmployeeController, ShiftController, dataGridViewShifts);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.CurrentRow != null)
            {
                var shiftInfo = (ShiftDisplayInfo)dataGridViewShifts.CurrentRow.DataBoundItem;
                Shift shift = ShiftController.GetById(shiftInfo.id);
                if (shift != null)
                {
                    ShiftController.DeleteShift(shift);
                    getAllShifts();
                }
            }
            else
            {
                RJMessageBox.Show("Please select a shift!");
            }
        }

        private void Calendar_ValueChanged(object sender, EventArgs e)
        {
            _selectedDate = Calendar.Value.Date; // custom calendar has no methods to choose dates
        }


        private void cbxDepartment_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string departmentName = cbxDepartment.SelectedItem.ToString();
            _selectedDepartment = DepartmentController.Get(departmentName);
            //Shift[] shifts = ShiftController.GetAllByDateAndDepartment(_selectedDate, _selectedDepartment);

            var shifts = ShiftController.GetAll()
                .Where(shift => shift.Employee.Department.Name == departmentName)
                .Select(shift => new ShiftDisplayInfo
                {
                    time = shift.Date,
                    date = shift.Date.DayOfWeek,
                    shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
                    Name = shift.Employee.Name,
                })
                .ToList();

            dataGridViewShifts.Columns.Clear();
            dataGridViewShifts.DataSource = shifts;
            AdjustDataGridViewColumns();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //lbEmployees.Items.Clear();
            if (_selectedDate == default(DateTime))
            {
                RJMessageBox.Show("The date was not selected!");
                return;
            }
            if (cbxDepartment.SelectedIndex == -1)
            {
                RJMessageBox.Show("The department was not selected!");
                return;
            }

            var shifts = ShiftController.GetAllByDateAndDepartment(_selectedDate, _selectedDepartment)
                .Select(shift => new ShiftDisplayInfo
                {
                    time = shift.Date,
                    date = shift.Date.DayOfWeek,
                    shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
                    Name = shift.Employee.Name,
                })
                .ToList();

            dataGridViewShifts.Columns.Clear();
            dataGridViewShifts.DataSource = shifts;
            AdjustDataGridViewColumns();
        }


        private void tbxName__TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxName.Texts.ToLower();

            if (searchText.Length >= 1)
            {
                List<int> shiftTypeBinary = new List<int>();

                if (morningCheckBox.Checked)
                { shiftTypeBinary.Add((int)ShiftType.Morning); }
                if (afterNoonCheckBox.Checked)
                { shiftTypeBinary.Add((int)ShiftType.Afternoon); }
                if (eveningCheckBox.Checked)
                { shiftTypeBinary.Add((int)ShiftType.Evening); }

                bool searchByShiftType = shiftTypeBinary.Count == 0 ? false : true;

                var shifts = ShiftController.GetAll()
                    .Where(shift => (searchByShiftType ? shiftTypeBinary.Contains(shift.Type) : true) && shift.Employee.Name.ToLower().Contains(searchText))
                    .Select(shift => new ShiftDisplayInfo
                    {
                        time = shift.Date,
                        date = shift.Date.DayOfWeek,
                        shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
                        Name = shift.Employee.Name,
                    })
                    .ToList();

                dataGridViewShifts.Columns.Clear();
                dataGridViewShifts.DataSource = shifts;
                AdjustDataGridViewColumns();
            }
        }


        public void FilterByShiftType()
        {
            List<int> shiftTypeBinary = new List<int>();

            if (morningCheckBox.Checked)
            {
                shiftTypeBinary.Add((int)ShiftType.Morning);
            }
            if (afterNoonCheckBox.Checked)
            {
                shiftTypeBinary.Add((int)ShiftType.Afternoon);
            }
            if (eveningCheckBox.Checked)
            {
                shiftTypeBinary.Add((int)ShiftType.Evening);
            }
            if (earlyMorningCheckBox.Checked)
            {
                shiftTypeBinary.Add((int)ShiftType.EarlyMorning);
            }
            if (earlyAfternoonCheckBox.Checked)
            {
                shiftTypeBinary.Add((int)ShiftType.EarlyAfternoon);
            }
            if (earlyEveningCheckBox.Checked)
            {
                shiftTypeBinary.Add((int)ShiftType.EarlyEvening);
            }

            var shifts = ShiftController.GetAll()
                .Where(shift => shiftTypeBinary.Contains(shift.Type))
                .Select(shift => new ShiftDisplayInfo
                {
                    time = shift.Date,
                    date = shift.Date.DayOfWeek,
                    shiftType = GetShiftTypeDisplayName(Extensions.GetFirstShift(shift.Type)),
                    Name = shift.Employee.Name,
                })
                .ToList();

            dataGridViewShifts.Columns.Clear();
            dataGridViewShifts.DataSource = shifts;
            AdjustDataGridViewColumns();
        }

        private void morningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (morningCheckBox.Checked)
            {
                FilterByShiftType();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked &&
                     !earlyMorningCheckBox.Checked && !earlyAfternoonCheckBox.Checked && !earlyEveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void afterNoonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (afterNoonCheckBox.Checked)
            {
                FilterByShiftType();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked &&
                     !earlyMorningCheckBox.Checked && !earlyAfternoonCheckBox.Checked && !earlyEveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void eveningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eveningCheckBox.Checked)
            {
                FilterByShiftType();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked &&
                     !earlyMorningCheckBox.Checked && !earlyAfternoonCheckBox.Checked && !earlyEveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void earlyMorningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (earlyMorningCheckBox.Checked)
            {
                FilterByShiftType();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked &&
                     !earlyMorningCheckBox.Checked && !earlyAfternoonCheckBox.Checked && !earlyEveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void earlyAfternoonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (earlyAfternoonCheckBox.Checked)
            {
                FilterByShiftType();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked &&
                     !earlyMorningCheckBox.Checked && !earlyAfternoonCheckBox.Checked && !earlyEveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void earlyEveningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (earlyEveningCheckBox.Checked)
            {
                FilterByShiftType();
            }
            else if (!morningCheckBox.Checked && !afterNoonCheckBox.Checked && !eveningCheckBox.Checked &&
                     !earlyMorningCheckBox.Checked && !earlyAfternoonCheckBox.Checked && !earlyEveningCheckBox.Checked)
            {
                getAllShifts();
            }
        }

        private void InitializeDataGridViewStyles()
        {
            #region COLORS DATAGRID
            dataGridViewShifts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dataGridViewShifts.DefaultCellStyle.SelectionForeColor = dataGridViewShifts.DefaultCellStyle.ForeColor;
            dataGridViewShifts.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dataGridViewShifts.RowHeadersDefaultCellStyle.SelectionForeColor = dataGridViewShifts.RowHeadersDefaultCellStyle.ForeColor;
            dataGridViewShifts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewShifts.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridViewShifts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewShifts.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridViewShifts.BackgroundColor = Color.FromArgb(156, 84, 213);
            dataGridViewShifts.GridColor = Color.FromArgb(156, 84, 213);
            dataGridViewShifts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dataGridViewShifts.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dataGridViewShifts.DefaultCellStyle.ForeColor = Color.FromArgb(215, 215, 215);
            dataGridViewShifts.DefaultCellStyle.BackColor = Color.FromArgb(156, 84, 213);
            dataGridViewShifts.DefaultCellStyle.SelectionForeColor = Color.FromArgb(127, 131, 140);
            dataGridViewShifts.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(215, 215, 215);
            dataGridViewShifts.EnableHeadersVisualStyles = false;
            dataGridViewShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewShifts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewShifts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewShifts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewShifts.AutoGenerateColumns = false;
            dataGridViewShifts.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dataGridViewShifts.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in dataGridViewShifts.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in dataGridViewShifts.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            #endregion
        }

        private void dataGridViewShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class ShiftDisplayInfo
    {
        public int id { get; set; }
        public DateTime time { get; set; }
        public DayOfWeek date { get; set; }
        public string shiftType { get; set; }
        public string Name { get; set; }
    }
}
