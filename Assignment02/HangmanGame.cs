using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class HangmanGame
    {
        public string secretWord;
        public string guessedWord;
        public void Init(string secretWord)
        {
            foreach(char letter in secretWord)
            {
                this.secretWord = secretWord;//just to show the word according to jurek.
                guessedWord += ".";
            }
        }
        public bool GuessLetter(char letter)
        {
            bool match = false;
            StringBuilder newguessletter = new StringBuilder(guessedWord);//converted from the internet
            for(int i = 0; i < secretWord.Length; i++)
            {
                if(secretWord[i] == letter)
                {
                    newguessletter[i] = letter;//to see if the letter is the same as the letters in the word.
                    match = true;
                }
            }
            guessedWord = newguessletter.ToString();
            return match;
        }
        public bool isGuessed()
        {
            bool correct = false;
            if(guessedWord == secretWord)
            {
                correct = true;
            }
            return correct;
        }
    }
}
