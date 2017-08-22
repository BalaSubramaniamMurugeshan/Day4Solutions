using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Nine_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the dimension of an array (rows & columns ) : ");
                int rows = int.Parse(Console.ReadLine());
                int columns = int.Parse(Console.ReadLine());
                int[,] arr1 = new int[rows, columns];
                int[,] arr2 = new int[rows, columns];
                Console.WriteLine("Enter the elements of the Array 1 :");
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        arr1[i, j] = int.Parse(Console.ReadLine());
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        arr2[i, j] = arr1[i, j];
                Console.WriteLine("Elements in Array 2 are :");
                foreach (int elements in arr2)
                    Console.WriteLine(elements);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
