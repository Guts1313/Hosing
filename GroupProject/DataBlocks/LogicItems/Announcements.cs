using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataItems.LogicItems
{
    public class Announcements
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string Title { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int VacationId { get; set; }

        public Announcements() { }

        public Announcements(string title, string details, DateOnly startDate, DateOnly endDate)
        {
            Title = title;
            Details = details;
            StartDate = startDate;
            EndDate = endDate;
            VacationId = 0;
        }
        public override string ToString()
        {
            return $"{Title} ";
        }
    }
}
