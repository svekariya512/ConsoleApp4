
using System;

namespace ConsoleApp4

{

    class StaticVar

    {

        public static int num;



        public void count()

        {

            num++;

        }

//………………………………Missing statement……………………………….//      
public static int getNum()
        {

            return num;

        }

}

class Class39

{

    static void Main(string[] args)

    {

            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");

            StaticVar s = new StaticVar();

        s.count();

        s.count();

        s.count();

        Console.WriteLine("Variable num: {0}", StaticVar.getNum());

        Console.ReadKey();

    }

}

}