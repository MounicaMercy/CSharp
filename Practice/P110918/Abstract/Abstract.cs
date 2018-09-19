using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110918.Abstract
{
    class Abstract
    {
        static void Main(string[] args)
        {
            SalesMan Sm = new SalesMan();
            Manager M = new Manager();
            Staff St = new Staff();
            Sm.GetSalesMan1Details();
            Console.WriteLine("Salary of SalesMan is {0}", Sm.GetSalary());
            M.GetManager1Details();
            Console.WriteLine("Salary of Manager is {0}", M.GetSalary());
            St.GetStaff1Details();
            Console.WriteLine("Salary of Staff is {0} with abstract method", St.GetSalary());
            Console.WriteLine("Salary of Staff is {0} with overriden method", St.GetStaffSalary());
            Console.Read();
            
        }
    }
}

