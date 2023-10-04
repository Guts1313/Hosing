using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
	public interface ICancelledShiftController
	{
		public bool Create(CancelledShift cancelledShift);

		public bool Update(CancelledShift cancelledShift);

		public bool Delete(CancelledShift cancelledShift);

		public CancelledShift[] GetAll();

		public CancelledShift[] GetAllAssigned(Employee employee);

		public CancelledShift GetById(int id);

		public CancelledShift[] GetAllInThePast();

		public CancelledShift[] GetAllByStatus(bool status);

		public CancelledShift[] GetAllIfNewEmpAssigned(bool assigned);

		public CancelledShift[] GetFromVacation(int id);

    }
}
