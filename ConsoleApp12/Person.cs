using System;

namespace ConsoleApp12
{
    class Person
    {
        //Fields
        public string Name;
        public string Surname;
        public int Age;

        //Methods
        public string GetFullName()
        {
            return $"Name: {Name} Surname: {Surname}";
        }

        //Methods -- Polymorphism
        public virtual string GetFullInfo()
        {
            return $"{GetFullName()} Age: {Age}";
        }

    }

}