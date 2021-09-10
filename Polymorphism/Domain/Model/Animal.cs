using System;
using System.Collections.Generic;

namespace Polymorphism.Domain.Models
{
    public abstract class Animal
    {
        public virtual String sound { get; set; }
        public virtual String name { get; set; }
        public virtual List<String> verseList { get; set; }
        public abstract String PrintVerse();
    }
}