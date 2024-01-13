using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using BussinessLayer.Utilities.Messages;
using DataAccessLayer.DAL;
using DataAccessLayer.Interfaces;
using DataItems.LogicItems;
using System.Numerics;
using System.Xml.Linq;

ShiftsAutomation shiftsAutomation = new ShiftsAutomation();

shiftsAutomation.AssignShiftsAutomaticallyByDate(DateTime.Now, DateTime.Now.AddDays(7));

//shiftsAutomation.sevenWeekSeparation();

//EmployeeController employeeController = new EmployeeController(new DALEmployeeController());

/*foreach (var employee in employeeController.GetAll())
{
    string subject = string.Format(EmailMessages.AUTO_ASSIGNED_SHIFT_SUBJECT, employee.Name);
    string body = string.Format(EmailMessages.AUTO_ASSIGNED_SHIFT_BODY, employee.Name);

    if (employee.Email != null)
    {
        EmailSendController emailSendController = new EmailSendController(employee.Email, subject, body);
        emailSendController.SendEmail();
    }
}*/