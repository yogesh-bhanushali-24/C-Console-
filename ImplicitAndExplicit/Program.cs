using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8485488;
            long bigNum = num;

            double x = 1234.58;
            int a;
            //cast double to integer
            a = (int)x;

            Console.WriteLine("Implicit:{0}", bigNum);
            Console.WriteLine("Explicit:{0}", x);
            Console.Read();
        }
    }
}
