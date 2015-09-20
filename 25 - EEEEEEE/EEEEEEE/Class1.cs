using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEEEEEE
{
    public class Class1
    {
        public bool GotE(string str)
        {
            int counter = 0;
            foreach (var element in str)
            {
                if (element == 'e')
                {
                    counter++;
                }
            }

            if (counter >= 1 && counter <= 3)
            {
                return true;
            }

            return false;
        }
    }
}
