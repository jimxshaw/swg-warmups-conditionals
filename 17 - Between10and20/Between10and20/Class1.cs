using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between10and20
{
    public class Class1
    {
        public bool Between10and20(int a, int b)
        {
            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                return true;
            }
            return false;
        }
    }
}
