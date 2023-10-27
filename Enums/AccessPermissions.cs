using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    [Flags]
    public enum AccessPermissions
    {
        Read = 1<<0, Write = 1<<1, Delete = 1 << 2,
    }
}
