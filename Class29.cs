using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class29
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter a number to print the pattern:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + "");

                }
                Console.WriteLine();
            }

        }
    }
}
