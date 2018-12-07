using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();//this is to keep the window up and running.
        }
        void Start()
        {
            Console.WriteLine("Enter a word(to search): ");
            string word = Console.ReadLine();
            WordInLine(word);
        }
        bool WordInLine(string line, string word)//question A
        {
            //if the word exist
        }
    }
}
