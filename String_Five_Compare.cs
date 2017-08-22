using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Five_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st String :");
                String str1 = Console.ReadLine();
                Console.WriteLine("Enter 2nd String :");
                String str2 = Console.ReadLine();
                int Length1 = str1.Length;
                int Length2 = str2.Length;
                int m = (Length1 > Length2) ? Length1 : Length2;
                if (Length1 != Length2)
                    Console.WriteLine("Both Strings are not equal .");
                else
                {
                    bool result = true;
                    for (int i = 0; i < m; i++)
                    {
                        if (str1[i] != str2[i])
                        {
                            result = false;
                            break;
                        }
                    }
                    if (result)
                        Console.WriteLine("Both Strings are equal .");
                    else
                        Console.WriteLine("Both Strings are not equal .");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
