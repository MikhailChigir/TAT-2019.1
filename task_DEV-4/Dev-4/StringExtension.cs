using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    public static class StringExtension 
    {
        public static string NewGUID(this string str, Discipline discipline)
        {
            str = Guid.NewGuid().ToString();
            discipline.Guid = str;
        }
    }
}
