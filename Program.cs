﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab3_Interfaces_Abstract_Classes
{
    internal class Program
    {
        //Creating an abstract class called Animal 
        abstract class Animal
        {
            public string Name { get; set; }
            public string Colour { get; set; }
            public int Age { get; set; }

            //Adding abstract method Eat 
            public abstract void Eat();
        }

        //Creating the Dog class to implament Animal
        class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Dogs eat meat.");
            }
        }

        //Creating the Cat class to implament Animal
        class Cat : Animal
        {
            public override void Eat() 
            {
                Console.WriteLine("Cats eat mice.");
            }
        }

        static void Main(string[] args)
        {
            //Crerating the Dog object 
            Console.WriteLine("Please enter the dog's name: "); // Asking the user for their input 
            string dogName = Console.ReadLine(); // Reading the user input 

            Console.WriteLine("Please enter the dog's color: ");
            string dogColor = Console.ReadLine();

            Console.WriteLine("Please enter the dog's age: ");
            //Created to display please try again if the user doesn't input an integer
            if (!int.TryParse(Console.ReadLine(), out int dogAge)) 
            {
                Console.WriteLine("Invalid input. Please try again!");
                return;
            }

            dog.Age = dogAge;
            //Displaying the information provided for the dog 
            Console.WriteLine($"Dog's name: {dogName}");
            Console.WriteLine($"Dog's color: {dogColor}");
            Console.WriteLine($"Dog's age: {dogAge}");
            dog.Eat();

            //Creating the Cat Object 
            Console.WriteLine("Please enter the cat's name: ");
            string catName = Console.ReadLine();
            

        }
    }
}
