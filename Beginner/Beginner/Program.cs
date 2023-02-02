using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Sneha";
            int age = 20;
            int dogAge = 6;
            // Printing characters
            Console.WriteLine("Hi everyone. This is my first c sharp program");

            // Printing a pattern
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");
            Console.WriteLine("");

            // Using variables for value 
            Console.WriteLine("MY DESCRIPTION");
            Console.WriteLine("I am "+characterName+" and Arya is my dog");
            Console.WriteLine("I am " + age + " years old and Arya is " + dogAge + " years old");
            
            // Update new characterName 
            characterName = "Afrin";
            Console.WriteLine("My best friend's name is " + characterName);

            // using string methods
            string phrase = "I am Sneha Ramesh";
            Console.WriteLine("");
            Console.WriteLine(phrase.ToUpper());  // capitalize string
            Console.WriteLine(phrase.Length);  // length of the string
            Console.WriteLine(phrase[2]);  //indexing characters
            Console.WriteLine(phrase.IndexOf("Ramesh"));   // Starting index of the string
            Console.ReadLine();
        }
    }
}
