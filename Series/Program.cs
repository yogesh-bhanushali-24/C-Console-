using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;

            Console.Write("Enter Number:");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                Console.Write("{0}+", i * i);
                i++;
            }
            Console.Read();

        }
    }
}
