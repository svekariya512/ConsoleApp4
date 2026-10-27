using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string find the length:");
            string str = Console.ReadLine();


            int length = 0;

            foreach (char c in str)
            {
                {
                    length = length + 1;
                }

                Console.WriteLine("length of string:" + length);
            }
        }
    }
}