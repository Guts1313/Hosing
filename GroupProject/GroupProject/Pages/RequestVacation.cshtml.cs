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
    public class RequestVacationModel : PageModel
    {
        public Vacation Vacation { get; set; }

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        [BindProperty]
        public string Reason { get; set; }

        private VacationController vacationController = new(new DALVacationController());
        private EmployeeController employeeController = new(new DALEmployeeController());
        private Employee loggedInEmployee = null;

        public void OnGet()
        {
            string username = HttpContext.Session.GetString("username");

            loggedInEmployee = employeeController.Get(username);

            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
        }

        public IActionResult OnPost()
        {
            string username = HttpContext.Session.GetString("username");

            loggedInEmployee = employeeController.Get(username);

            if (StartDate < DateTime.Today || EndDate < DateTime.Today)
            {
                return Page();
            }
            else
            {
                DateOnly startDate = DateOnly.FromDateTime(StartDate);
                DateOnly endDate = DateOnly.FromDateTime(EndDate);

                Vacation vacation = new Vacation(loggedInEmployee, startDate, endDate, Reason);

                if (vacationController.Create(vacation))
                    return RedirectToPage("Index");
                else
                    return Page();
            }
        }
    }
}
