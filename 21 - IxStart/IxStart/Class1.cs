using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IxStart
{
    public class Class1
    {
        public bool IxStart(string str)
        {
            if (str.IndexOf("ix") >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
