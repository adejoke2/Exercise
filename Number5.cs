using System;

namespace Assingment
{
    public class Number5
    {
        public static void Reverse()
        {
            Console.Write("Enter a word:  ");
            string word = Console.Readline();

            string reverseWord = string.Join("", word.Split(' ').select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine($"Reverse Word  : {reverseWord}");
        }
    }
}