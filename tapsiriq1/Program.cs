using System;
using tapsiriq1;

class Program
{
    static void Main()
    {
        Library library = new Library();

        Console.WriteLine("--- KİTABXANA ---");
        library.ShowBooks();

        Console.WriteLine("\n--- 2 KİTAB GÖTÜRÜLÜR ---");

        library.Books[0].BorrowBook();
        library.Books[2].BorrowBook();

        Console.WriteLine("\n--- YENİ NETİCE ---");

        library.ShowBooks();
    }
}