using System;
using System.CodeDom.Compiler;
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
            Console.WriteLine("Welcome to hangman lite.");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("1. Try to guess the letters in the mystery word.");
            Console.WriteLine("2. Getting letters wrong results in another section of the man being hung.");
            Console.WriteLine("3. Once the man is fully hung, you lose.");
            Console.WriteLine("4. If you get all the letters right before the man dies, you win.");
            Console.WriteLine("Good luck.");
            Word();
        }
        public static void Word()
        {
            Random generator = new Random();
            int rndmWrd = generator.Next(2, 3);
            string word = "";
            string displayWord = "";
            if (rndmWrd == 1)
            {
                word = word.Insert(0, "COMPUTER");
                displayWord = displayWord.Insert(0, "________");
            }
            else if (rndmWrd == 2)
            {
                word = word.Insert(0, "PRETZELS");
                displayWord = displayWord.Insert(0, "________");
            }
            string lettersGuessed = "";
            string rightGuesses = "";
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

                //2+
                if (guess.Count() > 1)
                {
                    Console.WriteLine("You're only allowed to input one letter.");
                }
                //2+
                
                //Numbers
                else if (guess.Contains("1") || guess.Contains("2") || guess.Contains("3") || guess.Contains("4") || guess.Contains("5") || guess.Contains("6") || guess.Contains("7") || guess.Contains("8") || guess.Contains("9") || guess.Contains("0"))
                {
                    Console.WriteLine("You're only allowed to input letters.");
                }
                //Numbers

                //1
                else if (guess.Count() == 1)
                {
                    //Right
                    if (word.Contains(guess))
                    {
                        Console.WriteLine("Yep");
                        if (rightGuesses.Contains(guess))
                        {
                            Console.WriteLine("You've already got this letter.");
                        }
                        else if (!rightGuesses.Contains(guess))
                        {
                            rightGuesses = rightGuesses + guess;
                            foreach (guess in displayWord)
                            {
                                displayWord = displayWord.Insert(word.IndexOf(guess), guess);
                                displayWord = displayWord.Remove((word.IndexOf(guess) + 1), 1);
                            }
                            if (displayWord == word)
                            {
                                Console.WriteLine(displayWord);
                                Console.WriteLine("You win!");
                                done = true;
                            }
                        }
                    }
                    //Right

                    //Wrong
                    else if (!word.Contains(guess))
                    {
                        Console.WriteLine("Nope");
                        if (lettersGuessed.Contains(guess))
                        {
                            Console.WriteLine("You've already guessed this.");
                        }
                        else if (!lettersGuessed.Contains(guess))
                        {
                            lettersGuessed = lettersGuessed + guess;
                            incorrect++;
                            if (incorrect == 3)
                            {
                                Console.WriteLine(lettersGuessed);
                                Hung(incorrect);
                                Console.WriteLine("You lose!");
                                done = true;
                                Console.Beep(750, 200);
                                Console.Beep(500, 200);
                                Console.Beep(250, 200);
                            }
                        }
                    }
                    //Wrong
                }
                //1
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
