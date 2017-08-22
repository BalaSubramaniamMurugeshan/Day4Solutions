using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Eleven_TopNRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of elements :");
                int num = int.Parse(Console.ReadLine());
                int[] arr = new int[num];
                Console.WriteLine("Enter the elements :");
                for (int i = 0; i < num; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("How many elements you want to display :");
                int NumberOfElements = int.Parse(Console.ReadLine());
                Console.WriteLine("The top " + NumberOfElements + " elements are :");
                Array.Sort(arr);
                Array.Reverse(arr);
                foreach (int element in arr.Take(NumberOfElements))
                    Console.WriteLine(element);                              
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
