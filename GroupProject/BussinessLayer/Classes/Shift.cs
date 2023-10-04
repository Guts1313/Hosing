
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Classes
{

    public class Shift
    {
        public int Id { get; private set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; private set; }
        public int Type { get; private set; }
        public bool IsCancelled { get; set; }

        public Shift() { }

        public Shift(Employee employee, DateTime date, int shift)
        {
            Employee = employee;
            Date = date;
            Type = shift;
        }

        public Shift(int id, DateTime date, int shift)
        {
            Id = id;
            Date = date;
            Type = shift;
        }

        public Shift(int id, Employee employee, DateTime date, int shift, bool isCancelled)
        {
            Id = id;
            Date = date;
            Type = shift;
            Employee = employee;
            IsCancelled = isCancelled;
        }

        public string GetType()
        {
            return Enum.GetName((ShiftType)Type);
        }

        public override string ToString()
        {
            return $"{Id}: {Employee.Name} on {DateOnly.FromDateTime(Date)} in the {GetType()}";
        }
    }
}
