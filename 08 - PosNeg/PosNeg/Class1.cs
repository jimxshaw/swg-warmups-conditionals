using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNeg
{
    public class Class1
    {
        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative)
            {
                if (a < 0 && b < 0)
                {
                    return true;
                }

                return false;
            }
            if (!negative)
            {
                if (a > 0 && b < 0)
                {
                    return true;
                }
                if (a < 0 && b > 0)
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
