using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12092018.CustomException
{
    class SalesMan: Employee
    {
         public int Commision;
         public string WorkingCity;
         public void GetBonus()
        {
            try
            {
                if (Salary == 0)
                {
                    throw new CustomExceptions("Salary is not yet assigned");
                }
                else if ((Salary * 10) / 100 > Bonus)
                {
                    throw new CustomExceptions("Bonus is not applicable");
                }
                else
                {
                    Salary = Salary + Bonus;

                }
            }
            catch(CustomExceptions ce)
            {
                Console.WriteLine(ce.Message);
            }
            
        }
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
            Console.WriteLine("Enter the bonus provided");
            Bonus = int.Parse(Console.ReadLine());

       }
     }
}
