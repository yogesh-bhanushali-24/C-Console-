using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            marks mark = new marks();
            int total = mark.subject1 + mark.subject2 + mark.subject3;
            Console.Write("{0}",total);
            Console.Read();

        }
    }
    class marks  // base class (parent) 
    {
       
        public int subject1 = 10;
        public int subject2 = 30;
        public int subject3 = 40;
    }
}
