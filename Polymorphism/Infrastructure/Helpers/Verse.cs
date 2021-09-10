using System;
using System.Collections.Generic; 

namespace Polymorphism.Infrastructure.Helpers
{
    public class Verse
    {
        private List<String> verseList =  new List<String>();
        private static Verse verse;

        public static Verse GetInstance()
        {
            if(verse == null)
            verse = new Verse();

            return verse;
        }

        public List<String> GetVerses()
        {
            // % represents animal name
            // # represents the sound
            verseList.Add("Old MacDonald had a farm, E I E I O,");
            verseList.Add("And on his farm he had a %, E I E I O.");
            verseList.Add("With a # # here and a # # there,");
            verseList.Add("Here a #, there a #, ev'rywhere a # #.");
            verseList.Add("Old MacDonald had a farm, E I E I O.");

            return verseList;
        }
    }
}