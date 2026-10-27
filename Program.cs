using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.reverse string
            //algorithm
            //take the input from user
            Console.WriteLine("enter a string to reverse:");
            String str = Console.ReadLine();
            //ICloneable empty string vARIABLE TO STORE REVERSe
            string rev = "";
            //loop through the string from last index to first
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            //rev = rev + str[index]
//print the rev string
            Console.WriteLine("reverse string is:" + rev);
        }
    }
}
//CodeRemove space
//Count no of words
