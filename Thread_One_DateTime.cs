using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_One_DateTime
{
    class Program
    {
        public void DisplayDate()
        {           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(2000);                
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Program obj = new Program();
                Thread Threadobj = new Thread(new ThreadStart(obj.DisplayDate));   
                Threadobj.Start();                                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
