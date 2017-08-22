using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Two_Demo34
{
    class MyClass
    {
        public static void Run()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Thread Name : "+Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
    }
    class ThreadDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Thread ThreadObj1 = new Thread(new ThreadStart(MyClass.Run));
                ThreadObj1.Name = "First Child.";

                Thread ThreadObj2 = new Thread(new ThreadStart(MyClass.Run));
                ThreadObj2.Name = "Second Child.";

                Thread ThreadObj3 = new Thread(new ThreadStart(MyClass.Run));
                ThreadObj3.Name = "Third Child.";

                ThreadObj1.Start();
                ThreadObj2.Start();
                ThreadObj3.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
