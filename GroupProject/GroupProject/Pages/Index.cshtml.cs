using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using BussinessLayer.Controllers;

namespace GroupProject.Pages
{
    public class HomeModel : PageModel
    {
        public Employee _loggedInEmployee;
        private EmployeeController _employeeController;
        private ShiftController _shiftController;
        private AnnouncemetsController _announcemetsController;
		[BindProperty]
		public Shift[] _assignedShifts { get; set; }
        [BindProperty]
        public Announcements[] _announcements { get; set; }

        public List<int> shiftIdsToCancel = new();

        public HomeModel()
        {
			_employeeController = new(new DALEmployeeController());
			_shiftController = new(new DALShiftController());
            _announcemetsController = new(new DALAnnouncementsController());
		}

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                _loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));
            }
            else
            {
				return RedirectToPage("Login");
            }

            _assignedShifts = _shiftController.GetFutureShiftsByEmp(_loggedInEmployee);
            _assignedShifts = _assignedShifts.OrderBy(shift => shift.Date).ToArray();

            shiftIdsToCancel = _shiftController.GetShiftIdsToCancelByEmp(_loggedInEmployee, _assignedShifts);

            _announcements = _announcemetsController.GetAllCurrent();

            return Page();

        }
    }
}
