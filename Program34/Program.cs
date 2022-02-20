using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program34
{
    public interface basedata
    {
        void stud();
    }
    public class deriveddata : basedata
    {
        public void stud()
        {
            Console.WriteLine("Calling Interface");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            deriveddata der = new deriveddata();
            der.stud();
            Console.Read();

        }
    }
}
