using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Name
    {
        static void Main()
        {
            Person aPerson = new Person();

            aPerson.firstName = "Ha-Mim";
            aPerson.middleName = "Hyder";
            aPerson.lastName = "Pial";

            Console.WriteLine(aPerson.GetFullName());
            Console.WriteLine(aPerson.GetReverseFullName());
            Console.ReadKey();
        }
    }
}
