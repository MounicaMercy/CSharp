using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12092018.CustomException
{
    class CustomException
    {
        static void Main(string[] args)
        {
            SalesMan Sm = new SalesMan();
            Sm.Commision = 100;
            Sm.Salary = 1500;
            Sm.Bonus = 500;
            Sm.GetSalesMan1Details();
            Sm.GetBonus();
            Console.WriteLine("Salary of SalesMan is {0}", Sm.GetSalary());
            //Manager M = new Manager();
            //M.Salary = 2000;
            //M.Stock = 50;
            //M.GetManager1Details();
            //Console.WriteLine("Salary of Manager is {0}", M.GetSalary());
            //Staff St = new Staff();
            //St.GetStaff1Details();
            //St.Salary = 1000;
            
            //Console.WriteLine("Salary of Staff is {0} with abstract method", St.GetSalary());
            //Console.WriteLine("Salary of Staff is {0} with overriden method", St.GetStaffSalary());
            Console.Read();

        }
    }
}
    

