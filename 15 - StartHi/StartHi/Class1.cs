using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartHi
{
    public class Class1
    {
        public bool StartHi(string str)
        {
            if (str.StartsWith("hi"))
            {
                if ((str.IndexOf(" ") == 2) || (str.Length == 2))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
