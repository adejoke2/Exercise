using System;

namespace Assingment
{
    public class Number2
    {
        public static void Swap()
        {

            int number1;
            int number2;
            int number;

            Console.WriteLine("Enter your first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            number2 = int.Parse(Console.ReadLine());

            number = number1;
            number1 = number2;
            number2 = number;

            Console.WriteLine("First Number: " + number1);
            Console.WriteLine("Second Number: " + number2);
        }
    }
}