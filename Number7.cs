using System;

namespace Assingment
{
    public class Number7
    {
        public static void Array()
        {

            Console.Write("Enter first number:  ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:  ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int total = number1 + number2;
            Console.WriteLine(total);      
        }
       
    }
}