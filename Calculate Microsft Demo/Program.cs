//Made by Daniel Alexandre 2021
//created by following microsoft guide and my own inputs for learnig purpose.
using System;

namespace Calculate_Microsft_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
           
            //\r starts a new line
            Console.WriteLine(" Simple Calculator in C#\r" );
            Console.WriteLine ( "--------------------------");
            Console.WriteLine("Type a nummber and press enter");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Type anohter nummber and press enter");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose a option in the list");
            // \t adds a tab in the tex
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");


            //meny for calculation, $ makes {num} visabel in text
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Resultat: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Resultat: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Resultat: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Resultat: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.WriteLine("press any key to quit");
            Console.ReadKey();






        }
    }
}
    