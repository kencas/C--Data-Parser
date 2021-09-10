using System;
using Data.Driven.Domain.Models;

namespace Data.Driven.Application
{

    interface IAnimalManagement
    {
        void DoWork();
        bool AddAnimal(String name, String sound);
    }

}