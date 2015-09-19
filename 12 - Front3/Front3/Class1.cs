using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front3
{
    public class Class1
    {
        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str.Substring(0) + str.Substring(0) + str.Substring(0);
            }

            return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
        }
    }
}
