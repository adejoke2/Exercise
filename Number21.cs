using System;

namespace Assingment
{
    public class Number21
    {
        public static void Sort(){
            int[] numbers = { 4, 3, 0, 4, 6, 2, 3 };

            Array.Sort(numbers);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}