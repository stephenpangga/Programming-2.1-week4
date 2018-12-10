using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program02
    {
        static void Main(string[] args)
        {
            Program02 myProgram = new Program02();
            myProgram.Start();
            Console.ReadKey();//this is to keep the window up and running.
        }
        void Start()
        {
            List<string> words = new List<string>();
            words = ListOfWords();
            HangmanGame hangman = new HangmanGame();
            hangman.Init(SelectWord(words));
            Console.WriteLine("the secret word is: " + hangman.secretWord);
            Console.WriteLine("the guessed word is: " + hangman.guessedWord);
        }
        List<string> ListOfWords()
        {
            List<string> Lwords = new List<string>();
            Lwords.Add("Programming");
            Lwords.Add("Modelling");
            Lwords.Add("WebDesign");
            return Lwords;
        }
        string SelectWord(List<string> words)
        {
            Random rnd = new Random();//random number generator
            int values = rnd.Next(0, 2);
            string randomWords = words.ElementAt(values);//setting number to the random numbers from 1-3
            return randomWords;
        }
        bool PlayHangman(HangmanGame hangman)
        {

        }
    }
}
