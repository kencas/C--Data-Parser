using System;
using Polymorphism.Domain.Models;
using System.Collections.Generic;
using Polymorphism.Infrastructure.Helpers;

namespace Polymorphism.Application
{
    public class AnimalManagement
    {
        private Animal animal;
        private List<Animal> animals = new List<Animal>();
        private string displayText;
        List<String> verseList = Verse.GetInstance().GetVerses();
        
        public void DoWork()
        {
            // animal = new Cow();
            // animal.sound = "mow";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Goat implementation
            // animal = new Goat();
            // animal.sound = "bleak";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Cow implementaion
            // animal = new Dog();
            // animal.sound = "bark";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Bat Implementation
            // animal = new Bat();
            // animal.sound = "screech";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Chicken Implementation
            // animal = new Chicken();
            // animal.sound = "screech";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();


            // //Crab Implementation
            // animal = new Crab();
            // animal.sound = "chirp";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Duck Implementation
            // animal = new Duck();
            // animal.sound = "quack";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();


            // //Duck Implementation
            // animal = new Elephant();
            // animal.sound = "trumpet";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Duck Implementation
            // animal = new Fly();
            // animal.sound = "buzz";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            // //Frog Implementation
            // animal = new Frog();
            // animal.sound = "croak";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();


            // //Grasshopper Implementation
            // animal = new Grasshopper();
            // animal.sound = "chirp";
            // animal.verseList = verseList;
            // displayText += animal.PrintVerse();

            animals.Add(new Cow());
            animals.Add(new Goat());
            animals.Add(new Dog());
            animals.Add(new Bat());
            animals.Add(new Chicken());
            animals.Add(new Crab());
            animals.Add(new Duck());
            animals.Add(new Elephant());
            animals.Add(new Fly());
            animals.Add(new Frog());
            animals.Add(new Grasshopper());


            foreach (var animal in animals)
            {
                // if(animal is Cow) 
                // {
                //     animal.sound = "mow";
                    animal.verseList = verseList;
                    displayText += animal.PrintVerse();
                // }
                // else if(animal is Goat) 
                // {
                //     animal.sound = "bleak";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Dog) 
                // {
                //     animal.sound = "bark";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Bat) 
                // {
                //     animal.sound = "screech";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Chicken) 
                // {
                //     animal.sound = "screech";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Crab) 
                // {
                //     animal.sound = "chirp";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Duck) 
                // {
                //     animal.sound = "quack";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Elephant) 
                // {
                //     animal.sound = "trumpet";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Fly) 
                // {
                //     animal.sound = "buzz";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Frog) 
                // {
                //     animal.sound = "croak";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                // else if(animal is Grasshopper) 
                // {
                //     animal.sound = "chirp";
                //     animal.verseList = verseList;
                //     displayText += animal.PrintVerse();
                // }
                
            }

            Console.WriteLine(displayText);
        }

        public bool AddAnimal(String name, String sound)
        {
            var animal = new Animal();
            animal.name = name;
            animal.sound = sound;

            animals.Add(animal);

            return true;
        }
        
    }
}