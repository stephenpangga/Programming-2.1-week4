using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment03
{
    class Program03
    {
        static void Main(string[] args)
        {
            Program03 myProgram = new Program03();
            myProgram.Start();
            Console.ReadKey();//this is to keep the window up and running.
        }
        void Start()
        {
            string searchword = ReadString("Enter a wordv(to search)): ");//input

            SearchWordOnFile("tweets-donaldtrump.txt", searchword);
        }
        bool WordInLine(string line, string word)//question A
        {
            //if(MyString.Equal(YourString, StringComparison.OrdinalIgnoreCase))//need to fix this
            if(line.Contains(word))//need to find a way to make this case sensitive
            {
               return true;
            }
            return false;
        }
        void SearchWordOnFile(string filename, string word)//question B
        {
            //from lecture presentation
            StreamReader reader = new StreamReader(filename);//openning the file 
            int found = 0;
            while(!reader.EndOfStream)//display all the lines on screen
            {
                string s = reader.ReadLine(); //read 1 line from the file.
                if(WordInLine(s,word))
                {
                    found++;
                    //Console.WriteLine(s);
                    DisplayWordInLine(s, word);
                }
                //Console.WriteLine(s);
            }
            reader.Close();//to close the file.
            //return found;
        }
        void DisplayWordInLine(string line, string word)//this is to color the searchword based on assignment 1 from week 3
        {
            //the display output color difference
            int begin = line.IndexOf(word);
            string before  = line.Substring(0, begin);
            Console.Write(before);//normal color to start with.
            string coloredword = line.Substring(begin, word.Length);
            Console.ForegroundColor = ConsoleColor.Red;//turn the word to red
            Console.Write(coloredword);//this will be red since its after the foreground color
            string after = line.Substring(begin + word.Length);
            //this will reset the color
            Console.ResetColor();
            Console.Write(after);
        }
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
