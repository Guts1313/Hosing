using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
	public interface IEmployeeController
	{
		public bool Create(Employee employee, byte[] key, byte[] iv);

		public bool Update(Employee employee, byte[] key, byte[] iv);

		public bool Delete(Employee employee);

        public Employee GetByUsername(string username);

        public DateTime? GetClosestShiftDate(int employeeId);

        public bool ChangePassword(string email, string newPassword);

		public bool FindEmail(string emailToSearch);

		public Employee[] GetAll();

		public Employee GetById(int id);

		public Employee[] GetAvailableEmployees(DateTime date, int shiftType);
        public byte[] GetKeyByIndex(int index);
        public byte[] GetIvByIndex(int index);
		public byte[] GetKeyByName(string name);
        public byte[] GetIvByName(string name);
    }
}
