using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBookApp
{
    class Book
    {
               private string isbnNumber;
        private string title;

        public Book(string title,string isbnNumber)
        {
            this.title = title;
            this.isbnNumber = isbnNumber;
        }
        public string IsbnNumber
        {
            get { return isbnNumber; }
        }     

        public string Title
        {
            get { return title; }
        }
    }
}




    

