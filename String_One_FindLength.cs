using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_One_FindLength
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string : ");
                String str = Console.ReadLine();
                int length=0;
                foreach (char c in str)
                    length++;
                Console.WriteLine("The length of the string is : "+length);         
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
