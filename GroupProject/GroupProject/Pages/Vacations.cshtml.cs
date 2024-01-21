using BussinessLayer.Controllers;
using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using ClassLibrary.Interfaces;
using DataAccessLayer;
using DataAccessLayer.DAL;
using DataItems.LogicItems;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;
using System.Security.Cryptography.Xml;

namespace MediaBazaarWebsite.Pages
{
	public class CancelledShiftsModel : PageModel
	{
		VacationController _vacationController;
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
		public CancelledShiftsModel()
		{
			_employeeController = new(new DALEmployeeController());
			_vacationController = new(new DALVacationController());
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

            _loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

			_vacations = _vacationController.ReadAllByMember(_loggedInEmployee.Id);

			vacations = _vacations.OrderByDescending(Vacation => Vacation.StartDate).ToList();
            return Page();
        }

		public void OnPostFilter(string filter)
		{
			switch (filter)
			{
				case "Ascending":
					{
						ShiftFilters[0] = filter;
						break;
					}
				case "Descending":
					{
						ShiftFilters[0] = filter;
						break;
					}
				case "Sent":
					{
						ShiftFilters[1] = filter;
						break;
					}
				case "Viewed":
					{
						ShiftFilters[1] = filter;
						break;
					}
				case "AllShifts":
					{
						ShiftFilters[1] = filter;
						break;
					}
				case "ClearShifts":
					{
						ShiftFilters[0] = "Descending";
						ShiftFilters[1] = "AllShifts";
						break;
					}
				case "StartAscending":
					{
						VacationFilters[0] = filter;
						break;
					}
				case "StartDescending":
					{
						VacationFilters[0] = filter;
						break;
					}
				case "EndAscending":
					{
						VacationFilters[0] = filter;
						break;
					}
				case "EndDescending":
					{
						VacationFilters[0] = filter;
						break;
					}
				case "Approved":
					{
						VacationFilters[1] = filter;
						break;
					}
				case "Pending":
					{
						VacationFilters[1] = filter;
						break;
					}
				case "Rejected":
					{
						VacationFilters[1] = filter;
						break;
					}
				case "AllVacations":
					{
						VacationFilters[1] = filter;
						break;
					}
				case "ClearVacations":
					{
						VacationFilters[0] = "StartDescending";
						VacationFilters[1] = "AllVacations";
						break;
					}
			}
			OnPost();
		}

		public IActionResult OnPost()
		{
			_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

			_vacations = _vacationController.ReadAllByMember(_loggedInEmployee.Id);

			if (VacationFilters[0] == "StartAscending")
			{
				_vacations = _vacations.OrderBy(Vacation => Vacation.StartDate).ToArray();

				if (VacationFilters[1] == "Approved")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Pending")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Pending == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Rejected")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == false && vacation.Pending == false)
						{
							vacations.Add(vacation);
						}
					}
				}
				else
				{
					vacations = _vacations.ToList();
				}


			}
			else if (VacationFilters[0] == "StartDescending")
			{
				_vacations = _vacations.OrderByDescending(Vacation => Vacation.StartDate).ToArray();

				if (VacationFilters[1] == "Approved")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Pending")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Pending == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Rejected")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == false && vacation.Pending == false)
						{
							vacations.Add(vacation);
						}
					}
				}
				else
				{
					vacations = _vacations.ToList();
				}
			}
			else if (VacationFilters[0] == "EndAscending")
			{
				_vacations = _vacations.OrderBy(Vacation => Vacation.EndDate).ToArray();

				if (VacationFilters[1] == "Approved")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Pending")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Pending == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Rejected")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == false && vacation.Pending == false)
						{
							vacations.Add(vacation);
						}
					}
				}
				else
				{
					vacations = _vacations.ToList();
				}
			}
			else if (VacationFilters[0] == "EndDescending")
			{
				_vacations = _vacations.OrderByDescending(Vacation => Vacation.EndDate).ToArray();

				if (VacationFilters[1] == "Approved")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Pending")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Pending == true)
						{
							vacations.Add(vacation);
						}
					}
				}
				else if (VacationFilters[1] == "Rejected")
				{
					foreach (var vacation in _vacations)
					{
						if (vacation.Approved == false && vacation.Pending == false)
						{
							vacations.Add(vacation);
						}
					}
				}
				else
				{
					vacations = _vacations.ToList();
				}
			}
			return Page();
		}
	}
}
