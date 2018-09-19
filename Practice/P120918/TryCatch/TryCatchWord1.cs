using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P120918.TryCatch
{
    class TryCatchWord1
    {
        public static void Main(string[] args)
        {
            TryCatchWord2 c = new TryCatchWord2();
            try
            {
                c.Sample1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

    }
}

