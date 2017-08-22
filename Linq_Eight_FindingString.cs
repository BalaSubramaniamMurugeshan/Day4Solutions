using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Eight_FindingString
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                String[] arr = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI",
                    "PARIS" };
                Console.WriteLine("Enter the starting character of the string : ");
                char StartingCharacter = Console.ReadKey().KeyChar;
                Console.ReadLine();
                String Sc = StartingCharacter.ToString();
                Console.WriteLine("Enter the ending character of the string : ");
                Char EndingCharacter = Console.ReadKey().KeyChar;
                Console.ReadLine();
                String Ec = EndingCharacter.ToString();
                var Result=from @string in arr where 
                           @string.StartsWith(Sc) & @string.EndsWith(Ec)
                           select @string;
                foreach(var city in Result)
                    Console.WriteLine("The resultant string is : " + city);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
