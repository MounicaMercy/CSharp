using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P060918
{
    class StaticWord
    {
        static void Main(string[] args)
        {
            {
                Sample1.display();

                Console.ReadLine();
            }
        }
    }
    public class Sample1
    {
        static string name;  //Static variables
        static int age;

        static Sample1()                    //Staic Constructror
        {
            Console.WriteLine("Initialized Variables ");
            name = "John Sena";
            age = 23;
        }
        public static void display()
        {

            Console.WriteLine("Using static function, printing name and age");
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

    }
}
