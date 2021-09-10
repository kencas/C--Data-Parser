using System;
using System.Collections.Generic;
using Polymorphism.Infrastructure.Helpers;

namespace Polymorphism.Domain.Models
{
    public class Dog: Animal
    {
        public override String sound { get; set; }
        public override String name { get; set; }
        public override List<String> verseList { get; set; }
    
        public Dog()
        {
            this.name = this.GetType().Name;
            this.sound = "bark";
        }

        public override String PrintVerse()
        {
            var replacement = "";
            var tempData = "";

            

                replacement += name + " Verse\n";

                replacement += "------------------------\n";
                replacement += "\n";

                verseList.ForEach((verse) => {
                    tempData = verse.Replace("%", name);
                    tempData = tempData.Replace("#", sound);
                    replacement += tempData + "\n";
                });

                replacement += "\n";

            return replacement;
        }
    }
}