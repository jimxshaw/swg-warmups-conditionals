using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreWeInTrouble
{
    public class MischievousChildren
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
            {
                return true;
            }
            if (!aSmile && !bSmile)
            {
                return true;
            }

            return false;
        }
    }
}
