using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A040918
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter something");
            var a = Console.ReadLine();

            Console.WriteLine("enter the data type you want to convert");
            string str = Console.ReadLine().ToLower();
            switch (str)
            {
                case "int":
                    int i = int.Parse(a);
                    Console.WriteLine("after conversion" + i);
                    break;
                case "float":
                    float f = Convert.ToSingle(a);
                    Console.WriteLine("after conversion" + f);
                    break;
                case "double":
                    double d;
                    Console.WriteLine(double.TryParse("23", out d));
                    Console.WriteLine("after conversion" + d);
                    break;
                case "bool":
                    bool b = Convert.ToBoolean(a);
                    Console.WriteLine("after conversion" + b);
                    break;
                case "string":
                    string s = Convert.ToString(a);
                    Console.WriteLine("after conversion" + s);
                    break;
                case "long":
                    long l = Convert.ToInt64(a);
                    Console.WriteLine("after conversion" + l);
                    break;
                case "char":
                    char c = Convert.ToChar(a);
                    Console.WriteLine("after conversion" + c);
                    break;


                default:
                    Console.WriteLine("not a valid datatype");
                    break;

            }
            Console.Read();
        }
    }
}
