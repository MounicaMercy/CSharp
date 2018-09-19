using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12092018.CustomException
{
    abstract class Employee
    {
        public string Name;
        public int Id;
        public float Salary;
        public int Bonus;
        public abstract float GetSalary();
        public virtual float GetStaffSalary()
        {
          return Salary;
        }
    }
}
