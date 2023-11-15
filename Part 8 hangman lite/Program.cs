using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_hangman_lite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random generator = new Random();
            Console.WriteLine("Welcome to hangman lite.");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("1. Try to guess the letters in the mystery word.");
            Console.WriteLine("2. Getting letters wrong results in another section of the man being hung.");
            Console.WriteLine("3. Once the man is fully hung, you lose.");
            Console.WriteLine("4. If you get all the letters right before the man dies, you win.");
            Console.WriteLine("Good luck.");
            Word(generator.Next(1, 7));
        }
        public static void Word(int word1)
        {
            string word = "COMPUTER";
            string displayWord = "________";
            string lettersGuessed = "";
            int incorrect = 0;
            bool done = false;
            while (!done)
            {
                Console.WriteLine(lettersGuessed);
                Hung(incorrect);
                Console.WriteLine(displayWord);
                Console.WriteLine($"You have {3 - incorrect} guesses left");
                Console.Write("Please input your guess: ");
                string guess = Console.ReadLine().ToUpper();
                if (word.Contains(guess))
                {
                    Console.WriteLine("Yep");
                }
                else if (!word.Contains(guess))
                {
                    Console.WriteLine("Nope");
                }
            }
        }
        public static void Hung(int hung)
        {
            if (hung == 0)
            {
                Console.WriteLine(" +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("      /|\\");
                Console.WriteLine("=========");
            }
            else if (hung == 1)
            {
                Console.WriteLine(" +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("       |");
                Console.WriteLine("       |");
                Console.WriteLine("      /|\\");
                Console.WriteLine("=========");
            }
            else if (hung == 2)
            {
                Console.WriteLine(" +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("       |");
                Console.WriteLine("      /|\\");
                Console.WriteLine("=========");
            }
            else if (hung == 3)
            {
                Console.WriteLine(" +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" O     |");
                Console.WriteLine("/|\\    |");
                Console.WriteLine("/ \\    |");
                Console.WriteLine("      /|\\");
                Console.WriteLine("=========");
            }
            else
            {
                Console.WriteLine(" +-----+");
                Console.WriteLine(" |     |");
                Console.WriteLine(" ?     |");
                Console.WriteLine("???    |");
                Console.WriteLine("? ?    |");
                Console.WriteLine("      /|\\");
                Console.WriteLine("=========");
            }
        }
    }
}
