using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> students = new Stack<Student>();

            Student student1 = new Student();
            student1.firstName = "Ha-Mim";
            student1.lastName = "Hyder";
            students.Push(student1);

            Student student2 = new Student();
            student2.firstName = "Shah";
            student2.lastName = "Alam";
            students.Push(student2);

            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.GetFullName());
            }
            Console.ReadKey();
        }
    }
}
