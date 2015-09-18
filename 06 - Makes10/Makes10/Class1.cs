using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makes10
{
    public class Class1
    {
        public bool Makes10(int a, int b)
        {
            if ((a == 10 || b == 10) || ((a + b) == 10))
            {
                return true;
            }

            return false;
        }
    }
}
