using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class31
    {
        public static void Main(string[] args)
        {

            int num = 1;
            Console.WriteLine("enter a number to print the pattern:");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                int start = num + i - 1;

                for (int j = start; j >= num; j--)
                {
                  Console.Write(j + " ");

                }
                num += i;
                Console.WriteLine();
            }
        }
    }
}
