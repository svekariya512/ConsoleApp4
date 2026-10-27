using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class33
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number that you wnat to print : ");
            int n = Convert.ToInt32(Console.ReadLine());

            

            for (int i = 1; i <= n; i++)
            {
                // Print leading spaces

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= 2 * i - 1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
