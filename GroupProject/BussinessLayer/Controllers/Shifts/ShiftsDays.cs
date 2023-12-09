using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Controllers.Shifts
{
    public class ShiftsDays
    {
        public DaySeparation Monday { set; get; }
        public DaySeparation Tuesday { set; get; }
        public DaySeparation Wendsday { set; get; }
        public DaySeparation Thursday { set; get; }
        public DaySeparation Friday { set; get; }
    }

    public class DaySeparation
    {
        public List<Employee> Morning { set; get; }
        public List<Employee> Afternoon { set; get; }
        public List<Employee> Evening { set; get; }
    }
}
