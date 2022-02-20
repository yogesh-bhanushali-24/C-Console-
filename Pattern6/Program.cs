using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            Console.Write("\n Enter the value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
