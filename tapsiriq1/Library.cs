using System;
using System.Collections.Generic;
using System.Text;

namespace tapsiriq1
{
    internal class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>
        {
            new Book("Cinayet ve Ceza", "Fyodor Dostoyevski", "1111"),
            new Book("1984", "George Orwell", "2222"),
            new Book("Balaca Sahzade", "Antoine de Saint-Exupéry", "3333"),
            new Book("Harry Potter", "J.K. Rowling", "4444"),
            new Book("Sefiller", "Victor Hugo", "5555")
        };
        }

        public void ShowBooks()
        {
            foreach (Book book in Books)
            {
                book.ShowInfo();
            }
        }
    }
}
