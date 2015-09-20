using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOz
{
    public class Class1
    {
        public string StartOz(string str)
        {
            if (str.Length < 2)
            {
                Console.WriteLine("String is insufficient length.");
                return str;
            }
            str = str.Substring(0, 2);

            if (str.Contains("oz"))
            {
                return str;
            }

            if (str.IndexOf("o") == 0)
            {
                return "o";
            }

            if (str.IndexOf("z") == 1)
            {
                return "z";
            }

            return str;
        }
    }
}
