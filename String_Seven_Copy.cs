using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Seven_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str1 = Console.ReadLine();
                String str2 = (String)str1.Clone();
                Console.WriteLine("Copy of the string is :");
                Console.WriteLine(str2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
