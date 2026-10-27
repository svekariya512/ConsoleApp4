using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class student

    {
        static int count = 0;

        public student()
        {
            count++;
        }

        public static void Display()
        {
            Console.WriteLine("Total number of students: " + count);
        }


    }

    class Class19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");

            student s1 = new student();
            student s2 = new student();
            student s3 = new student();
            student s4 = new student();
            student s5 = new student();
            student.Display();
        }
    }
}
