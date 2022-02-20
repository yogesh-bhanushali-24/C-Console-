using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18
{
    class Program
    {
        static void Main(string[] args)
        {
            // string
            String str = "Magic";

            Console.WriteLine("OldString : " + str);

          
            Console.WriteLine("NewString: " + str.Replace('c', 'k'));
            Console.Read();

        }
    }
}
