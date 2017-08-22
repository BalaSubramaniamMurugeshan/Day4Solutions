using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastEvents
{
    public delegate void Operations(int Num1, int Num2);
    class Program
    {
        static void Addition(int num1,int num2)
        {
            Console.WriteLine("Addition of the numbers is : "+(num1+ num2));
        }
        static void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Multiplication of the numbers is : " + (num1 * num2));
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number 1 : ");
                int Number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number 2 : ");
                int Number2 = int.Parse(Console.ReadLine());
                Operations Object = new Operations(Addition);
                Object += Multiplication;
                Object(Number1,Number2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
