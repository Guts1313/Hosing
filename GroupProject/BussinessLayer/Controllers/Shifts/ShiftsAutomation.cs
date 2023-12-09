using DataAccessLayer.DAL;
using DataItems.LogicItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Controllers.Shifts
{
    public class ShiftsAutomation
    {
        private const int TOTAL_WORKING_DAYS = 5;
        private const int TOTAL_SHIFTS_DAY = 3;
        private ShiftController shifts;
        private EmployeeController employees;

        public ShiftsAutomation() 
        {
            shifts = new ShiftController(new DALShiftController());
            employees = new EmployeeController(new DALEmployeeController());
        }

        private List<Employee> specificTimeShift(ShiftType shiftType, List<Employee> AllEmployees)
        {
            List<Employee> emplyeesSpecific = new List<Employee>();

            foreach (Employee employee in AllEmployees)
            {
                if (Extensions.GetShifts(employee.Shifts).Contains(shiftType))
                {
                    emplyeesSpecific.Add(employee);
                }
            }

            return emplyeesSpecific;
        }

        private ShiftType getShiftTypeFromNumber(int dayPart)
        {
            switch (dayPart)
            {
                case 0:
                    return ShiftType.Morning; break;
                case 1:
                    return ShiftType.Afternoon; break;
                case 2:
                    return ShiftType.Evening; break;
                default: return ShiftType.Evening;
            }
        }

        private List<Employee> DeleteEmployeeFromListById(int id, List<Employee> AllEmployees)
        {
            List<Employee> AllEmployeesCopy = AllEmployees.ToList();

            for (int i = 0; i < AllEmployeesCopy.Count; i++)
            {
                if (AllEmployeesCopy[i].Id == id)
                {
                    AllEmployeesCopy.RemoveAt(i);
                    break;
                }
            }

            return AllEmployeesCopy;
        }

        private int countEmployeesNeededForAShift(int totalEmplyees)
        {
            int totalShifts = TOTAL_WORKING_DAYS * TOTAL_SHIFTS_DAY;
            int indexEmplyeesPerShift = (int)(totalEmplyees / totalShifts);
            return indexEmplyeesPerShift + 1;
        }

        private DaySeparation seperateShiftsPerDay(List<Employee> AllEmployees)
        {
            Random random = new Random();
            DaySeparation daySeparation = new DaySeparation();
            var availableEmployees = AllEmployees;
            int indexEmplyeesPerShift = countEmployeesNeededForAShift(AllEmployees.Count);

            List<Employee> shiftStuff = new List<Employee>();
            List<Employee> currentTimeEmplyees;
            int randomIndexEmployee;
            for (int i = 0; i < TOTAL_SHIFTS_DAY; i++)
            {
                currentTimeEmplyees = specificTimeShift(getShiftTypeFromNumber(i), availableEmployees);
                // if there are no emplyoees for a morning shift for example it will take all the other employess left
                if (currentTimeEmplyees.Count == 0) { currentTimeEmplyees = availableEmployees; }
                
                for (int j = 0; j < indexEmplyeesPerShift; j++)
                {
                    randomIndexEmployee = random.Next(currentTimeEmplyees.Count);
                    shiftStuff.Add(currentTimeEmplyees[randomIndexEmployee]);
                    availableEmployees = DeleteEmployeeFromListById(currentTimeEmplyees[randomIndexEmployee].Id, availableEmployees);
                    currentTimeEmplyees.RemoveAt(randomIndexEmployee);
                    if (currentTimeEmplyees.Count == 0) { currentTimeEmplyees = availableEmployees; }
                    if (availableEmployees.Count == 0) { availableEmployees = AllEmployees; }
                }

                switch (i) 
                {
                    case 0:
                        daySeparation.Morning = new List<Employee>(shiftStuff); break;
                    case 1:
                        daySeparation.Afternoon = new List<Employee>(shiftStuff); break;
                    case 2:
                        daySeparation.Evening = new List<Employee>(shiftStuff); break;
                }

                shiftStuff.Clear();
            }

            return daySeparation;
        }

        private List<Employee> deleteTheSameInstancesFromLists(List<Employee> deleteFrom, List<Employee> extraElements)
        {
            List<Employee> noRepetitions = new List<Employee>();

            bool IsToBeDeleted = false;
            for (int i = 0; i < deleteFrom.Count; i++)
            {
                IsToBeDeleted = false;
                for (int j = 0; j < extraElements.Count; j++)
                {
                    if (extraElements[j].Id == deleteFrom[i].Id)
                    {
                        IsToBeDeleted = true;
                        break;
                    }
                }

                if (!IsToBeDeleted)
                {
                    noRepetitions.Add(deleteFrom[i]);
                }
            }

            return noRepetitions;
        }

        private List<Employee> createListFromShifts(DaySeparation daySeparation)
        {
            List <Employee> dayShifts = new List<Employee>();

            dayShifts.AddRange(daySeparation.Morning);
            dayShifts.AddRange(daySeparation.Afternoon);
            dayShifts.AddRange(daySeparation.Evening);

            return dayShifts;
        }

        private List<Employee> getDayAvailableEmployees(List<Employee> AllEmployees, DaySeparation day)
        {
            List<Employee> AvailableEmployees = new List<Employee>(AllEmployees);
            int indexEmplyeesPerShift = countEmployeesNeededForAShift(AllEmployees.Count);
            int addExtraEmployees = 0;
            Random random = new Random();

            AvailableEmployees = deleteTheSameInstancesFromLists(AllEmployees, createListFromShifts(day));

            if (AvailableEmployees.Count <= indexEmplyeesPerShift * TOTAL_SHIFTS_DAY)
            { addExtraEmployees = indexEmplyeesPerShift * TOTAL_SHIFTS_DAY - AvailableEmployees.Count; }

            List<Employee> shouldntBeNormallyWorking = deleteTheSameInstancesFromLists(AllEmployees, AvailableEmployees);
            int randomIndexEmployee;

            // enough workers in the system will add random ones that shouldn't actually work this day
            if (addExtraEmployees <= shouldntBeNormallyWorking.Count)
            {
                for (int i = 0; i < addExtraEmployees; i++)
                {
                    randomIndexEmployee = random.Next(shouldntBeNormallyWorking.Count);
                    AvailableEmployees.Add(shouldntBeNormallyWorking[randomIndexEmployee]);
                    shouldntBeNormallyWorking.RemoveAt(randomIndexEmployee);
                }
            }
            else // not enough just return all of them
            {
                return AllEmployees;
            }
            return AvailableEmployees;
        }

        private void test(DaySeparation day)
        {
            Console.WriteLine($"Morning: {day.Morning[0].Username}");
            Console.WriteLine($"Afternoon: {day.Afternoon[0].Username}");
            Console.WriteLine($"Evening: {day.Evening[0].Username}");
            Console.WriteLine("\n");
        }

        private ShiftsDays sevenWeekSeparation()
        {
            List<Employee> AllEmployees = employees.GetAll().ToList();
            List<Employee> AvailableEmployees = new List<Employee>(AllEmployees);
            ShiftsDays shiftsDays = new ShiftsDays();

            for (int i = 0; i < TOTAL_WORKING_DAYS; i++)
            {
                switch (i)
                {
                    case 0:
                        shiftsDays.Monday = seperateShiftsPerDay(AvailableEmployees);
                        Console.WriteLine("Monday:");
                        test(shiftsDays.Monday);
                        break;
                    case 1:
                        AvailableEmployees = getDayAvailableEmployees(AllEmployees, shiftsDays.Monday);
                        shiftsDays.Tuesday = seperateShiftsPerDay(AvailableEmployees);
                        Console.WriteLine("Tuesday:");
                        test(shiftsDays.Tuesday);
                        break;
                    case 2:
                        AvailableEmployees = getDayAvailableEmployees(AllEmployees, shiftsDays.Tuesday);
                        shiftsDays.Wendsday = seperateShiftsPerDay(AvailableEmployees);
                        Console.WriteLine("Wendsday:");
                        test(shiftsDays.Wendsday);
                        break;
                    case 3:
                        AvailableEmployees = getDayAvailableEmployees(AllEmployees, shiftsDays.Wendsday);
                        shiftsDays.Thursday = seperateShiftsPerDay(AvailableEmployees);
                        Console.WriteLine("Thursday:");
                        test(shiftsDays.Thursday);
                        break;
                    case 4:
                        AvailableEmployees = getDayAvailableEmployees(AllEmployees, shiftsDays.Thursday);
                        shiftsDays.Friday = seperateShiftsPerDay(AvailableEmployees);
                        Console.WriteLine("Friday:");
                        test(shiftsDays.Friday);
                        break;
                }
            }

            return shiftsDays;
        }

        private void addShifts(DaySeparation daySeparation, DateTime date)
        {
            foreach (var emp in daySeparation.Morning)
            {
                shifts.AddShift(new Shift(emp, date, 1));
            }
            foreach (var emp in daySeparation.Afternoon)
            {
                shifts.AddShift(new Shift(emp, date, 2));
            }
            foreach (var emp in daySeparation.Evening)
            {
                shifts.AddShift(new Shift(emp, date, 4));
            }
        }

        public void AssignShiftsAutomaticallyByDate(DateTime start, DateTime end)
        {
            DateTime currentPos = start;
            ShiftsDays weekShifts = sevenWeekSeparation();

            if (start > end)
            {
                throw new Exception("start date can`t be in the future compaired to end date");
            }

            DayOfWeek dayName;
            while (currentPos <= end) 
            {
                dayName = currentPos.DayOfWeek;

                switch (dayName)
                {
                    case DayOfWeek.Monday:
                        addShifts(weekShifts.Monday, currentPos);
                        break;
                    case DayOfWeek.Tuesday:
                        addShifts(weekShifts.Tuesday, currentPos);
                        break;
                    case DayOfWeek.Wednesday:
                        addShifts(weekShifts.Wendsday, currentPos);
                        break;
                    case DayOfWeek.Thursday:
                        addShifts(weekShifts.Thursday, currentPos);
                        break;
                    case DayOfWeek.Friday:
                        addShifts(weekShifts.Friday, currentPos);
                        break;
                }

                currentPos = currentPos.AddDays(1);
            }
        }
    }
}
