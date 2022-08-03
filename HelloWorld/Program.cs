using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static int PartiallyTestedCode(int x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return x * -1;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
