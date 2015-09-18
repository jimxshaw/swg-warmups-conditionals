using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParrotTrouble
{
    public class Class1
    {
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (hour > 23 || hour < 0)
            {
                Console.WriteLine("The hour entered is not in the range of 0 to 23!");
                return false;
            }
            if (isTalking && (hour < 7 || hour > 20))
            {
                return true;
            }

            return false;
        }
    }
}
