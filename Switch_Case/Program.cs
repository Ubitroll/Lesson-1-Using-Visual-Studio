using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("Enter a positive number: ");
            x = Convert.ToInt16(Console.ReadLine());

            if(x >= 0)
            {
                switch(x)
                {
                    case 0:
                        Console.WriteLine("The value you gave is 0");
                        break;
                    case 1:
                        Console.WriteLine("The value you gave is 1");
                        break;
                    case 2:
                        Console.WriteLine("The value you gave is 2");
                        break;
                    case 3:
                        Console.WriteLine("The value you gave is 3");
                        break;
                    case 4:
                        Console.WriteLine("The value you gave is 4");
                        break;
                    case 5:
                        Console.WriteLine("The value you gave is 5");
                        break;
                    default:
                        Console.WriteLine("The value is greater than 5");
                        break;
                }    
            }
            else
            {
                Console.WriteLine("Negative numbers are not allowed");
            }

            Console.ReadLine();

        }
    }
}