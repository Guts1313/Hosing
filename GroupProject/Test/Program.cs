using BussinessLayer.Controllers;
using BussinessLayer.Controllers.Shifts;
using BussinessLayer.Utilities.Messages;
using DataAccessLayer.DAL;

ShiftsAutomation shiftsAutomation = new ShiftsAutomation();

shiftsAutomation.AssignShiftsAutomaticallyByDate(DateTime.Now, DateTime.Now.AddDays(7));

EmployeeController employeeController = new EmployeeController(new DALEmployeeController());

foreach (var employee in employeeController.GetAll())
{
    string subject = string.Format(EmailMessages.AUTO_ASSIGNED_SHIFT_SUBJECT, employee.Name);
    string body = string.Format(EmailMessages.AUTO_ASSIGNED_SHIFT_BODY, employee.Name);

    if (employee.Email != null)
    {
        EmailSendController emailSendController = new EmailSendController(employee.Email, subject, body);
        emailSendController.SendEmail();
    }
}