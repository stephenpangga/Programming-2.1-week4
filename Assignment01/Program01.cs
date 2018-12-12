    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment01
{
    class Program01
    {
        static void Main(string[] args)
        {
            Program01 myProgram = new Program01();
            myProgram.Start();
            Console.ReadKey();//this is to keep the window up and running.
        }
        void Start()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (File.Exists(name+".txt"))
            {
                Console.WriteLine($"Nice to see you again, {name}!");
                Console.WriteLine($"we have the following information about you: ");
                Person p = ReadPerson($"{name}.txt");
                DisplayPerson(p);
            }
            else
            {
                Console.WriteLine($"Welcome {name}!");
                Person p = ReadPerson();
                WritePerson(p, $"{name}.txt");                
            }


            Console.WriteLine();
           // WritePerson(people, "..\\..\\file_Ass1.txt");
            
            
        }
        Person ReadPerson()//Question A
        {
            Person person = new Person();
            //person.Name = ReadString("Enter your name: ");
            //Console.WriteLine($"Welcome {person.Name}!");
            person.City = ReadString("Enter City: ");
            person.Age = ReadInt("Enter Age: ", 0);
            return person;
        }
        void DisplayPerson(Person p)//Question A
        {   
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"City: {p.City}");
            Console.WriteLine($"Age: {p.Age}");
            //this is to see if my method work for question A...
        }
        Person ReadPerson(string filename)//Question C
        {
            Person p = new Person();

            //opening the file
            StreamReader reader = new StreamReader(filename);

            //display information from the file 
                p.Name = reader.ReadLine();
                p.City = reader.ReadLine();
                p.Age = int.Parse(reader.ReadLine());
            //to stop and close the file
            reader.Close();

            return p;//not sure about this. if this will return the input.
        }
        void WritePerson(Person p, string filename)//question B
        {
       
            //to locate the file
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(p.Name);
            writer.WriteLine(p.City);
            writer.WriteLine(p.Age);
            Console.WriteLine("Your data is written to file");
            //to close the file
            writer.Close();

        }
        //To read the questions!
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        int ReadInt(string question, int number)
        {
            Console.Write(question);
            string value = Console.ReadLine();
            int age = int.Parse(value);
            return age;
        }
    }
}
