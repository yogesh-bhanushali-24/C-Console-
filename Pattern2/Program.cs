using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.Write("Enter the number--->");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i=0;i<=rows;i++)
            {
                for(j=0;j<=i;j++)
                {
                    if(j%2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}