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
            Word(generator.Next(1, 7));
        }
        public static void Word(int word1)
        {
            string word2;
            string incrct = "";
            string blank;
            int wrong = 0;
            int right = 0;
            int word3;
            bool done = false;
            while (!done)
            {
                Console.WriteLine(incrct);
                Hung(wrong);
                if (word1 == 1)
                {
                    word3 = 1;
                    word2 = "I" + "T" + "A" + "L" + "Y";
                    blank = ("_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 5));
                }
                else if (word1 == 2)
                {
                    word2 = "K" + "E" + "N" + "Y" + "A";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 7));
                }
                else if (word1 == 3)
                {
                    word2 = "B" + "R" + "A" + "Z" + "I" + "L";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 6));
                }
                else if (word1 == 4)
                {
                    word2 = "C" + "U" + "B" + "A";
                    blank = ("_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 4));
                }
                else if (word1 == 5)
                {
                    word2 = "S" + "P" + "A" + "I" + "N";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 8));
                }
                else if (word1 == 7)
                {
                    word2 = "U" + "K" + "R" + "A" + "I" + "N" + "E";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 7));
                }
                else if (word1 == 6)
                {
                    word2 = "U" + "Z" + "B" + "E" + "K" + "I" + "S" + "T" + "A" + "N";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 10));
                }
                else if (word1 == 8)
                {
                    word2 = "G" + "U" + "I" + "N" + "E" + "A";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 6));
                }
                else if (word1 == 9)
                {
                    word2 = "P" + "O" + "R" + "T" + "U" + "G" + "A" + "L";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 8));
                }
                else if (word1 == 10)
                {
                    word2 = "N" + "O" + "R" + "W" + "A" + "Y";
                    blank = ("_" + "_" + "_" + "_" + "_" + "_");
                    Console.WriteLine(blank.Substring(0, 6));
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
                Console.Write("What letter would you like to guess? ");
                string guess = Console.ReadLine().ToUpper();
                List <string> answer = new List<string>();
                if (answer.Contains(guess))
                {
                    Console.Beep(2000, 300);
                    right = right + 1;
                    if (right == answer.Count + 1)
                    {
                        done = true;
                    }
                }
                else if (!answer.Contains(guess))
                {
                    Console.Beep(1000, 300);
                    Console.WriteLine("Incorrect guess");
                    if (incrct.Contains(guess))
                    {
                        Console.WriteLine("You've already guessed this!");
                    }
                    else if (!incrct.Contains(guess))
                    {
                        incrct = incrct + guess;
                        wrong = wrong + 1;
                        if (wrong == 3)
                        {
                            Hung(wrong);
                            Console.WriteLine("YOU LOSE!");
                            Console.WriteLine();
                            done = true;
                        }
                    }
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
