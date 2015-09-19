using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasTeen
{
    public class Class1
    {
        public bool HasTeen(int a, int b, int c)
        {
            if (((a >= 13 && a <= 19) || (b >= 13 && b <= 19)) || ((a >= 13 && a <= 19) || (c >= 13 && c <= 19)) ||
                ((b >= 13 && b <= 19) || (c >= 13 && c <= 19)))
            {
                return true;
            }
            return false;
        }
    }
}
