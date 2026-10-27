using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter a string:");
            string str = Console.ReadLine();
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            Console.WriteLine("reverse string is:" + rev);

            if (rev == str)
            {
                Console.WriteLine(str +"is a palidrone:");

            }
            else
            {
                Console.WriteLine(str +"is no palidrone:" );
            }
        }
    }
}