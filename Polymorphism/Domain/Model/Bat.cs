using System;
using Polymorphism.Infrastructure.Helpers;
using System.Collections.Generic;

namespace Polymorphism.Domain.Models
{
    public class Bat : Animal
    {
        public override String sound { get; set; }
        public override String name { get; set; }
        public override List<String> verseList { get; set; }

        public Bat()
        {
            this.name = this.GetType().Name;
            this.sound = "screech";
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