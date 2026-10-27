using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class person
    {
        private int age;
        private string name;

        public person(string name, int age)

        {

            this.age = age;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    class Class20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");


            person p1 = new person("shreeya", 20);

            p1.Display();


        }
    }
}

