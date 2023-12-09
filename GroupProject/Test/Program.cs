using BussinessLayer.Controllers.Shifts;

ShiftsAutomation shiftsAutomation = new ShiftsAutomation();

shiftsAutomation.AssignShiftsAutomaticallyByDate(DateTime.Now, DateTime.Now.AddDays(7));
