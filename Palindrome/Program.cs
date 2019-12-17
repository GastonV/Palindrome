using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Program();
            Console.WriteLine(item.checkPalind("state"));
            Console.WriteLine(item.checkPalind("animal"));
            Console.WriteLine(item.checkPalind("tirrit"));
            Console.WriteLine(item.checkPalind("lamina"));
            Console.WriteLine(item.checkPalind("etats"));
            Console.WriteLine(item.checkPalind("a"));
            Console.ReadLine();

        }

        public bool checkPalind(string palind)
        {
            int length = palind.Length;
            //split the word and comapre from bothe sides each letter
            for (int i = 0; i < length / 2; i++)
            {
                if (palind[i] != palind[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
