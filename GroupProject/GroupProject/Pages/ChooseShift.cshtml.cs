using BussinessLayer.Controllers;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class ChooseShiftModel : PageModel
    {
        CancelledShiftController _cancelledShiftController;
        ShiftController _shiftController;
        [BindProperty]
        public CancelledShift[] _cancelledShifts { get; set; }

        [BindProperty]
        public Vacation[] _vacations { get; set; }

        [BindProperty]
        public List<CancelledShift> shifts { get; set; }

        [BindProperty]
        public List<Vacation> vacations { get; set; }

        public static string[] ShiftFilters = new string[2] { "Descending", "AllShifts" };
        public static string[] VacationFilters = new string[2] { "StartDescending", "AllVacations" };
        Employee _loggedInEmployee;
        EmployeeController _employeeController;

        [BindProperty]
        public int Id { get; set; } = 0;

        public ChooseShiftModel()
        {
            _employeeController = new(new DALEmployeeController());
            _cancelledShiftController = new(new DALCancelledShiftController());
            _shiftController = new(new DALShiftController());
        }
        public IActionResult OnGet(int id)
        {
            _loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

            Id = id;

            _cancelledShifts = _cancelledShiftController.GetFromVacation(Id);

            return Page();
        }

        public IActionResult OnPost(int id, int shiftId)
        {
            _loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

            Id = id;

            CancelledShift cancelledShift = _cancelledShiftController.GetById(shiftId);
            cancelledShift.NewEmployee = _loggedInEmployee;
            
            Shift shift = _shiftController.GetById(cancelledShift.Shift.Id);
            shift.IsCancelled = false;
            shift.Employee = _loggedInEmployee;

            _shiftController.Update(shift);
            _cancelledShiftController.Update(cancelledShift);

            _cancelledShifts = _cancelledShiftController.GetFromVacation(Id);

            return Page();
        }
    }
}
