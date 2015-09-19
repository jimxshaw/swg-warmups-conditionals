using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontBack
{
    public class Class1
    {
        public string FrontBack(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }

            string front = str.Substring(0, 1);
            string back = str.Substring(str.Length - 1);

            if (str.Length == 2)
            {
                return back + front;
            }

            string middle = str.Substring(1, str.Length - 2);

            return back + middle + front;
        }
    }
}
