using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program22
{
    public class Employee
    {
        public string emp_Name;
        public int emp_Age;
        public int emp_Salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ emp_Name="Yamik",emp_Age=22,emp_Salary=50000},
                new Employee{ emp_Name="Rahul",emp_Age=24,emp_Salary=30000},
                new Employee{ emp_Name="Rajesh",emp_Age=24,emp_Salary=35000},
                new Employee{ emp_Name="Kavi",emp_Age=24,emp_Salary=40000},
                new Employee{ emp_Name="Mahesh",emp_Age=26,emp_Salary=55000},
                new Employee{ emp_Name="Nil",emp_Age=26,emp_Salary=42000},
                new Employee{ emp_Name="Raj",emp_Age=30,emp_Salary=44000},
                new Employee{ emp_Name="Ramesh",emp_Age=32,emp_Salary=65000},
                new Employee{ emp_Name="Minesh",emp_Age=38,emp_Salary=75000},
                new Employee{ emp_Name="Rushi",emp_Age=38,emp_Salary=80000},
            };


            foreach (var item in employees)
            {
                int total = employees.Sum(sal => sal.emp_Salary);
                int avg = total / 10;
                if (item.emp_Salary > avg)
                {
                    Console.Write("Employee Name is: " + item.emp_Name + "\tEmployee Salary: " + item.emp_Salary + "\tEmployee Age: " + item.emp_Age + "\n");
                }


            }
            Console.Read();

        }
    }
}
