using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Utilities.Messages
{
    public class EmailMessages
    {
        //Subject
        public const string ANNOUNCEMENT_SUBJECT = "{0}, you have a new announcement from {1}";
        public const string AUTO_ASSIGNED_SHIFT_SUBJECT = "{0}, your schedule for the week is ready";
        public const string VERIFICATION_CODE_SUBJECT = "Your Code is {0}";
         
        //Body
        public const string ANNOUNCEMENT_BODY = "\"{0}\"";
        public const string AUTO_ASSIGNED_SHIFT_BODY = "Explore your upcoming agenda effortlessly by checking your schedule " +
            "through the intuitive Shift Tab feature. Stay organized and informed as you seamlessly navigate through your " +
            "planned activities and upcoming shifts.";
        public const string VERIFICATION_CODE_BODY = "Your code is {0}, copy it and use it in your \"enter code\" tab";
    }
}
