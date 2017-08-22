using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Three_SquareNumbers
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
                Console.WriteLine("Enter the array elements : ");
                for (int i = 0; i < num; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                var SquareNumbers = from Number in arr let Square=Number*Number select new { Number,Square};
                foreach (var Number in SquareNumbers)
                    Console.WriteLine(Number);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
