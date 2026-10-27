using System;


namespace ConsoleApp4

{

    class Product

    {
        int pcode;
        string pname;
        string mname;

        public Product(int pcd, String pnm, String mnm)

        {

            pcode = pcd;
            pname = pnm;
            mname = mnm;

        }

        public void Display()

        {

            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");
            Console.WriteLine("product code is := " + pcode);
            Console.WriteLine("product name is := " + pname);
            Console.WriteLine("manufacturer name is := " + mname);


        }

    }
    
    public class Class4

    {

        public static void Main(string[] args)

        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");
            int n = args.Length;

            if (args.Length < 3)

            {

                Console.WriteLine("Syntax Error");
                return;
            }

             int pcd = Convert.ToInt32(args[0]);
            string pnm = args[1];
            string mnm = args[2];


            Product p = new Product(pcd, pnm, mnm);

                p.Display();

                Console.Read();

            }

        }

    }

