using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    class Class1
    {
        public void display()
        {
            Console.WriteLine("This Is Super Class");
        }
    }
    class Class2 : Class1
    {
        public new void display()
        {
            Console.WriteLine("This Is Child Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.display();
            Console.Read();
        }
    }
}
