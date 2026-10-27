using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    //Declaration
    delegate void MyDelegatee(int x, int y);
    class DelegateDemo_A1
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main(string[] args)
        {
            //instatiation
            MyDelegatee obj = new MyDelegatee(Add);
            obj += new MyDelegatee(Sub);
            obj += Mul;
            obj += Div;
            //MyDelegatee obj2 = new MyDelegatee(Sub);

            //invocation
            obj(15, 5);
            //Add(15, 5);
            Console.Read();
        }
    }
}