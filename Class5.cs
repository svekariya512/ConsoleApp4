using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        public int Id;
        public string Name;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string name

        {
            get { return Name; }
            set { Name = value; }
        }

        public Student()
        {
            Id = 1;
            Name = "unknown";
        }

        public Student(int i, string n)
        {
            Id = i;
            Name = n;
        }
        public void display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
        }

    }

    class class5
    {

        static void Main(string[] args)


        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");

            Student s = new Student(101, "shreeya");
            s.display();
        }

    }
}
