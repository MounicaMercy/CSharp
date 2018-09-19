using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P060918
{
    class Constructor
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.print();
            Sample s1 = new Sample(10, 20);
            s1.print();
            Sample s2 = new Sample("hello");
            s2.printstring();
            Console.Read();
        }
    }
    class Sample
    {
        int x;
        int y;
        string p;
        public Sample()
        {
            x = 100;
            y = 200;

        }
        public Sample(int a, int b)
        {
            x = a;
            y = b;

        }
        public Sample(string a)
        {
            p = a;
        }

        public void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void printstring()
        {
            Console.WriteLine(p);
        }
    }
}
