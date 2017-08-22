using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Three_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                Console.WriteLine("The characters in the string in reverse order :");
                foreach (char c in arr)
                    Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
