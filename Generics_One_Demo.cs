using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_One_Demo
{
    class GenDemo<T>
    {
        public String GenMethod(T input)
        {
            String str=input.ToString();
            return str;
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            try
            {
                GenDemo<int> obj1 = new GenDemo<int>();
                Console.Write("Enter a Integer value : ");
                int num1 = int.Parse(Console.ReadLine());                
                Console.WriteLine("Equivalent String is : " + obj1.GenMethod(num1));

                GenDemo<double> obj2 = new GenDemo<double>();
                Console.Write("Enter a Double value : ");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Equivalent String is : " + obj2.GenMethod(num2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
