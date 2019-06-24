using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double a = 99.1;
            long b = 9988;
            Console.WriteLine("Number is {1} - {0} - {2}", n, a, b);
            Console.WriteLine("This is: {3} " + n.ToString());

            String s = "Mr Buoi";
            String c = "Hello";
            Console.WriteLine(c + s);
        }
    }
}
