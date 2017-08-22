using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Ten_GreaterNumber
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
                Console.WriteLine("Enter the value above which the elements should be displayed :");
                int Value = int.Parse(Console.ReadLine());
                var Result = from Number in arr where Number > Value select Number;
                Console.WriteLine("The elements greater than "+Value+" are :");
                foreach (var element in Result)
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
