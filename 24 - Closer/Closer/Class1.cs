using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closer
{
    public class Class1
    {
        public int Closer(int a, int b)
        {
            int distanceA = Math.Abs(a - 10);
            int distanceB = Math.Abs(b - 10);

            if (distanceA == distanceB)
            {
                return 0;
            }

            if (distanceA < distanceB)
            {
                return a;
            }

            return b;
        }
    }
}
