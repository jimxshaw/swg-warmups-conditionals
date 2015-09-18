using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanSleepIn
{
    public class SleepingIn
    {
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday && !isVacation)
            {
                return true;
            }
            if (isWeekday && !isVacation)
            {
                return false;
            }
            if (!isWeekday && isVacation)
            {
                return true;
            }

            return true;

        }
    }
}
