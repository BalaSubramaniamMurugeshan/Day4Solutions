using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_One_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            try
            {
                Console.WriteLine("Enter 5 numbers :");
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                Array.Sort(arr);
                Console.WriteLine("Sorted order of elements are :");
                foreach (int element in arr)
                    Console.WriteLine(element);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
