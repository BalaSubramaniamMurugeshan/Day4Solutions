using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Nine_MaxOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the String : ");
                String str = Console.ReadLine();
                int[] arr = new int[255];
                for (int i = 0; i < 255; i++)
                    arr[i] = 0;
                int max = 0;
                for(int i=0;i<str.Length;i++)
                {
                    arr[str[i]]++;
                }
                for (int i = 0; i < 255; i++)
                    if (arr[i] > arr[max])
                        max = i;
                Console.WriteLine("Maximum appearing character is : {0}\nNumber of times is : {1}",(char)max,arr[max]);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
