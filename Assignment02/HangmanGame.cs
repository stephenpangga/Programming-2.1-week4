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
    }
}
