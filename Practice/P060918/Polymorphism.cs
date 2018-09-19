using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P060918
{
    public class Polymorphism
    {
        static void Main(string[] args)
        {
            Sample2 obj = new Sample2();

            obj.display("George");

            obj.display(34, 76.50f);

            Console.ReadLine();
        }
    }


    public class Sample2
    {
        public void display(string name)
        {
             Console.WriteLine("Your name is : " + name);
        }

        public void display(int age, float marks)
        {   
            Console.WriteLine("Your age is : " + age);
            Console.WriteLine("Your marks are :" + marks);
        }

    }  
}
