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
		CancelledShiftController _cancelledShiftController;
		VacationController _vacationController;
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
		public CancelledShiftsModel()
		{
			_cancelledShiftController = new(new DALCancelledShiftController());
			_employeeController = new(new DALEmployeeController());
			_vacationController = new(new DALVacationController());
		}
		public void OnGet()
		{

			_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

			_cancelledShifts = _cancelledShiftController.GetAllAssigned(_loggedInEmployee);

			_vacations = _vacationController.ReadAllByMember(_loggedInEmployee.Id);

			shifts = _cancelledShifts.OrderByDescending(CancelledShift => CancelledShift.Shift.Date).ToList();

			vacations = _vacations.OrderByDescending(Vacation => Vacation.StartDate).ToList();
		}

		public IActionResult OnPost()
		{
			_loggedInEmployee = _employeeController.Get(HttpContext.Session.GetString("username"));

			_cancelledShifts = _cancelledShiftController.GetAllAssigned(_loggedInEmployee);

			_vacations = _vacationController.ReadAllByMember(_loggedInEmployee.Id);



			if (ShiftFilters[0] == "Ascending")
			{
				_cancelledShifts = _cancelledShifts.OrderBy(CancelledShift => CancelledShift.Shift.Date).ToArray();

				if (ShiftFilters[1] == "Sent")
				{
					foreach (var shift in _cancelledShifts)
					{
						if (shift.GetStatus() == "Sent")
						{
							shifts.Add(shift);
						}
					}
				}
				else if (ShiftFilters[1] == "Viewed")
				{
					foreach (var shift in _cancelledShifts)
					{
						if (shift.GetStatus() == "Viewed")
						{
							shifts.Add(shift);
						}
					}
				}
				else
				{
					shifts = _cancelledShifts.ToList();
				}
			}
			else if (ShiftFilters[0] == "Descending")
			{
				_cancelledShifts = _cancelledShifts.OrderByDescending(CancelledShift => CancelledShift.Shift.Date).ToArray();

				if (ShiftFilters[1] == "Sent")
				{
					foreach (var shift in _cancelledShifts)
					{
						if (shift.GetStatus() == "Sent")
						{
							shifts.Add(shift);
						}
					}
				}
				else if (ShiftFilters[1] == "Viewed")
				{
					foreach (var shift in _cancelledShifts)
					{
						if (shift.GetStatus() == "Viewed")
						{
							shifts.Add(shift);
						}
					}
				}
				else
				{
					shifts = _cancelledShifts.ToList();
				}
			}

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


		public IActionResult OnPostFilter(string filter)
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
			return OnPost();
		}
	}
}
