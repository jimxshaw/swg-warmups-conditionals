using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotString
{
    public class Class1
    {
        public string NotString(string str)
        {
            if (str.Length < 3)
            {
                return "not " + str;
            }
            if (str.Substring(0, 3) == "not")
            {
                return str;
            }

            return "not " + str;
        }
    }
}
