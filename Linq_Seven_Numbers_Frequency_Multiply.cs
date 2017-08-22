using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Seven_Numbers_Frequency_Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of elements in the array :");
                int num = int.Parse(Console.ReadLine());
                int[] arr = new int[num];
                Console.WriteLine("Enter the array elements :");
                for (int i = 0; i < num; i++)
                    arr[i] = int.Parse(Console.ReadLine());
                var NumberFrequency = from Number in arr group Number by Number into Frequency select Frequency;
                foreach (var element in NumberFrequency)
                    Console.WriteLine("Number : "+element.Key+" Number * Frequency : "+element.Sum()+
                        " Frequency : "+element.Count());
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
