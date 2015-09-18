using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearHundred
{
    public class Class1
    {
        public bool NearHundred(int n)
        {
            if ((Math.Abs(n - 100) <= 10) || (Math.Abs(n - 200) <= 10))
            {
                return true;
            }

            return false;
        }
    }
}
