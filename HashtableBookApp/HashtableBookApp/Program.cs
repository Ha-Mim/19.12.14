using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Libary libaryObj = new Libary();
            Book bookObj1 = new Book("Database System Concept", "Db#789");
            Book bookObj2 = new Book("Begining C# 2008", "Pl#756");
            Book bookObj3 = new Book("Head First C#", "pl#759");

            libaryObj.AddBook(bookObj1.IsbnNumber, bookObj1);
            libaryObj.AddBook(bookObj2.IsbnNumber, bookObj2);
            libaryObj.AddBook(bookObj3.IsbnNumber, bookObj3);

            Book bookObj = libaryObj.GetBook("Db#789");
            Console.WriteLine(bookObj.Title);
            Console.ReadLine();

          
         
            
        }
       

    }
}
