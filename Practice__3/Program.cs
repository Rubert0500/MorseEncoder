using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Practice__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the text that you want to translate to morse: ");
            string word = Console.ReadLine();
            word = word.ToLower();
            string outEncode = WordTranslate(word);
            outEncode = outEncode.Remove(outEncode.Length - 1);
            Console.Write($"{word} => ");
            foreach(var item in outEncode)
            {
                if (item == '.')
                    Console.Beep(400, 300);
                else if (item == '-')
                    Console.Beep(400, 600);
                Console.Write(item);
            }

        }
        private static string result = "";
        private static string WordTranslate(string evaluatedWord)
        {
            if(evaluatedWord != "")
            {
                if (evaluatedWord[0] != ' ')
                    result += $"{CharacterTranslate(evaluatedWord[0])}|";
                else
                    result += " ";
                evaluatedWord = evaluatedWord.Substring(1);
                WordTranslate(evaluatedWord);
            }
            else
            {
                return result;
            }
            return result;
        }

        private static string CharacterTranslate(char characterA)
        {
            switch (characterA)
            {
                case 'a':
                    return ".-";
                case 'b':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'd':
                    return "-..";
                case 'e':
                    return ".";
                case 'f':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'h':
                    return "....";
                case 'i':
                    return "..";
                case 'j':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'm':
                    return "--";
                case 'n':
                    return "-.";
                case 'o':
                    return "---";
                case 'p':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 's':
                    return "...";
                case 't':
                    return "-";
                case 'u':
                    return "..-";
                case 'v':
                    return "...-";
                case 'w':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'y':
                    return "-.--";
                case 'z':
                    return "--..";
                case '1':
                    return ". - - - -";
                case '2':
                    return ". . - - -";
                case '3':
                    return ". . . - -";
                case '4':
                    return ".... -";
                case '5':
                    return ". . . . .";
                case '6':
                    return "- . . . .";
                case '7':
                    return "- - . . .";
                case '8':
                    return "- - - . .";
                case '9':
                    return "- - - - .";
                case '0':
                    return "- - - - -";
                default:
                    return "";
            }

        }

    }
}
