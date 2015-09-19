using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackAround
{
    public class Class1
    {
        public string BackAround(string str)
        {
            if (str.Length < 2)
            {
                return str + str + str;
            }

            string back = str.Substring(str.Length - 1);

            return back + str + back;
        }
    }
}
