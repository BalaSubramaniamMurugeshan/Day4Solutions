using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_One_StringReverse
{
    public delegate String strMyDel(String str);
    class TestDelegate
    {
        public String Space(String str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char element in str)
                sb.Append(element+" ");
            return sb.ToString();
        }
        public String Reverse(String str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            StringBuilder sb = new StringBuilder();
            foreach (char element in arr)
                sb.Append(element);
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            try
            {
                TestDelegate obj = new TestDelegate();
                strMyDel space = new strMyDel(obj.Space);
                strMyDel reverse = new strMyDel(obj.Reverse);

                Console.Write("Enter the string to insert space : ");
                String str1 = Console.ReadLine();
                str1 = space(str1);
                Console.WriteLine("The string with space is : " + str1);

                Console.Write("Enter the string to reverse : ");
                String str2 = Console.ReadLine();
                str2 = reverse(str2);
                Console.WriteLine("The reversed string is : " + str2);

                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
