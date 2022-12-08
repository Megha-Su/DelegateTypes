using System;

namespace PredicateDelegate
{
    class Program
    {
        static void inputChar(Predicate<char>vowel)
        {
            Console.WriteLine(vowel('a'));
            Console.WriteLine(vowel('B'));
            Console.WriteLine(vowel('h'));
            Console.WriteLine(vowel('U'));

        }
        static void Main(string[] args)
        {
            var textinput = new Predicate<char>(IsVowel);
            inputChar(textinput);


        }
        static bool IsVoweljhuyihy(char input)
        {
            bool isVowel = false;
            switch (char.ToLower(input))
            {

                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    isVowel = true;
                    break;
                default:
                    break;
                    
            }
            if (isVowel)
            {
                return true;
            }
            return false;
        }

    }
}
