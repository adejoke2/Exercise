using System;

namespace Assingment
{
    public class Number19
    {
        public static void Main()
        {
            int[] nums = { 2, 4, 7, 8, 5, 6 };

            Console.WriteLine("Does it have an odd number? " + Odd(nums));
        }

        public static bool Odd(int[] nums)
        {
            foreach (var number in nums)
            {
                if (number % 2 != 0)
                    return true;
            }
            return false;

        }
    }
}