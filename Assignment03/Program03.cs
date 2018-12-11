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
                    Console.WriteLine(s);
                }
                //Console.WriteLine(s);
            }
            reader.Close();//to close the file.
            //return found;
        }
        void DisplayWordInLine(string line, string word)
        {
            int begin = line.IndexOf(word);

        }
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
