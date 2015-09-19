using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcyHot
{
    public class Class1
    {
        public bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0))
            {
                return true;
            }
            return false;
        }
    }
}
