using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{


    class Color
    {
        public float r, g, b;
    }

    class Dog
    {
        public string name;
        public int size;
        public string breed;
        public ConsoleColor color;

        public void Eat(string food)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " is eating " + food);
        }
        public void Sleep()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " is sleeping");
        }
        public void Shit()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name + " is shitting");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color();
            red.r = 1;
            red.g = 0;
            red.b = 0;

            // Create instance of Dog
            Dog dog1 = new Dog();
            // Set properties of instance
            dog1.name = "Lassie";
            dog1.size = 2;
            dog1.breed = "Dalmation";
            dog1.color = ConsoleColor.Cyan;

            dog1.Eat("Meat"); // Cos ya can't have any puddin if you don't eat ya meat!
            dog1.Shit();

            Console.ReadLine();
        }
    }
}

