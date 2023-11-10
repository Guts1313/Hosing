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
		public IActionResult OnPost()
		{
			int idTest = Convert.ToInt16(HttpContext.GetRouteData().Values["id"]);
			CancelledShift cancelledShift = new CancelledShift();
			cancelledShift.AssignedEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));
			cancelledShift.Shift = _shiftController.GetById(idTest);
			cancelledShift.Reason = _reason;
			//_shiftController.GetById(idTest).IsCancelled = true;

			CancelledShiftController cancelledShiftController = new(new DALCancelledShiftController());
			cancelledShiftController.Add(cancelledShift, new DALShiftController());
			//_shiftController.DeleteShift(_selectedShift);
			return RedirectToPage("Index");
		}
    }
}
