using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods
{
    public static class MyStringExtentions
    {
        public static bool IsNationalCode(this string input)
        {
            if (input.Length == 10) return true;
            return false;
        }
    }
}
