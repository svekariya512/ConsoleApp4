using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {
        private double salary;
        //public method set salary

        public void SetSalary(double amount)
        {
            salary = amount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

        class Class14
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Name : shreeya vekariya");
                Console.WriteLine("Enrollment No : 24SOECE11050 ");


                Employee emp = new Employee();

                Console.Write("Enter Employee Salary: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                emp.SetSalary(amount);

                Console.WriteLine("Employee Salary: " + emp.GetSalary());
                Console.ReadLine();
            }
        }
    
    
}
