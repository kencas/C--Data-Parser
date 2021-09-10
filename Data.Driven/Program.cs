using System;
using Data.Driven.Application;
using Data.Driven.Application.Impl;
using Data.Driven.Domain.Exceptions;

namespace Data.Driven
{
    class Program
    {
        private static String animalName;
        private static String animalSound;

        static void Main(string[] args)
        {
            try
            {
                string input;
                IAnimalManagement animalManagement = new AnimalManagementImpl();
                Console.Write("Welcome to BTOBET C# Test \n");
                Console.Write("1. Display existing Data \n");
                Console.Write("2. Add new Animal \n");
                input = Console.ReadLine();

                if(input == "")
                    throw new InvalidInputException("Invalid Input. Please try again");

                switch (input)
                {
                    case "1":
                        animalManagement.DoWork();
                        break;

                    case "2":
                        Console.Write("Enter Animal Name \n");
                        input = Console.ReadLine();
                        if(input == "")
                            throw new InvalidInputException("Invalid Input. Please try again");
                        animalName = input;

                        Console.Write("Enter Animal Sound \n");
                        input = Console.ReadLine();
                        if(input == "")
                            throw new InvalidInputException("Invalid Input. Please try again");
                        animalSound = input;

                        if(animalManagement.AddAnimal(animalName, animalSound))
                        animalManagement.DoWork();

                        // Console.Write("The details entered are '{0}' - '{1}'", animalName, animalSound);

                        break;

                    

                    default:
                        throw new InvalidInputException("Invalid Input. Please enter 1 or 2");
                        break;
                }
            }
            catch (InvalidInputException ex)
            {
                
                Console.WriteLine("InvalidInputException: {0}", ex.Message);
            }
            
			// Console.WriteLine("You entered '{0}'", input);
            // IAnimalManagement animalManagement = new AnimalManagementImpl();
            // Console.WriteLine(animalManagement.PrintVerse());
        }
    }
}
