using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Thirteen_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string1 :");
                String str1 = Console.ReadLine();
                Console.WriteLine("Enter the string2 :");
                String str2 = Console.ReadLine();
                if (str1.CompareTo(str2)==0)
                    Console.WriteLine("Both strings are equal .");
                else if(str1.CompareTo(str2)>0)
                    Console.WriteLine("String 1 is greater than String 2 .");
                else
                    Console.WriteLine("String 2 is greater than String 1 .");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
