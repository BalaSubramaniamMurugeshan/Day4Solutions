using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_One_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            Console.Write("Enter the range : ");
            int range = int.Parse(Console.ReadLine());
            int[] arr = new int[range+1];
            for (int i = 0; i < range+1; i++)
                arr[i] = i;
            var EvenNumbers = from Numbers in arr where Numbers % 2 == 0 select Numbers;
            foreach (var Numbers in EvenNumbers)
                Console.Write(Numbers+" ");
            Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
}
    }
}
