using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program28
{
    partial class mydisp
    {
        public void disp()
        {
            Console.WriteLine("Display Message From mydesp");
        }
    }
    partial class mydisp
    {
        public void display()
        {
            Console.WriteLine("Display Message From mydispdata");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            mydisp dis = new mydisp();
            dis.disp();
            dis.display();
            Console.Read();

        }
    }
}
