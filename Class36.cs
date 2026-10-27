using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employee5
    {
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicPay;
            
            public Employee5(int emp_code, string emp_name, string designation, double basicPay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicPay = basicPay;
        }

        public void CalculatePay()
        {
            double hra = basicPay * 0.10;
            double da = basicPay * 0.45;
            double netSalary = basicPay + hra + da;

            Console.WriteLine("Employee Code: " + emp_code);
            Console.WriteLine("Employee Name: " + emp_name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Pay: " + basicPay);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Gross Pay: " + netSalary);
        }


    }

    class Class36
    {
        public static void Main()
        {

            Employee5 e1 = new Employee5(101, "MAHI", "Software Engineer", 50000);
            e1.CalculatePay();
        
            Employee5 e2 = new Employee5(101, "shriya", " backend devloper", 60000);
            e2.CalculatePay();

            Employee5 e3 = new Employee5(101, "mitu", "computer engineering", 70000);
            e3.CalculatePay();

            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");
           
           
            Console.ReadLine();
        }
    }
}
