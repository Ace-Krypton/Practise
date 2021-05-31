using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Developer : Person
    {
        //Fields
        public string Experience;
        public string ProgrammingLangs;

        //Constructor
        public Developer()
        {
            Console.WriteLine("Constructor created");
        }

        //Constructor
        public Developer(string name, string surname):this()
        {
            Name = name;
            Surname = surname;
        }

        //This keyword in the constructor
        public Developer(string name, string surname, int age, string experience, string programminglangs):this(name, surname)
        {
            Age = age;
            Experience = experience;
            ProgrammingLangs = programminglangs;
        }

        //Methods -- Polymorphism
        public override string GetFullInfo()
        {
            return $"{base.GetFullInfo()} Experience: {Experience} Programming Language Knowledge: {ProgrammingLangs}";
        }
    }
}
