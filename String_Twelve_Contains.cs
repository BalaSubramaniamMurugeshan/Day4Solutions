using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Twelve_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                Console.WriteLine("Enter the string to be found :");
                String substr = Console.ReadLine();
                if (str.Contains(substr))
                    Console.WriteLine("Yes , it is present");
                else
                    Console.WriteLine("No , it is not present");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
