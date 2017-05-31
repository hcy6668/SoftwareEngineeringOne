using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxR_2
{
    class Program
    {
        private int count = 1;
        private double sum = 0;
        static void Main(string[] args)
        {
         
        }

        double func(int m)
        {
            if (count == m)
                return sum;
            FindMaxCircle();
            count++;
            func(m);
            return 0;
        }
    }
}
