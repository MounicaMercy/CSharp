﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12092018.CustomException
{
    class Manager: Employee
    {
        public int Stock;
        public string HeadofDepartment;
        public override float GetSalary()
            {
                //throw new NotImplementedException();
                return Salary + (Stock * 100);
            }
        public void GetManager1Details()
            {
                Console.Write("Enter Name of the Manager:");
                Name = Console.ReadLine();
                Console.Write("Id of the Manager:");
                Id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Department of the Manager");
                HeadofDepartment = Console.ReadLine();

            }
        
    }
}
