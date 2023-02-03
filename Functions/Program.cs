using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int sum = 0;
            int square = 0;

            sum = Add(a, b);
            square = SquareNumber(a);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Square of number A = {0}", square);

            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int SquareNumber(int x)
        {
            return x * x;
        }
    }
}
