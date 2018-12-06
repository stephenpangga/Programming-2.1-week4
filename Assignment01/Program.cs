using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
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
            Person people = ReadPerson();
            DisplayPerson(people);
            WritePerson(people, "..\\..\\Week4-Ass1");
        }
        Person ReadPerson()//Question A
        {
            Person person = new Person();
            person.Name = ReadString("Enter your name: ");
            Console.WriteLine($"Welcome {person.Name}!");
            person.City = ReadString("Enter City: ");
            person.Age = ReadInt("Enter Age: ", 0);
            return person;
        }
        void DisplayPerson(Person p)//Question A
        {
            Console.WriteLine($"the name: {p.Name}, the city: {p.City}, the age: {p.Age}");
        }
        void WritePerson(Person p, string filename)//question B
        {
            //to locate the file
            StreamWriter writer = new StreamWriter(filename);

            //to write on the file.
            string s = Console.ReadLine();
            while(s!="stop")
            {
                writer.WriteLine(s);//this will write a line in the txt file.

                //to read next line
                s = Console.ReadLine(); 
            }
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
