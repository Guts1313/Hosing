using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;

namespace BussinessLayer.Controllers
{
    public class ShiftController
    {
        private IShiftController _shiftDal;

        public ShiftController(IShiftController shiftController)
        {
            _shiftDal = shiftController;
        }

        public bool AddShift(Shift shift)
        {
            return _shiftDal.Create(shift);
        }

        public bool DeleteShift(Shift shift)
        {
            return _shiftDal.Delete(shift);
        }

        public Shift[] GetAll()
        {
            return _shiftDal.GetAll();
        }

        public Shift[] GetAllAssigned(Employee employee)
        {
            return _shiftDal.GetAllAssigned(employee);
        }

        public Shift GetById(int id)
        {
            return _shiftDal.GetById(id);
        }
		public Shift[] GetAllByDate(DateTime date)
		{
			return _shiftDal.GetAllByDate(date);
		}
		public Shift[] GetAllByDateAndDepartment(DateTime date, Department department)
        {
            List<Shift> shifts = new();
            foreach(Shift s in GetAllByDate(date))
            {
                if(s.Employee.Department.Id == department.Id)
                {
                    shifts.Add(s);
                }
            }
            return shifts.ToArray();
        }
        public bool Update(Shift shift)
        {
            return _shiftDal.Update(shift);
        }
        public List<int> GetShiftIdsToCancelByEmp(Employee employee, Shift[] shifts)
        {
            List<int> shiftIdsToCancel = new();
            foreach (var shift in shifts)
            {
                if (shift.Date >= DateTime.Today && shift.Date <= DateTime.Today.AddDays(2))
                {
                    shiftIdsToCancel.Add(shift.Id);
                }
            }
            return shiftIdsToCancel;
        }
        public Shift[] GetFutureShiftsByEmp(Employee employee)
        {
            return _shiftDal.GetFutureShiftsByEmp(employee);
        }
        public Shift[] GetShiftsFromVacation(Vacation vacation)
        {
            return _shiftDal.GetShiftsFromVacation(vacation);
        }

    }
}
