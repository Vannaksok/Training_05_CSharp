using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Nhap so n = ");
            String s = Console.ReadLine();
            n = int.Parse(s); // Ep kieu tu String thanh In

            int a = n + 2;
            Console.WriteLine("n = {0}", n);
            Console.WriteLine("a = {0}", a);

            if (n % 2 == 0)
            {
                Console.WriteLine("N la so Chan");
                Console.WriteLine("Het");
            }
            else
            {
                Console.WriteLine("N la so Le");
            }

            switch (n)
            {
                case 1:
                    Console.WriteLine("So Mot");
                    break;
                case 2:
                    Console.WriteLine("So Hai");
                    break;
                case 3:
                    Console.WriteLine("So Ba");
                    break;
                default:
                    Console.WriteLine("Hong biet so gi luon do");
                    break;
            }

            Console.ReadKey();
        }
    }
}
