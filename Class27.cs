using System;

namespace Lab3
{
    // Sealed class
    sealed class StudentResult1
    {
        private int rollNo;
        private string name;
        private int marks;

        // Constructor
        public StudentResult1(int rollNo, string name, int marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        // Display result
        public void DisplayResult()
        {
            Console.WriteLine("Student Result");
            Console.WriteLine("----------------");
            Console.WriteLine("Roll No : " + rollNo);
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Marks   : " + marks);

            if (marks >= 35)
            {
                Console.WriteLine("Result  : PASS");
            }
            else
            {
                Console.WriteLine("Result  : FAIL");
            }
        }
    }
    class Class27
    {
        static void Main()
        {
            // Creating object of sealed class
            StudentResult1 s = new StudentResult1(101, "Shreya", 78);

            s.DisplayResult();

            Console.ReadKey();
        }
    }
}
