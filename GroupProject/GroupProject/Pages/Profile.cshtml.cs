using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using DataItems.LogicItems;
using BussinessLayer.Controllers;
using DataAccessLayer.DAL;

namespace MediaBazaarWebsite.Pages
{
    public class Profile : PageModel
    {
		public Employee _loggedInEmployee;
		private EmployeeController _employeeController;
        public Profile()
        {
			_employeeController = new(new DALEmployeeController());
		}
        public void OnGet()
        {
			if (HttpContext.Session.GetString("username") != null)
			{
				_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));
            }
		}
    }
}
