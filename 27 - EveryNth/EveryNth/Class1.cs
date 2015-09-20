using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryNth
{
    public class Class1
    {
        public string EveryNth(string str, int n)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i += n)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
