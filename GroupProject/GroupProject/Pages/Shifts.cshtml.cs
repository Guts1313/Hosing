using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using BussinessLayer.Controllers;

namespace GroupProject.Pages
{
    public class Shifts : PageModel
    {
        public Employee _loggedInEmployee;
        private EmployeeController _employeeController;
        private ShiftController _shiftController;
        public Shift[] _assignedShifts;
		private readonly EmployeeController employeeController = new EmployeeController(new DALEmployeeController());
		private readonly ShiftController shiftController = new ShiftController(new DALShiftController());
		public List<string> WeekDays { get; set; } = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public DateTime CurrentDate { get; set; } = DateTime.Today;
        public DateTime NewDate { get; set; }
        public List<int> shiftIdsToCancel = new();

        private static int counter = 0;
		
		public Shifts()
		{
			_employeeController = new(new DALEmployeeController());
			_shiftController = new(new DALShiftController());
            NewDate = CurrentDate;
        }

		public IActionResult OnGet()
		{
			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
			}
			_assignedShifts = _shiftController.GetAllAssigned(_loggedInEmployee);
			shiftIdsToCancel = _shiftController.GetShiftIdsToCancelByEmp(_loggedInEmployee, _assignedShifts);

			return Page();
		}

		public void OnPostPreviousWeek()
		{
            counter--;
            NewDate = CurrentDate.AddDays(counter * 7);
            CurrentDate = NewDate;

            if (HttpContext.Session.GetString("username") != null)
            {
                _loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
            }
            _assignedShifts = _shiftController.GetAllAssigned(_loggedInEmployee);
            shiftIdsToCancel = _shiftController.GetShiftIdsToCancelByEmp(_loggedInEmployee, _assignedShifts);


        }

        public void OnPostCurrentWeek()
        {
            counter = 0;
            NewDate = CurrentDate;

            if (HttpContext.Session.GetString("username") != null)
            {
                _loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
            }
            _assignedShifts = _shiftController.GetAllAssigned(_loggedInEmployee);
            shiftIdsToCancel = _shiftController.GetShiftIdsToCancelByEmp(_loggedInEmployee, _assignedShifts);

        }

        public void OnPostNextWeek() 
		{
            counter++;
            NewDate = CurrentDate.AddDays(counter * 7);
            CurrentDate = NewDate;

            if (HttpContext.Session.GetString("username") != null)
            {
                _loggedInEmployee = employeeController.Get(HttpContext.Session.GetString("username"));
            }
            _assignedShifts = _shiftController.GetAllAssigned(_loggedInEmployee);
            shiftIdsToCancel = _shiftController.GetShiftIdsToCancelByEmp(_loggedInEmployee, _assignedShifts);

        }
    }
}
