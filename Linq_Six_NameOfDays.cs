using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Six_NameOfDays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String[] WeekDays = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
                var Days = from Day in WeekDays select Day;
                Console.WriteLine("The days in a week are :");
                foreach (var Day in Days)
                    Console.WriteLine(Day);
                Console.ReadKey();           
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
