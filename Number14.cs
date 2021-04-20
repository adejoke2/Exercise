 using System;

 namespace Assingment
 {
     public class Number14
     {
        public static void Remainder()
         {             
           Console.WriteLine("Input first integer:");  

           int x = Convert.ToInt32(Console.ReadLine());

           if (x > 0)
           {
              Console.WriteLine(x % 3 == 0 || x % 7 == 0);
           }
         }
     }
 }