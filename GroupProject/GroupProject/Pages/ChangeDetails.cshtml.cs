using BussinessLayer.Controllers;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class ChangeDetails : PageModel
    {
		public Employee _loggedInEmployee;
		private EmployeeController _employeeController;

		public string _username { get; set; }
        public string _email { get; set; }
        public string _phone { get; set; }
        public string _profilePicture { get; set; }
        public ChangeDetails()
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
