using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Domain.Helpers
{
    public static class TypeExtensions
    {
        public static int ToInt(this object argNumber)
        {
            if (IsInt(argNumber))
            {
                Int32.TryParse(argNumber.ToString(), out var number);
                return number;
            }
            return 0;
        }
        public static bool IsInt(this object argNumber)
        {
            argNumber = argNumber?.ToString() ?? "";
            return Int32.TryParse(argNumber.ToString(), out _);
        }
        public static bool HasNoValue(this string s)
        {
            return string.IsNullOrEmpty(s) == true;
        }
    }
}
