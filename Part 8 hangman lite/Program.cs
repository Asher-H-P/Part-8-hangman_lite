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
            int hung = 0;
            Word(generator.Next(1, 11));
        }
        public static void Word(int word1)
        {
            List <string> word2 = new List<string>();
            List <string> blank = new List<string>();
            if (word1 == 1)
            {
                word2.Add("ITALY");
                blank.Add("_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 2)
            {
                word2.Add("KENYA");
                blank.Add("_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 3)
            {
                word2.Add("BRAZIL");
                blank.Add("_" + "_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 4)
            {
                word2.Add("CUBA");
                blank.Add("_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 5)
            {
                word2.Add("SPAIN");
                blank.Add("_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 6)
            {
                word2.Add("UKRAINE");
                blank.Add("_" + "_" + "_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 7)
            {
                word2.Add("UZBEKISTAN");
                blank.Add("_" + "_" + "_" + "_" + "_" + "_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 8)
            {
                word2.Add("GUINEA");
                blank.Add("_" + "_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 9)
            {
                word2.Add("PORTUGAL");
                blank.Add("_" + "_" + "_" + "_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else if (word1 == 10)
            {
                word2.Add("NORWAY");
                blank.Add("_" + "_" + "_" + "_" + "_" + "_");
                Console.WriteLine(blank);
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }
        public static void Hung()
        {

        }
    }
}
