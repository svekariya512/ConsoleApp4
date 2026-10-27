using System;

class Class44
{
    public static void Main()
    {
        Console.WriteLine("Name : shreeya vekariya");
        Console.WriteLine("Enrollment No : 24SOECE11050 ");
        int x = 0;
        try
        {
            // This statement causes DivideByZeroException
            int div = 100 / x;

            Console.WriteLine(div);
        }
        catch (DivideByZeroException)
        {
            // Handle division by zero
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            // This block always executes
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program completed.");
        Console.Read();
    }
}

//--------------------------------------------
