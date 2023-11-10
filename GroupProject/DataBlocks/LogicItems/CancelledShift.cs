using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
	public class CancelledShift
	{
        public int Id { get; set; }
        public Shift Shift { get; set; }
        public Employee AssignedEmployee { get; set; }
        public string Reason { get; set; }
        public Employee? NewEmployee { get; set; }
        public bool IsViewed { get; set; }

        public CancelledShift() { }

        public CancelledShift(int id, Shift shift, Employee assignedEmployee, Employee? newEmployee, string reason, bool isViewed)
        {
            Id = id;
            Shift = shift;
            AssignedEmployee = assignedEmployee;
            NewEmployee = newEmployee;
            Reason = reason;
            IsViewed = isViewed;
        }

        public string GetStatus()
        {
            if (IsViewed)
                return "Viewed";
            else
                return "Sent";
        }

		public override string ToString()
		{
            return $"{Id}: for {AssignedEmployee.Name}(id: {AssignedEmployee.Id}; email: {AssignedEmployee.Email}); on {Shift.Date.ToShortDateString()} in the {Shift.GetType()} {System.Environment.NewLine}Reason: {Reason}";
		}

        public string GetShortToString()
        {
            return $"{Id}: {Shift.GetType()} of {Shift.Date.ToShortDateString()} for {AssignedEmployee.Name}(id: {AssignedEmployee.Id})";
		}
	}
}
