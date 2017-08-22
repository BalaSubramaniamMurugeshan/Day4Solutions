using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Two_Add
{
    public class GenClass<T>
    {
        public virtual T Add(T input1, T input2)
        {
            var str = input1.ToString() + input2.ToString();
            return (T)Convert.ChangeType(str,typeof(T));
        }
    }
    class GenInt : GenClass<int>
    {
        public override int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
    class GenString : GenClass<String>
    {
        public override String Add(String one,String two)
        {
            return one + two;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenClass<int> obj1 = new GenInt();
            Console.WriteLine("Enter two integers values :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The additon of two values is : "+obj1.Add(num1,num2));

            GenClass<String> obj2 = new GenString();
            Console.WriteLine("Enter two strings :");
            String one = Console.ReadLine();
            String two = Console.ReadLine();
            Console.WriteLine("The additon of two values is : " + obj2.Add(one,two));

            Console.ReadKey();
        }
    }
}
