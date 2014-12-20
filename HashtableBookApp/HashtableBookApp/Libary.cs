using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBookApp
{
    class Libary
    {
        private Hashtable bookList = null;
        private Book bookObj;
        public Libary()
        {
            bookList = new Hashtable();
        }
    
        public void AddBook(string isbnNumber, Book bookObj)
        {
            bookList.Add(isbnNumber, bookObj);
        }
        
        public Book GetBook(string isbnNumber)
        {
            return  bookObj = (Book) bookList[isbnNumber];
        }
    }
}


    
