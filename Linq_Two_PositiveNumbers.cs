using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Two_PositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of elements : ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Enter the range : ");
                int range = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements within the range : (" + range + ")");
                int[] arr = new int[num];
                for (int i = 0; i < num; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                var PositiveNumbers = from Numbers in arr where Numbers > 0 && Numbers < range select Numbers;
                foreach (int elements in PositiveNumbers)
                    Console.Write(elements + " ");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
