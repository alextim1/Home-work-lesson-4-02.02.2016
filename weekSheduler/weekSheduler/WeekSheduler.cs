using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekSheduler
{
    public class WeekSheduler
    {
        public bool ArrangeDay(ref Days shedule, Days dayToAdd)
        {
            if ((shedule & dayToAdd)==dayToAdd)
            {
                return false;
            }

            shedule |= dayToAdd;
            return true;
        }

        public bool CheckDay(Days shedule, Days dayToCheck)
        {
            if ((shedule & dayToCheck) == dayToCheck)
            {
                return true;
            }

           
            return false;
        }

        public void ResetDay(ref Days shedule, Days dayToRemove)
        {
            shedule &= ~dayToRemove;
        }
    }
}
