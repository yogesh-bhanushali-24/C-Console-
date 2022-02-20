using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24
{
    public class cricketer
    {
        public string batsmanname;
    }
    public class batsman : cricketer
    {
        public int totalrun, average, bestprfom;
        public int calc()
        {
            average = totalrun / bestprfom;
            return average;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            batsman bat = new batsman();
            bat.batsmanname = "Dhoni";
            bat.totalrun = 1000;
            bat.bestprfom = 5;
            Console.WriteLine("Batsman Name:" + bat.batsmanname);
            Console.WriteLine("Total Run:" + bat.totalrun);
            Console.WriteLine("BestPerform Matches:" + bat.bestprfom);
            Console.WriteLine("Average:" + bat.calc());
            Console.Read();

        }
    }
}
