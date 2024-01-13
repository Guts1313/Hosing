using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataItems.LogicItems
{
    public enum ShiftType
    {
        Morning = 0b0001,
        Afternoon = 0b0010,
        Evening = 0b0100,
        EarlyMorning = 0b1000,
        EarlyAfternoon = 0b10000,
        EarlyEvening = 0b100000
    }
}
