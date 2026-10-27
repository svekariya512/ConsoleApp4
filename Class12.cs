using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class studentDetails
    {

        public int enroll_no { get;  set; }
        public string name { get; set; }

    }
    class Class12
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");


            studentDetails studentDetails = new studentDetails();

            Console.Write("Enter Enrollment Number : ");
            studentDetails.enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name : ");
            studentDetails.name = Console.ReadLine();

            Console.WriteLine("=========Student Details:===========");

            Console.WriteLine("Enrollment Number: " + studentDetails.enroll_no);
            Console.WriteLine("Name: " + studentDetails.name);
            Console.ReadLine();
        }
    }
    }


