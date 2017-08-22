using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Eight_Vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string :");
                String str = Console.ReadLine();
                int vowel = 0, consonant = 0;
                for(int i=0;i<str.Length;i++)
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                        str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                        vowel++;
                    else if((str[i]>='a' && str[i] >= 'z' ) || (str[i] >= 'A' && str[i] >= 'Z'))
                        consonant++;
                }
                Console.WriteLine("Vowels : "+vowel);
                Console.WriteLine("Consonant : "+consonant);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
