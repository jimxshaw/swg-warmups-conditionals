using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleSum
{
    public class SumDouble
    {
        public int DoubleSum(int a, int b)
        {
            if (a == b)
            {
                return 2*(a + b);
            }

            return a + b;
        }
    }
}
