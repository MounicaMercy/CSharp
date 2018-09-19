using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110918.Abstract
{
    class SalesMan: Employee
    {
        public int Commision;
        public string WorkingCity;
        public override float GetSalary()
        {
            return Salary + Commision;
        }
        public void GetSalesMan1Details()
        {
            Console.Write("Enter Name of the SalesMan:");
            Name = Console.ReadLine();
            Console.Write("Id of the SalesMan:");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Working City of SalesMan");
            WorkingCity = Console.ReadLine();
            Console.WriteLine("Enter the commision");
            Commision = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Salary");
            Salary = int.Parse(Console.ReadLine());
        }
    }
}
