using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program38
{
    public class students
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", "1");
            dic.Add("Name", "Yamik");
            dic.Add("Gender", "Male");
            dic.Add("Branch", "MCA");
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.Read();
        }
    }
}
