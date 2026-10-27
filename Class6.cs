using System;

namespace ConsoleApp4

{

    class Line

    {
        private double length;   // Length of a line

        public Line()

        {

            //………………………………Missing statement-1……………………………….// 

            Console.WriteLine("Object is being creating value length = 10");

            //………………………………Missing statement-2……………………………….// 
            length = 10;
        }
        public void setLength(double len)

        {

            //………………………………Missing statement-3……………………………….//      
            length = len;

        }

        public double getLength()

        {

            //………………………………Missing statement-4……………………………….//
            return length;

        }

    }

    class Class6

    {

        static void Main(string[] args)

        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");

            Line line = new Line();

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length
            line.setLength(6);

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }

    }

}