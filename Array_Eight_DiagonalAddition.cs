using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Eight_DiagonalAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the dimensions of an array (rows & columns) :");
                int rows = int.Parse(Console.ReadLine());
                int columns = int.Parse(Console.ReadLine());
                int[,] arr = new int[rows,columns];
                Console.WriteLine("Enter the array elements : ");
                for(int i=0;i<rows;i++)
                    for(int j=0;j<columns;j++)
                        arr[i,j]= int.Parse(Console.ReadLine());
                Console.WriteLine("The entered array is : ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    Console.WriteLine();
                }
                int DiagonalSum = 0;
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        if (i == j)
                            DiagonalSum += arr[i, j];
                Console.WriteLine("The sum of diagonal elements of given array is : "+DiagonalSum);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
