using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A040918
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Identity Matrix:");
            int size = int.Parse(Console.ReadLine());

            

            for (int i = 0; i <size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    
                }
                Console.WriteLine();


            }

            Console.ReadKey();
        }
    }
}
    