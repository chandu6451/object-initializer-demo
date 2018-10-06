using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializerDemo
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.EmpID = 101;
            //emp.EmpName = "Robert";
            //emp.Salary = 20000;

            Employee emp = new Employee() { EmpID = 101, EmpName = "Robert", Salary = 20000 };
            Console.WriteLine("Employee ID : " + emp.EmpID);
            Console.WriteLine("Employee Name : " + emp.EmpName);
            Console.WriteLine("Salary : " + emp.Salary);

            Console.ReadKey();

        }
    }
}
