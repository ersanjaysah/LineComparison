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
        public void length(int x1, int y1, int x2, int y2)
        {
            sum = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("result is= " + sum);

        }
    }
}
