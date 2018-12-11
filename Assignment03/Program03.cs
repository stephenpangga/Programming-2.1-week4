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
            
        }
        bool WordInLine(string line, string word)//question A
        {
            if(MyString.Equal(YourString, StringComparison.OrdinalIgnoreCase))
            {
               return true;
            }
            return false;
        }
        int SearchWordOnFile(string filename, string word)
        {
            StreamReader reader = new StreamReader(filename);//openning the file 
            int nrtimesfound = 0;
            while(!reader.EndOfStream)//display all the lines on screen
            {
                string s = reader.ReadLine(); //read 1 line from the file.
                Console.WriteLine(s);
            }

        }
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
