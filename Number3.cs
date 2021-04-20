using System;

namespace Assingment
{
    public class Number3
    {
        public static void Adding()
        {
            int num;
            Console.WriteLine("Enter any value");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", num, i, num*i);
            }
       }
        
    }
}