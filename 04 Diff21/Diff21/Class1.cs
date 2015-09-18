using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diff21
{
    public class Class1
    {
        public int Diff21(int n)
        {
            if (n > 21)
            {
                return 2*(Math.Abs(n - 21));
            }

            return Math.Abs(n - 21);
        }
    }
}
