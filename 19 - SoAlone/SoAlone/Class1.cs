using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoAlone
{
    public class Class1
    {
        public bool SoAlone(int a, int b)
        {
            if ((a >= 13 && a <= 19) && (b >= 13 && b <= 19))
            {
                return false;
            }

            return true;
        }

    }
}
