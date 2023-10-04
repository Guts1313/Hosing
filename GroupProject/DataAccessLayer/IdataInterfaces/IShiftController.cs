using BussinessLayer.Classes;

namespace ClassLibrary.Interfaces
{
    public interface IShiftController
	{
		public bool Create(Shift shift);

		public bool Update(Shift shift);

		public bool Delete(Shift shift);

		public Shift[] GetAll();

		public Shift[] GetAllAssigned(Employee employee);

		public Shift[] GetAllByDate(DateTime date);

		public Shift GetById(int id);

		public Shift[] GetFutureShiftsByEmp(Employee employee);

		public Shift[] GetShiftsFromVacation(Vacation vacation);

    }
}
