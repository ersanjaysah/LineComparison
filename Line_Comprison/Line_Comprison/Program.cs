using System;

namespace Line_Comprison
{
    public class Program
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("HELLO SIR Welcome to Line Comparision Computation Program");
            Console.WriteLine("please enter your 1st cordinate number");
            Class1 obj = new Class1();
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your 2nd cordinate number");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your 3rd cordinate number");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your 4th cordinate number");
            int y2 = Convert.ToInt32(Console.ReadLine());
            obj.length(x1, x2, y1, y2);

            // From Here UC2 started
            Console.WriteLine("To Check both lines equals or not, By Equal Method");
            Console.WriteLine("enter 1st point number");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd point number");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 3rd point number");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 4th point number");
            int b2 = Convert.ToInt32(Console.ReadLine());
            obj.Lines_equal(a1, a2, b1, b2);

            //from here UC3 started
            Console.WriteLine("Welcome to the length checking");
            Console.WriteLine("Enter First number of First cordinate");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number of First cordinate");
            int p2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First number of second cordinate");
            int r1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number of second cordinate");
            int r2 = Convert.ToInt32(Console.ReadLine());

            obj.checkLength(p1, p2, r1, r2);


        }
    }
}
