using System;
using System.Security.Cryptography;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Lizard : Animal
    {
        public int age;
        public string color;
        public string breed;

        //constructor
        public Lizard()
            :base("Charlie")
        {
            age = 1;
            color = "brown";
            breed = "Chuckwalla";
        } 
        public Lizard(string name, int age, string color, string breed)
            :base(name)
        {
            this.age = age;
            this.color = color;
            this.breed = breed;
        }
        public void displayInfo(){
            Console.WriteLine("\nLizard Information: ");
            getName();
            getAge();
            getColor();
            getBreed();
        }
        public void getName()
        {
            Console.WriteLine($"Name: {name}");
        }
        public void getAge()
        {
            Console.WriteLine($"Age: {age}");
        }
        public void getColor()
        {
            Console.WriteLine($"Color: {color}");
        }
        public void getBreed()
        {
            Console.WriteLine($"Breed: {breed}");
        }
    }
    class Cow : Animal 
    {
        public int age;
        public int weight;
        public string breed;
        // constructors
        public Cow()
            :base("")
        {
            age = 0;
            weight = 0;
            breed = "";
        }
        public Cow(string name, int age, int weight, string breed)
            :base(name)
        {
            this.age = age;
            this.weight = weight;
            this.breed = breed;
        }   
        public void getStats()
        {
            Console.WriteLine("\nCow Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Breed: {breed}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Lizard chowder = new Lizard();
            chowder.name = "chowder";
            chowder.age = 3;
            chowder.color = "black";
            chowder.breed = "Black Dragon";
            chowder.displayInfo();

            //derived class object using parameterized constructor
            Lizard helios = new Lizard("Helios", 2, "green", "gecko");
            helios.displayInfo();

            //Derived class object Cow using default constructor
            Cow lesley = new Cow();
            lesley.name = "Lesley";
            lesley.age = 5;
            lesley.weight = 300;
            lesley.breed = "Angus";
            lesley.getStats();
            
            //Derived class object Cow using parameterized constructor
            Cow nero = new Cow("Nero", 6, 270, "Highland Cattle");
            nero.getStats();
        }

    }
}