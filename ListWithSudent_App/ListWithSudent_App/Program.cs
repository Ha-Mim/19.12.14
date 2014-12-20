using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithSudent_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.regNO = "123";
            student1.firstName = "Shah";
            student1.lastName = "Alam";

            Student student2 = new Student();
            student2.regNO = "234";
            student2.firstName = "Masud";
            student2.lastName = "Rana";

            Student student3 = new Student();
            student3.regNO = "345";
            student3.firstName = "Salman";
            student3.lastName = "Khan";

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.regNO + " " +aStudent.GetFullName());
            }

            Console.ReadKey();
        }
    }
}
