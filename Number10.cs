using System;

namespace Assingment
{
    public class Number10
    {
     public static void Main(string[] args)
       {
            Console.WriteLine(Number("Habeebah"));
        }
        public static string Number(string name)
        {
            return name.Length > 1;

            if(name.Substring(nameLength - 1))
            {
              name.Substring(1, name.Length - 2) + name.Substring(0,1);
            }else
            {
                Console.WriteLine(name);
            }
        }
    }
}