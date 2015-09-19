using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple3or5
{
    public class Class1
    {
        public bool Multiple3or5(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("You number cannot be negative.");
                return false;
            }
            if ((number%3 == 0) || (number%5 == 0))
            {
                return true;
            }

            return false;
        }
    }
}
