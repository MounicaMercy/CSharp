using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110918.Abstract
{
    abstract class Employee
    {
        
            public string Name;
            public int Id;
            public float Salary;
            public abstract float GetSalary();
            public virtual float GetStaffSalary()
            {
                return Salary;
            }

    }
}
