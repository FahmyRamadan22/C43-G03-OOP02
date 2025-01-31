using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Assignment02
{
    
        [Flags]
        internal enum SecurityPrevileges
        {
            Guest = 1,
            Developer = 2,
            Secretary = 4,
            DBA = 8
        }
    
}
