using System;

namespace Assingment
{
    public class Number1
    {
        public static void Devision()
        {
            Console.WriteLine("Enter your number");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Arthmetic Operator ");
            string value = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            double number2 = Convert.ToInt32(Console.ReadLine());

            if (value == "/")
            {
            Console.WriteLine(number1 / number2);
            }
            else
            {
            Console.WriteLine("invalid input");
            }
        }


    }
}