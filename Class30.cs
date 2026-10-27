using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number to print the pattern:");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0) 
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
