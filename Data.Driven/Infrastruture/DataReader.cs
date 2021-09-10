using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Data.Driven.Domain.Models;

namespace Data.Driven.Infrastructure
{
    public class DataReader
    {

        public static List<Animal> ReadParseJsonFile()
        {
            string fileName = "data.json";
            string jsonString = File.ReadAllText(fileName);
            List<Animal> animalList = JsonSerializer.Deserialize<List<Animal>>(jsonString);
            return animalList;
        }
    

    }

}