using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    class Program
    {
        public static int Circle(int pi, int r)
        {
            return pi*r*r;
        }

        public static int Rectangle(int l, int b)
        {
            return l*b;
        }

        public static int Triangle(int b, int h)
        {
            return 1/2*b*h;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of two numbers: " + Program.Circle(10, 15));
            Console.WriteLine("Multiplication of three numbers: " + Program.Rectangle(8, 13));
            Console.WriteLine("Multiplication of four numbers: " + Program.Triangle(3, 7));
            Console.Read();
        }
    }
}
