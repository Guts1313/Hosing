using BussinessLayer.Controllers.Shifts;
using DesktopAppMediaBazaar.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar.FormsUtility
{
    public partial class ShiftAutoAdd : Form
    {
        private ListBox lbEmployees;
        private ShiftsAutomation shiftsAutomation;
        private readonly ShiftController shiftController;

        public ShiftAutoAdd(ShiftController shiftController, ListBox lbEmployees)
        {
            InitializeComponent();

            shiftsAutomation = new ShiftsAutomation();

            this.lbEmployees = lbEmployees;
            this.shiftController = shiftController;
        }

        private void showEmployeesMainForm()
        {
            lbEmployees.Items.Clear();
            foreach (var shift in shiftController.GetAll())
            {
                lbEmployees.Items.Add(shift);
            }
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
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
                this.Close();
            }

            showEmployeesMainForm();
            this.Close();
        }
    }
}
