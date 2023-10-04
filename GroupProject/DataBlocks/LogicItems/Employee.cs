using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataItems.LogicItems
{
    public class Employee
    {
        public int Id { get; private set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Name { get; set; }
        public string? Email { get; private set; }
        public string? Phone { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime HireDate { get; private set; }
        public int Shifts { get; private set; }
        public string ProfilePicture { get; private set; }
        public Department Department { get; set; }

        public Employee() { }

        public Employee(int id, string username, string password, Department department)
        {
            Id = id;
            Username = username;
            Password = password;
            Department = department;
        }

        public Employee(string username, string password, Department department, string name, string email, string phone, decimal salary, int shifts)
        {
            Username = username;
            Password = password;
            Department = department;
            Name = name;
            Email = email;
            Phone = phone;
            Salary = salary;
            HireDate = DateTime.Now;
            ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/2/2c/Default_pfp.svg";
            Shifts = shifts;
        }

        public Employee(int id, string username, string password, Department department, string name, string email, string phone, decimal salary, DateTime hireDate, string profilePicture, int shifts)
        {
            Id = id;
            Username = username;
            Password = password;
            Department = department;
            Name = name;
            Email = email;
            Phone = phone;
            Salary = salary;
            HireDate = hireDate;
            ProfilePicture = profilePicture;
            Shifts = shifts;
        }

        public void ChangeDetails(string name, string username, string phone, decimal salary)
        {
            Name = name;
            Username = username;
            Phone = phone;
            Salary = salary;
        }

        public override string ToString()
        {
            if (Email != string.Empty)
                return $"{Id}: {Name} ({Username}) - {Email}";
            return $"{Id}: {Name} ({Username})";
        }
    }
}
