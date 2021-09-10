using System;
using Polymorphism.Application;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AnimalManagement animalManagement = new AnimalManagement();
            animalManagement.DoWork();
            // Console.WriteLine(animalManagement.PrintVerse());
        }
    }
}
