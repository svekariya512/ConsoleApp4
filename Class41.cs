using System;

abstract class Test

{

   public int a;

    public abstract void A();

}



class Example1 : Test

{

    public override void A()

    {

        Console.WriteLine("Example1.A");

        base.a++;

    }

}

class Example2 : Test

{

    public override void A()

    {

        Console.WriteLine("Example2.A");

        base.a--;

    }

}

class Class41

{

    static void Main()

    {
        Console.WriteLine("Name : shreeya vekariya");
        Console.WriteLine("Enrollment No : 24SOECE11050 ");

        // Reference Example1 through Test type.

        Test test1 = new Example1();

        test1.A();

        // Reference Example2 through Test type.

        Test test2 = new Example2();

        test2.A();

    }

}
