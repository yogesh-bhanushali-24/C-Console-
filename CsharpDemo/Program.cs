using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b;
            Console.WriteLine("A value: {0}", a);
         

            Console.Write("Enter Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B value:{0}", b);

            Console.Read();
        }
    }
}
