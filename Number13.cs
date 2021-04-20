using System;

namespace Assingment
{
    public class Number13
    {
        public static void Longest()
        {   
            string line = "I seek your refuge yaa Allah";

            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

            string Letter = "";

            int check = 0;

            foreach (String Land in words)
            {
                if (world.Length > check)
                {
                    Letter = Land;

                    check = Land.Length;
                }
            }
        
            Console.WriteLine(Letter);
        }
    }
}