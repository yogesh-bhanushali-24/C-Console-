using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program27
{
    public class def
    {
        string name;
        public void names(string n)
        {
            name = n;
            Console.WriteLine("Name is:" + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            def de = new def();
            de.names("Yogesh");
            Console.Read();

        }
    }
}
