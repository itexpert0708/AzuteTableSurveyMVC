using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDb.Helpers
{
    public static class LongHelper
    {
        public static string ToLongNumberString(this long value)
        {
            return value.ToString("0000000000000000000");
        }
    }
}
