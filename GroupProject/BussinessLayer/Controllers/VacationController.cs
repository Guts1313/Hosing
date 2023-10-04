using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Controllers
{
	public class VacationController
	{
		private IVacationController vacationController;

		public VacationController(IVacationController vacationDal) 
		{ 
			vacationController = vacationDal;
		}

		public bool Create(Vacation vacation)
		{
			return vacationController.Create(vacation);
		}

		public bool Update(Vacation vacation)
		{
			return vacationController.Update(vacation);
		}

		public bool Delete(Vacation vacation)
		{
			return vacationController.Delete(vacation);
		}

		public Vacation[] ReadAll()
		{
			return vacationController.ReadAll();
		}

		public Vacation[] ReadAllByMember(int id)
		{
			return vacationController.ReadAllByMember(id);
		}

		public Vacation[] ReadAllByMemberFiltered(string filter, int id)
		{
			return vacationController.ReadAllByMemberFiltered(filter, id);
		}

		public Vacation ReadById(int id)
		{
			return vacationController.ReadById(id);
		}

		public string Filter(string[] filters, int id)
		{
			string filter = "SELECT * FROM Vacation WHERE EmployeeId = @employeeId";

			if (filters[2] == "Start Date Ascending")
			{
				if (filters[3] == "End Date Ascending")
				{
					if (filters[4] == "Pending")
					{
						filter = filter + " AND Pending = 1 ORDER BY StartDate";
					}
					else if (filters[4] == "Approved")
					{
						filter = filter + " AND Pending = 0 AND Approved = 1 ORDER BY StartDate";
					}
					else if (filters[4] == "Rejected")
					{
						filter = filter + "AND Pending = 0 AND Approved = 0 ORDER BY StartDate";
					}
					else if (filters[4] == "All Vacations")
					{
						filter = filter + " ORDER BY StartDate";
					}
				}
				else if (filters[3] == "End Date Descending")
				{
					if (filters[4] == "Pending")
					{
						filter = filter + " AND Pending = 1 ORDER BY EndDate DESC";
					}
					else if (filters[4] == "Approved")
					{
						filter = filter + " AND Pending = 0 AND Approved = 1 ORDER BY EndDate DESC";
					}
					else if (filters[4] == "Rejected")
					{
						filter = filter + "AND Pending = 0 AND Approved = 0 ORDER BY EndDate DESC";
					}
					else if (filters[4] == "All Vacations")
					{
						filter = filter + " ORDER BY EndDate DESC";
					}
				}
			}
			else if (filters[2] == "Start Date Descending")
			{
				if (filters[3] == "End Date Ascending")
				{
					if (filters[4] == "Pending")
					{
						filter = filter + " AND Pending = 1 ORDER BY StartDate DESC";
					}
					else if (filters[4] == "Approved")
					{
						filter = filter + " AND Pending = 0 AND Approved = 1 ORDER BY StartDate DESC";
					}
					else if (filters[4] == "Rejected")
					{
						filter = filter + "AND Pending = 0 AND Approved = 0 ORDER BY StartDate DESC";
					}
					else if (filters[4] == "All Vacations")
					{
						filter = filter + " ORDER BY StartDate DESC";
					}
				}
				else if (filters[3] == "End Date Descending")
				{
					if (filters[4] == "Pending")
					{
						filter = filter + " AND Pending = 1 ORDER BY EndDate DESC";
					}
					else if (filters[4] == "Approved")
					{
						filter = filter + " AND Pending = 0 AND Approved = 1 ORDER BY EndDate DESC";
					}
					else if (filters[4] == "Rejected")
					{
						filter = filter + "AND Pending = 0 AND Approved = 0 ORDER BY EndDate DESC";
					}
					else if (filters[4] == "All Vacations")
					{
						filter = filter + " ORDER BY EndDate DESC";
					}
				}
			}

			return filter;
		}
	}
}
