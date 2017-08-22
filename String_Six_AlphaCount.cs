using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Six_AlphaCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                int alpha = 0, digit = 0, special = 0;
                for(int i=0;i<str.Length;i++)
                {
                    if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                        alpha++;
                    else if (str[i] >= '0' && str[i] <= '9')
                        digit++;
                    else
                        special++;
                }
                Console.WriteLine("Alphabets in the string :"+alpha);
                Console.WriteLine("Digits in the string : "+digit);
                Console.WriteLine("Special characters in the string :"+special);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
