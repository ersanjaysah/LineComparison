using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comprison
{
    public class Class1
    {
        double sum;
        int length1;
        int length2;
        public void length(int x1, int y1, int x2, int y2)
        {
            sum = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("result is= " + sum);

        }
        public void Lines_equal(int a1, int a2, int b1, int b2)
        {
            if (a1 == a2)
            {

                Console.WriteLine(b1.Equals(b2));


            }
            else
            {
                length1 = b1 - a1;
                length2 = b2 - a2;
                Console.WriteLine(length1.Equals(length2));

            }
        }
    }
}
