using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P120918.TryCatch
{
    class TryCatchWord2
    {
        public void Sample1()
        {
            try
            {
                Console.Write("Please enter number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Please enter number: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch (DivideByZeroException ex)
            {
                //LogError(ex);
                //throw new Exception("Cannot Divide By Zero", ex); //creating a new exception object
               // throw; //Just throwing the present exception
               //throw ex; //just throwing the present exception
                Console.Write("Cannot divide by zero. Please try again.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {

                Console.Write("Not a valid number. Please try again.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            Console.ReadLine();
        }
    }
}
