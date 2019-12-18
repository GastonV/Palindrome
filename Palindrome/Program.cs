using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Program();
            String[] arr_palindrom = { "state", "animal", "tirrit", "etats", "a" };

            foreach (var pali in arr_palindrom)
            {
                Console.WriteLine(item.checkPalind(pali));
            }
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
