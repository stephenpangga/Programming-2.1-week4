using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment04
{
    class Program04
    {
        static void Main(string[] args)
        {
            Program04 myProgram = new Program04();
            myProgram.Start();
            Console.ReadKey();//this is to keep the window up and running.
        }
        void Start()
        {
            RegularCandies[,] playingField = new RegularCandies[10, 10];//question B
            InitCandies(playingField);
            DisplayCandies(playingField);
            
            //for the different display
            bool scorerow = ScoreRowPresent(playingField);
            bool scorecolumn = ScoreColumnnPresent(playingField);

            //this is for the different display, got help from jurek
            if (scorerow)
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }
            if (scorecolumn)
            {
                Console.WriteLine("column score");
            }
            else
            {
                Console.WriteLine("no column score");
            }
            //assignment 4, week 4.
            WritePlayingField(playingField, "candycrush.txt");
        }
        void InitCandies(RegularCandies[,] matrix)// question C
        {
            Random rnd = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = (RegularCandies)rnd.Next(1, 7);//to fix this one, dont know what im doing wrong.
                }
                //Console.WriteLine();
            }
        }
        void DisplayCandies(RegularCandies[,] matrix)//question D // could make an array for this  but i like "if"
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    //this is for the different colors of #
                    RegularCandies name = matrix[row, column];
                    switch (name)//peter's suggestion
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.Gum_Square:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case RegularCandies.Jujube_Cluster:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                    }
                    Console.Write(" #");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        bool ScoreRowPresent(RegularCandies[,] matrix)//question E 
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                RegularCandies MainCandy = RegularCandies.JellyBean; //variable not sure..
                int count = 1;//this is for the counter if there is a row found.
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (row + column != 0)
                    {
                        if (MainCandy == matrix[row, column])
                        {
                            count++;
                        }
                        else// this doesnt make sense, i need to understand and see how this works shown by jurek
                        {
                            count = 1;
                        }
                        if (count >= 3)
                        {
                            // Console.WriteLine("row score");
                            return true;
                        }
                    }
                    MainCandy = matrix[row, column];// i need some explanation for this
                }
            }
            //Console.WriteLine("no row score")
            return false;
        }
        bool ScoreColumnnPresent(RegularCandies[,] matrix)// i need to try and make foreach version of this
        {
            RegularCandies MainCandy = RegularCandies.JellyBean; //variable not sure..
            int count = 1;//this is for the counter if there is a row found.
            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (row + column != 0)
                    {
                        if (matrix[row, column] == MainCandy)
                        {
                            count++;
                        }
                        else if (count >= 3)
                        {
                            //Console.WriteLine("column score")
                            return true;
                        }
                        else// this doesnt make sense, i need to understand and see how this works, shown by jurek
                        {
                            count = 1;
                        }

                    }
                    MainCandy = matrix[row, column];// i need some explanation for this
                }
            }
            //Console.WriteLine("no colunn score")
            return false;
        }
        //week 4 assignments
        void WritePlayingField(RegularCandies[,] playingField, string filename)
        {
            //to write things in txt
            StreamWriter writer = new StreamWriter(filename);
            string s="";//not sure if supposed to be empty or Console.ReadLine();
            //the code for the row
            for (int i =0; i < playingField.GetLength(0); i++)//row
            {
                s = ""; //to make it look nicer?
                for(int j=0; j<playingField.GetLength(1); j++)//column
                {
                    s += (int)playingField[i, j] + " ";
                }
                writer.WriteLine(s);
            }
            writer.Close();
        }
        /*RegularCandies[,] ReadPlayingField(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            while(!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                string[]field = s.Split();
            }
            reader.Close();
            for
        }*/
    }
}
