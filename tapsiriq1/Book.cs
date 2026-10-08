using System;
using System.Collections.Generic;
using System.Text;

namespace tapsiriq1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        private bool isAvailable = true;

        public Book(string title, string author, string isbn) {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"\"{Title}\" kitabi goturuldu" );
            }
            else
            {
                Console.WriteLine($"\"{Title}\" kitabi artik goturulub");
            }
            
        }

        public void ReturnBook()
        {
            isAvailable = true;
            Console.WriteLine($"\"{Title}\" kitabi geri qaytarildi");
        }

        public void ShowInfo()
        {
            string status = isAvailable ? "Movcuddur" : "Goturulub";
            Console.WriteLine($"Kitab: {Title}| Muellif:{Author}| ISBN:{ISBN}| Status:{status}");

        }
    }
}
