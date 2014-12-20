using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] aStudents = new Student[3];
             Student student1=new Student();
            student1.regNO = "123";
            student1.firstName = "Ha-Mim";
            student1.lastName = "Hyder";

            Student student2= new Student();
            student2.regNO = "234";
            student2.firstName = "Pial";
            student2.lastName = "Hossain";

            Student student3 = new Student();
            student3.regNO = "345";
            student3.firstName = "Saddam";
            student3.lastName = "Hossain";

            aStudents[0] = student1;
            aStudents[1] = student2;
            aStudents[2] = student3;

            foreach (Student aStudent in aStudents)
            {
                Console.WriteLine(aStudent.regNO + " " + aStudent.GetFullName());
            }

            Console.ReadKey();
        }
    }
}
