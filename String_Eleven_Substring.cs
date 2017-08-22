using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Eleven_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                Console.Write("Enter the starting position of the substring : ");
                int position = int.Parse(Console.ReadLine());
                Console.Write("Enter the length of the substring : ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("The substring is : ");
                for (int i = position - 1, j = 1; i < str.Length && j <= length; i++, j++)
                    Console.Write(str[i]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
