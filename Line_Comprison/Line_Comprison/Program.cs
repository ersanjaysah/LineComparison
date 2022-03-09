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
        }
    }
}
