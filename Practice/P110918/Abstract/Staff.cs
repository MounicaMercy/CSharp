using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110918.Abstract
{
    class Staff: Employee
    {
        public string Department;
        public override float GetSalary()
        {
            //throw new NotImplementedException();
            return Salary;
        }
        public void GetStaff1Details()
        {
            Console.Write("Enter Name of the Staff:");
            Name = Console.ReadLine();
            Console.Write("Id of the Staff:");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department of the Staff");
            Department = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            Salary = int.Parse(Console.ReadLine());

        }
        public override float GetStaffSalary()
        {
            return Salary;
        }
    }
}
