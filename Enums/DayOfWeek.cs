using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    [Flags]
    public enum DayOfWeek
    {
        Sunday =0b_00000001, Monday=0b_00000010, Tuesday=0b_00000100, Wednesday=0b_00001000, Thursday=0b_00010000,Friday=0b_00100000,Saturday=0b_01000000
    }
}
