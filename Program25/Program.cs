using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25
{
    public class person
    {
        public string name;
        public int age;
        public void setperson(string n, int a)
        {
            name = n;
            age = a;
        }
        public void displayperson()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
        }
    }
    public class student : person
    {
        public float persertange;
        public void setstudent(float p, string n, int a)
        {
            persertange = p;
            setperson(n, a);
        }
        public void displaystudent()
        {
            Console.WriteLine("Persentage:" + persertange);

        }
    }
    public class teacher : person
    {
        public float salary;
        public void setTeacher(string n, int a, float s)
        {
            salary = s;
            setperson(n, a);
        }
        public void display()
        {
            Console.WriteLine("Teacher Details");
            displayperson();
            Console.WriteLine("Salry:" + salary);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.name = "Yamik";
            std.age = 22;
            std.persertange = 85;

            std.displaystudent();
            teacher t = new teacher();
            t.name = "Mahesh";
            t.age = 40;
            t.salary = 50000;
            t.display();
            Console.Read();

        }
    }
}
