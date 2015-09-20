using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    public class Class1
    {
        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            if (b > a && b > c)
            {
                return b;
            }
            return c;
        }
    }
}
