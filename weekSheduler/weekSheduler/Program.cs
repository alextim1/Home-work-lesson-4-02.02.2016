using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekSheduler
{
    [Flags]
    public enum Days
    {
        Sunday = 64,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32
    }

    class Program
    {
        


        static void Main(string[] args)
        {
            WeekSheduler organizer = new WeekSheduler();
            Days plans = Days.Monday | Days.Tuesday | Days.Friday;

            Console.WriteLine(organizer.ArrangeDay(ref plans, Days.Monday));
            Console.WriteLine(organizer.ArrangeDay(ref plans, Days.Wednesday));
            Console.WriteLine(organizer.CheckDay(plans, Days.Wednesday));
            organizer.ResetDay(ref plans, Days.Monday);
            Console.WriteLine(organizer.CheckDay(plans, Days.Monday));
            Console.WriteLine(plans);
            Console.ReadKey();

        }
    }
}
