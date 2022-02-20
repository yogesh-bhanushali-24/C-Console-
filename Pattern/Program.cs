using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, i, j, number = 1;
            Console.Write("Enter the number of rows-->");
            rows= Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write("{0} ", number);
                    ++number;
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
