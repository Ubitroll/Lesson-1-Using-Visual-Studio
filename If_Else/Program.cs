﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber= Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is larger than second number");
            }
            else if(secondNumber == firstNumber)
            {
                Console.WriteLine("First number is equal to second number");
            }
            else
            {
                Console.WriteLine("Second number is larger than first number");
            }
            Console.ReadLine();
        }
    }
}