using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Three_Interface
{
    interface GenInterface<T>
    {
        T Add(T arg1, T arg2);
        T Subtract(T arg1, T arg2);
        T Multiply(T arg1, T arg2);
        T Divide(T arg1, T arg2);
    }
    class BasicMath : GenInterface<int>
    {
        public int Add(int arg1, int arg2)
        {
            return arg1 + arg2;           
        }

        public int Divide(int arg1, int arg2)
        {
            return arg1 / arg2;            
        }

        public int Multiply(int arg1, int arg2)
        {
            return arg1 * arg2;            
        }

        public int Subtract(int arg1, int arg2)
        {
            return arg1 - arg2;            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BasicMath obj = new BasicMath();
                {
                    Console.WriteLine("Enter the numbers to add : ");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The addition of two numbers is : " + obj.Add(num1, num2));
                }
                {
                    Console.WriteLine("Enter the numbers to subtract : ");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The subtraction of two numbers is : " + obj.Subtract(num1, num2));
                }
                {
                    Console.WriteLine("Enter the numbers to multiply : ");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The multiplication of two numbers is : " + obj.Multiply(num1, num2));
                }
                {
                    Console.WriteLine("Enter the numbers to divide : ");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The division of two numbers is : " + obj.Divide(num1, num2));
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
