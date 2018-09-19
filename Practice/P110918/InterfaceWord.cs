using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110918
{
        interface IEmployee
        {
            void GetTimeSheet();

        }
        interface IDetails
        {
            void GetDetails();
        }
        interface Details : IEmployee, IDetails
        {

        }

        class InterfaceWord
        {
            static void Main(string[] args)
            {
                SalesMan1 Sm = new SalesMan1();
                Sm.Commision = 100;
                Sm.Salary = 1500;
                Sm.GetDetails();
                Sm.GetSalesMan1Details();
                Sm.GetTimeSheet();
                Console.WriteLine("Salary of SalesMan is {0}", Sm.GetSalary());
                Manger1 M = new Manger1();
                M.Salary = 2000;
                M.Stock = 50;
                M.GetDetails();
                M.GetManager1Details();
                M.GetTimeSheet();
                Console.WriteLine("Salary of Manager is {0}", M.GetSalary());
                Staff1 St = new Staff1();
                St.GetStaff1Details();
                St.Salary = 1000;
                St.GetDetails();
                St.GetTimeSheet();
                Console.WriteLine("Salary of Staff is {0} with abstract method", St.GetSalary());
                Console.WriteLine("Salary of Staff is {0} with overriden method", St.GetStaffSalary());
                Console.Read();
            }
        }
    
        abstract class Employee1
        {
            public string Name;
            public int Id;
            public float Salary;
            public int Time;
            public abstract float GetSalary();
            public virtual float GetStaffSalary()
            {
                return Salary;
            }

        }
        class SalesMan1 : Employee1,IDetails
        {
            public int Commision;
            public string WorkingCity;
            public override float GetSalary()
            {
                return Salary + Commision;
            }
            public void GetSalesMan1Details()
            {
               
                Console.WriteLine("Enter Working City of SalesMan");
                WorkingCity = Console.ReadLine();

            }
            public void GetDetails()                //Implementing Methods of Interface
            {
            Console.Write("Enter Name of the SalesMan:");
            Name = Console.ReadLine();
            Console.Write("Id of the SalesMan:");
            Id = Int32.Parse(Console.ReadLine());
            }
            public void GetTimeSheet()       //Implementing Methods of Interface
            {
            Console.WriteLine("Enter the working time of Salesman");
            Time = Int32.Parse((Console.ReadLine()));
            }
        }
        class Manger1 : Employee1,IDetails
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
                
                Console.WriteLine("Enter Department of the Manager");
                HeadofDepartment = Console.ReadLine();

            }
            public void GetDetails()
            {
                Console.Write("Enter Name of the Manager:");
                Name = Console.ReadLine();
                Console.Write("Id of the Manager:");
                Id = Int32.Parse(Console.ReadLine());
            }
            public void GetTimeSheet()       //Implementing Methods of Interface
            {
            Console.WriteLine("Enter the working time of Manager");
            Time = Int32.Parse((Console.ReadLine()));
            }
        }
        class Staff1 : Employee1,IDetails
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

            }
            public void GetDetails()
            {
                Console.Write("Enter Name of the Manager:");
                Name = Console.ReadLine();
                Console.Write("Id of the Manager:");
                Id = Int32.Parse(Console.ReadLine());
            }
            public override float GetStaffSalary()
            {
                return Salary;
            }
            public void GetTimeSheet()       //Implementing Methods of Interface
            {
                Console.WriteLine("Enter the working time of Staff");
                Time = Int32.Parse((Console.ReadLine()));
            }

        }
}

