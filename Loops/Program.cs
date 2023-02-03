using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double count = 0;

            while (count != 10)
            {
                sum = sum + Math.Pow(count, 2.0f);
                Console.WriteLine("Count: {0}     Sum: {1}", count, sum);
                count++;
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 > 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
    }
}
