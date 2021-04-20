using System;

namespace Assingment
{
    public class Num20
    {
        public static void Century()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int total = year / 100 + 1;

             Console.WriteLine(total);
        }
    }
}