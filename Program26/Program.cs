using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26
{
    interface test
    {
        void gettest(int marks1, int marks2);
    }
    interface student
    {
        void getid(int id);
    }
    class result : test, student
    {
        public void getid(int id)
        {
            Console.WriteLine("id" + id);
        }

        public void gettest(int marks1, int marks2)
        {

            int sum = marks1 + marks2;
            Console.WriteLine("Marks1:" + marks1);
            Console.WriteLine("Marks2:" + marks2);
            Console.WriteLine("SUM:" + sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            result res = new result();
            res.getid(1);
            res.gettest(50, 80);
            Console.Read();

        }
    }
}
