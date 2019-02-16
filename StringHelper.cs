using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            int i;
            int j = 0;
            for (i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                {
                    if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))
                    {
                        j++;
                    }
                }
            }
            return j;
            throw new NotImplementedException();
        }

        public static void Main()
        {
            Console.WriteLine("Enter a string: \n");
            string exp = Console.ReadLine();
            var result = GetVowelCount(exp);
            Console.WriteLine($"Your result is: {result} vowels");
        }
    }
}
