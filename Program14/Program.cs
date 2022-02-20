using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            try
            {
                // Do not initialize this variable here.
                n = 123;
                Console.WriteLine(n);
            }
            catch
            {
                Console.WriteLine("Exception");
            }
            // Error: Use of unassigned local variable 'n'.
            
            Console.Read();   
        }
       
    }
}
