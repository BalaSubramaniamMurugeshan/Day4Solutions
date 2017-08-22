using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Ten_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                char[] arr = str.ToCharArray();
                for (int i = 0; i < arr.Length - 1; i++) 
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if(arr[j]>arr[j+1])
                        {
                            char temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted String : ");
                foreach (char element in arr)
                {
                    if(element!=' ')
                    Console.Write(element);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
