﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static void Main(string[] args)
        {
        }
    }
}
