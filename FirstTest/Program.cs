// See https://aka.ms/new-console-template for more information

using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2 string op)
        {
            double result = double.NaN;
            switch (Console.ReadLine())
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            //Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

        }
    }
}





double num1 = 0; double num2 = 0;
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");
Console.WriteLine("Type a number and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type another number and then press Enter");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option?");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " +(num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = "+(num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        // Ask the user to enter a non-zero divisor until they do so.
        while (num2 == 0)
        {
            Console.WriteLine("Enter a non-zero divisor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
    default:
        break;
}

Console.Write("Press any key to close the calculator console app ...");
Console.ReadKey();