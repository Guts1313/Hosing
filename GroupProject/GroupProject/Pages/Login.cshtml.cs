using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using BussinessLayer.Controllers;

namespace GroupProject.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Employee employee { get; set; }
        private EmployeeController _employeeController;

        public LoginModel()
        {
			_employeeController = new(new DALEmployeeController());
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (_employeeController.Login(employee.Username, employee.Password) != null)
            {
                HttpContext.Session.SetString("username", employee.Username);

                return RedirectToPage("Index");
            }
            else
            {
                string message = "Invalid login, please try again";
                ViewData["Message"] = message;
            }
            return null;
        }
    }
}
