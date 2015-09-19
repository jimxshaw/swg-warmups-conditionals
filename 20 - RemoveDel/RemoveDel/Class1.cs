using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDel
{
    public class Class1
    {
        public string RemoveDel(string str)
        {
            if (str.Contains("del"))
            {
                if (str.IndexOf("del") >= 1)
                {
                    str = str.Replace("del", "");
                    return str;
                }
                return str;
            }
            return str;
        }
    }
}
