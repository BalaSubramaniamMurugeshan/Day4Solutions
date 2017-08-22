using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Five_DescendingSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array :");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int[] arr = new int[num];
                Console.WriteLine("Enter the array elements :");
                for (int i = 0; i < num; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine("The elements sorted in descending order are : ");
                foreach (int element in arr)
                    Console.WriteLine(element);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        }
}
