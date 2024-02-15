using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02_Q5
{

    public class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, the book '{Title}' by {Author} is not available.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate multiple book objects
            LibraryBook book1 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", true);
            LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", true);
            LibraryBook book3 = new LibraryBook("1984", "George Orwell", false);

            // List of books in the library
            List<LibraryBook> libraryBooks = new List<LibraryBook> { book1, book2, book3 };

            // Perform book borrowing
            Console.WriteLine("Available Books:");
            foreach (var book in libraryBooks)
            {
                if (book.Available)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }
            }

            Console.WriteLine("\nAttempting to borrow books...\n");

            // Borrowing books
            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();

            // Display updated library status
            Console.WriteLine("\nUpdated Library Status:");
            foreach (var book in libraryBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
            }
        }
    }
}
