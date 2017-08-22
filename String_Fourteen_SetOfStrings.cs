using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Fourteen_SetOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of strings :");
                int num = int.Parse(Console.ReadLine());
                String[] arr = new String[num];
                Console.WriteLine("Enter the strings :");
                for (int i = 0; i < num; i++)
                    arr[i] = Console.ReadLine();
                Console.WriteLine("Enter a new string to be compared :");
                String CompString = Console.ReadLine();
                for(int i=0;i<arr.Length;i++)
                {
                    if (CompString.CompareTo(arr[i]) == 0)
                        Console.WriteLine("New string and String {0} are equal .",i+1);
                    else if (CompString.CompareTo(arr[i]) > 0)
                        Console.WriteLine("New string is greater than String {0} .",i+1);
                    else
                        Console.WriteLine("String {0} is greater than New string .",i+1);
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
