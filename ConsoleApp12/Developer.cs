using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Developer : Person
    {
        public string Experience;
        public string ProgrammingLangs;

        //Methods -- Polymorphism
        public override string GetFullInfo()
        {
            return $"{base.GetFullInfo()} Experience: {Experience} Programming Language Knowledge: {ProgrammingLangs}";
        }
    }
}
