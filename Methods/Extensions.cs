using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Extensions
    {
        public static bool StartsWith(this string str, params string[] prefixes)
        {
            bool result = false;
            for (int i = 0; i < prefixes.Length; i++)
            {
                if (str.StartsWith(prefixes[i]))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        public static bool IsEmail(this string str)
        {
            return str.Contains("@");
        }


    }
}
