using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ten_StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string :");
                String str = Console.ReadLine();
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                Console.WriteLine("The reversed string is :");
                foreach (char element in arr)
                    Console.Write(element);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
