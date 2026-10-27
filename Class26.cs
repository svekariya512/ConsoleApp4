using System;

namespace Lab3
{
    class Class26
    {
        static void Main()
        {


            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");


            Console.Write("Enter Customer Name: ");

            string name = Console.ReadLine();

            Console.WriteLine("String Operations");
            Console.WriteLine("-------------------------");

            // Remove spaces from beginning and end
            name = name.Trim();

            Console.WriteLine("After Trim       : " + name);

            // Convert name to uppercase
            Console.WriteLine("Uppercase Name    : " +
                              name.ToUpper());

            // Convert name to lowercase
            Console.WriteLine("Lowercase Name    : " +
                              name.ToLower());

            // Replace spaces with underscore
            string replacedName = name.Replace(" ", "_");

            Console.WriteLine("After Replace     : " +
                              replacedName);

            // Insert "Mr. " at the beginning
            string formattedName = name.Insert(0, "Mr. ");

            Console.WriteLine("After Insert      : " +
                              formattedName);

            // Display length
            Console.WriteLine("Name Length       : " +
                              name.Length);

            Console.Read();
        }
    }
}