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
            hangman.Init("backdoor");
            //this is to see if the words are being displayed.
            //Console.WriteLine("the secret word is: " + hangman.secretWord);
            //Console.WriteLine("the guessed word is: " + hangman.guessedWord);
            if(PlayHangman(hangman))
            {
                Console.WriteLine("You guessed the word!!");
            }
            else
            {
                Console.WriteLine("You run out of attempts");
            }
            
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
            List<char> enteredLetters = new List<char>();
            DisplayWord(hangman.guessedWord);//from question
            int attempts = 8; //starting amount of attempts for guessing
            Console.WriteLine();//for spacing

            //this is for the attepts and askng for the letters
            while(!hangman.isGuessed() && attempts > 1) //if the word is not guess and the nr of attempts are more than one.
            {
                char letter = ReadLetter(enteredLetters);

                if (!hangman.GuessLetter(letter))//of the letter is not in the word, lose 1 attempts.
                {
                    attempts--;
                }
                Console.Write("Entered letters: ");
                DisplayLetters(enteredLetters);

                Console.WriteLine();//for the spacings

                Console.WriteLine("Attempts left: " + attempts);
                DisplayWord(hangman.guessedWord);
                Console.WriteLine();
            }
            return hangman.isGuessed();
        }
        void DisplayWord(string word)
        {
            string newsecret = " "; // this is an empty string.
            foreach(char c in word)
            {
                newsecret = newsecret + c + " ";//this is for spacing.
            }
            Console.WriteLine("The secret word is: " + newsecret);
        }
        void DisplayLetters(List<char> letters) //this is for spacing the letters that has been used to guess.
        {
            foreach(char c in letters)
            {
                Console.Write(c + " ");
            }
        }
        char ReadLetter(List<char> blacklistLetters)
        {
            Console.Write("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());
            while(blacklistLetters.Contains(letter))
            {
                Console.Write("Enter a letter: ");
                letter = char.Parse(Console.ReadLine());
            }
            blacklistLetters.Add(letter);
            return letter;
        }
    }
}
