using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program35
{
    public class parent
    {
        public void input()
        {
            Random rand = new Random();
            Console.WriteLine("Five random integers between 0 and 100:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} -> {1}", i, rand.Next(50, 100));
            }
        }
    }
    public class child : parent
    {
        public void output()
        {
            input();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            child c1 = new child();
            c1.output();
            Console.Read();
        }
    }
}
