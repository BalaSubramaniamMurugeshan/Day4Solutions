using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Twelve_FindUppercase
{
    class Program
    {
        static IEnumerable<String> Upper(String str)
        {
            var upperWords = str.Split(' ').Where(word => String.Equals(word, word.ToUpper(), StringComparison.Ordinal));
            return upperWords;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                var UppercaseWords = Upper(str);
                Console.WriteLine("The uppercase words in given string are :");
                foreach (var words in UppercaseWords)
                    Console.WriteLine(words);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
