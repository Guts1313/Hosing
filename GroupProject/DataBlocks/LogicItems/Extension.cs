using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataItems.LogicItems
{
    public static class Extensions
    {
        public static bool HasShift(this int value, ShiftType target)
        {
            return (value & (int)target) == (int)target;
        }

        public static void AddShift(this ref int value, ShiftType target)
        {
            value |= (int)target;
        }

        public static IEnumerable<ShiftType> GetShifts(int value)
        {
            foreach (ShiftType shiftType in Enum.GetValues(typeof(ShiftType)))
            {
                if ((value & (int)shiftType) != 0)
                {
                    yield return shiftType;
                }
            }
        }
    }
}
