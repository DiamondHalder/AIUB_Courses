using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    internal class Program
    {
        public class Book
        {
            private string bookName;
            private string bookAuthor;
            private string bookId;
            private string bookType;
            private int bookCopy;

            public static int bookCounter = 0;

            // Properties
            public string BookName
            {
                get { return bookName; }
                set { bookName = value; }
            }

            public string BookAuthor
            {
                get { return bookAuthor; }
                set { bookAuthor = value; }
            }

            public string BookId
            {
                get { return bookId; }
                set { bookId = value; }
            }

            public string BookType
            {
                get { return bookType; }
                set { bookType = value; }
            }

            public int BookCopy
            {
                get { return bookCopy; }
                set { bookCopy = value; }
            }

            // Constructors
            public Book()
            {
                bookCounter++;
                Console.WriteLine("Book object created with default constructor.");
            }

            public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookId = bookId;
                this.bookType = bookType;
                this.bookCopy = bookCopy;
                bookCounter++;
                Console.WriteLine("Book object created with parameterized constructor.");
            }

            // Member functions
            public void showInfo()
            {
                Console.WriteLine($"Book Name: {BookName},\n Author: {BookAuthor},\n ID: {BookId},\nType: {BookType}, \nCopies: {BookCopy}");
            }

            public void addBookCopy(int x)
            {
                BookCopy += x;
                Console.WriteLine($"Added {x} copies. Total copies: {BookCopy}");
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            Book book1 = new Book("C#","Farah","38129379","Programming",4);
            book1.showInfo();
            book1.addBookCopy(1);

        }
    }
}
