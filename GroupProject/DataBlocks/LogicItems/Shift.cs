
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataItems.LogicItems
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

        private string GetShiftTypeDisplayName(ShiftType shiftType)
        {
            switch (shiftType)
            {
                case ShiftType.Morning:
                    return "Late Morning";
                case ShiftType.EarlyMorning:
                    return "Early Morning";
                case ShiftType.Afternoon:
                    return "Late Afternoon";
                case ShiftType.EarlyAfternoon:
                    return "Early Afternoon";
                case ShiftType.Evening:
                    return "Late Evening";
                case ShiftType.EarlyEvening:
                    return "Early Evening";
                default:
                    return shiftType.ToString();
            }
        }

        public string GetType()
        {
            return GetShiftTypeDisplayName((ShiftType)Type);
        }

        public override string ToString()
        {
            return $"{Employee.Name} | {DateOnly.FromDateTime(Date)} | {GetType()} SHIFT";
        }
    }
}
