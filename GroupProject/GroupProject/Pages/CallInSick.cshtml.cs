using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class CallInSickModel : PageModel
    {
        public Shift _selectedShift;
		[BindProperty]
		public string _reason { get; set; }
        private ShiftController _shiftController;
		private EmployeeController _employeeController;

		public CallInSickModel()
		{
            _shiftController = new(new DALShiftController());
			_employeeController = new(new DALEmployeeController());
		}
        public void OnGet(int id)
        {
			_selectedShift = _shiftController.GetById(id);
		}
        public IActionResult OnPost(int shiftId)
        {
            CancelledShift cancelledShift = new CancelledShift
            {
                AssignedEmployee = _employeeController.Get(HttpContext.Session.GetString("username")),
                Shift = _shiftController.GetById(shiftId),
                Reason = _reason
            };

            CancelledShiftController cancelledShiftController = new(new DALCancelledShiftController());
            cancelledShiftController.Add(cancelledShift, new DALShiftController());

            return RedirectToPage("Index");
        }
    }
}
