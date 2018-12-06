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
        }
        Person ReadPerson()
        {
            Person person = new Person();
            person.Name = ReadString("Enter your name: ");
            Console.WriteLine($"welcome {person.Name}!");
            person.City = ReadString("Enter City: ");
            person.Age = ReadInt("Enter Age: ", 0);
            person.Age = ReadInt("enter an age", 0);

            return person;
        }
        void DisplayPerson(Person p)
        {
            
        }

        string ReadString(string question)
        {
            Console.Write(question); // to display the question
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
