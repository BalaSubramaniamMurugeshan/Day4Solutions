using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Four_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                String[] arr = str.Split(' ');
                Console.WriteLine("Total number of words in entered string is : "+arr.Length);
                Console.ReadKey();        
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
