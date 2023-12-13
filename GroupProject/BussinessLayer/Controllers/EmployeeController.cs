using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DAL;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;

namespace BussinessLayer.Controllers
{
    public class EmployeeController
    {
        private IEmployeeController _employeeDal;

        public Employee? LoggedInEmployee { get; set; }

        public EmployeeController(IEmployeeController employeeController)
        {
            _employeeDal = employeeController;
        }

        public bool AddEmployee(Employee employee, byte[] key, byte[] iv)
        {
            return _employeeDal.Create(employee, key, iv);
        }

        public bool RemoveEmployee(Employee employee)
        {
            return _employeeDal.Delete(employee);
        }

        public DateTime? GetClosestShiftDate(int employeeId)
        {
            return _employeeDal.GetClosestShiftDate(employeeId);
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return _employeeDal.GetByUsername(username);
        }

        public bool UpdateEmployee(Employee employee, byte[] key, byte[] iv)
        {
            return _employeeDal.Update(employee, key, iv);
        }

        public bool ChangePassword(string email, string newPassword) 
        {
            return _employeeDal.ChangePassword(email,newPassword);
        }

        public bool FindEmail(string email)
        {
            return _employeeDal.FindEmail(email);
        }

        public Employee[] GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int id)
        {
			foreach (Employee employee in GetAll())
			{
				if (employee.Id == id) return employee;
			}
			return null;
        }

        public Employee Get(string username)
        {
            foreach (Employee employee in GetAll())
            {
                if (employee.Username == username) return employee;
            }
            return null;
        }

        public Employee[] GetAllByDepartment(Department department)
        {
            List<Employee> employees = new();
            foreach (Employee employee in GetAll())
            {
                if(employee.Department.Id == department.Id)
                {
                    employees.Add(employee);
                }
            }
            return employees.ToArray();
        }

        public Employee Login(string username, string password)
        {
            foreach (Employee employee in GetAll())
            {
                if (employee.Username == username && employee.Password == password)
                {
                    return employee;
                }
            }
            return null;
        }

        public bool IsAdmin(Employee employee)
        {
            if (employee.Department.Name == "Administration")
                return true;
            return false;
        }

        public bool IsManager(Employee employee)
        {
            if (employee.Department.Name == "Management")
                return true;
            return false;
        }

		public Employee[] GetAvailableEmployees(DateTime date, int shiftType)
        {
            return _employeeDal.GetAvailableEmployees(date, shiftType);
        }

        public byte[] GetKey(int index)
        {
            return _employeeDal.GetKeyByIndex(index);
        }

        public byte[] GetIv(int index)
        {
            return _employeeDal.GetIvByIndex(index);
        }

        public byte[] GetKeybyName(string username)
        {
            return _employeeDal.GetKeyByName(username);
        }

        public byte[] GetIvByName(string username)
        {
            return _employeeDal.GetIvByName(username);
        }
    }
}
