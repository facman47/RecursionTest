using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactR(3));
            Console.ReadKey();
        }

        public static int FactR(int n)
        {
            Console.WriteLine(n+" n");
            int result;
            if (n == 1) return 1;
            result = FactR(n - 1) * n;
            Console.WriteLine(n+" n end");
            return result;
        }
    }
}
