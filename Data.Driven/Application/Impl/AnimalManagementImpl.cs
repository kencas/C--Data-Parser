using System;
using Data.Driven.Infrastructure;
using Data.Driven.Domain.Models;
using System.Collections.Generic;
using Data.Driven.Infrastructure.Helpers; 
using Data.Driven.Application;

namespace Data.Driven.Application.Impl
{
    public class AnimalManagementImpl: IAnimalManagement
    {
        private List<String> verseList;
        private List<Animal> animalList;
        private String parseResult;

        public AnimalManagementImpl()
        {
            //Get the default Verse template
            verseList = Verse.GetInstance().GetVerses();

            //read the JSON file
            animalList = DataReader.ReadParseJsonFile();
        }
         
        private String PrintVerse()
        {
            var replacement = "";
            var tempData = "";

            

            animalList.ForEach((animal) => {

                replacement += animal.name + " Verse\n";

                replacement += "------------------------\n";
                replacement += "\n";

                verseList.ForEach((verse) => {
                    tempData = verse.Replace("%", animal.name);
                    tempData = tempData.Replace("#", animal.sound);
                    replacement += tempData + "\n";
                });

                replacement += "\n";

            });

            return replacement;
        }

        public bool AddAnimal(String name, String sound)
        {
            var animal = new Animal();
            animal.name = name;
            animal.sound = sound;

            animalList.Add(animal);

            return true;
        }

        public void DoWork()
        {
            Console.WriteLine(this.PrintVerse());
        }
    }
}