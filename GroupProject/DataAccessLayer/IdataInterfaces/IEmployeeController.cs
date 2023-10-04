using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
	public interface IEmployeeController
	{
		public bool Create(Employee employee);

		public bool Update(Employee employee);

		public bool Delete(Employee employee);

		public Employee[] GetAll();

		public Employee GetById(int id);

		public Employee[] GetAvailableEmployees(DateTime date, int shiftType);
	}
}
