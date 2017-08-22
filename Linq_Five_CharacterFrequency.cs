using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Five_CharacterFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the String :");
                String str = Console.ReadLine();
                var CharacterFrequency = from Character in str group Character by Character into Frequency select Frequency;
                foreach (var element in CharacterFrequency)
                    Console.WriteLine("Character : " + element.Key + " Frequency : " + element.Count());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
