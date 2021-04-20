using System;


namespace Assingment
{
        public class Number16
        {
        public static void Daski()
       {
        Console.Write("Input a string : ");
        string str = Console.ReadLine();
   
        Console.WriteLine(test(str));
       }
       public static bool test(string str)
       {
        var put = 0;
        
        for (var i = 0; i < str.Length - 1; i++)
        {
          if (str[i].Equals('x')) put++;

          if (str.Substring(i, 2).Equals("x") && put > 2)
            return true;
        }
          return false;
       }

    }
}