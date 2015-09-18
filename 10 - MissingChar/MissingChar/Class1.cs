using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingChar
{
    public class Class1
    {
        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
