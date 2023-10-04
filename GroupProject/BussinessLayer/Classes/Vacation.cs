using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Classes
{
    public class Vacation
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Reason { get; set; }
        public bool Approved { get; set; }
        public bool Pending { get; set; }

        public Vacation() { }

        public Vacation(int id, Employee employee, DateOnly startDate, DateOnly endDate, string reason, bool approved, bool pending)
        {
            Id = id;
            Employee = employee;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
            Approved = approved;
            Pending = pending;
        }

        public Vacation(Employee employee, DateOnly startDate, DateOnly endDate, string reason)
        {
            Employee = employee;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
            Approved = false;
            Pending = true;
        }

        public override string ToString()
        {
            return $"{Id}: {Employee.Name} ({StartDate.ToShortDateString()} - {EndDate.ToShortDateString()})";
        }
    }
}
