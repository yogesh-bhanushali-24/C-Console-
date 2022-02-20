using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program39
{
    public class ClsMain
    {
        private static void Main()
        {
            bool IsEqual = ClsCalculator.AreEqual(10, 20);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
