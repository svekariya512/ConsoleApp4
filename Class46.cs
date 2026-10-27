using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    //Declaration
    delegate void MyDelegate(int x, int y);
    class DelegateDemo_A
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Main(string[] args)
        {
            //instatiation
            MyDelegate obj = new MyDelegate(Add);

            //invocation
            obj(15, 5);
            Add(15, 5);
        }
    }
}