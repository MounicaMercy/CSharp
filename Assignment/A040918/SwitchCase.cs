using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A040918
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
         

            string op;
            string flag=string.Empty;
            do
            {
                Console.WriteLine("Enter a Operator..");
                op = Console.ReadLine();
                switch (op)
                {
                    case "=":
                        Console.WriteLine("{0} is an Assignment Operator", op);
                        break;
                    case "+":
                        
                    case "-":
                       
                    case "*":
                        
                    case "/":
                        
                    case "%":
                        Console.WriteLine("{0} is an Arithmetic Operator", op);
                        break;
                    case ">":
                        
                    case "<":
                        
                    case ">=":
                        
                    case "<=":
                        
                    case "!=":
                        Console.WriteLine("{0} is an Relational Operator", op);
                        break;
                    case "&&":
                        
                        
                    case "||":
                        Console.WriteLine("{0} is an Logical Operator", op);
                        break;
                    case "++":
                        Console.WriteLine("{0} is an Increment Operator", op);
                        break;
                    case "--":
                        Console.WriteLine("{0} is an Decrement Operator", op);
                        break;
                    case "!":
                        Console.WriteLine("{0} is an Unary Operator", op);
                        break;
                    case "?:":
                        Console.WriteLine("{0} is an Ternary Operator", op);
                        break;
                    default:
                        Console.WriteLine("Enter a single character operator.. and it should be a operator!");
                        break;

                }
              Console.WriteLine("Do you want to continue- Yes or No?");
                flag = Console.ReadLine();
                    

            } while (flag.ToUpper()!="NO");
            Console.WriteLine("Thank you");
            
            Console.ReadLine();
        }
    }
}
