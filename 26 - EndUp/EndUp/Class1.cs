using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndUp
{
    public class Class1
    {
        public string EndUp(string str)
        {
            if (str.Length < 3)
            {
                return str.ToUpper();
            }

            string last3 = str.Substring(str.Length - 3);
            string front = str.Remove(str.Length - 3);
            string last3cap = last3.ToUpper();

            return front + last3cap;
        }
    }
}
