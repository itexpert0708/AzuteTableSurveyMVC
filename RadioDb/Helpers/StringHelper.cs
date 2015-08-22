using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDb.Helpers
{
    public static class StringHelper
    {
        public static long ToLongValue(this string value)
        {
            return Convert.ToInt64(value);
        }
    }
}
