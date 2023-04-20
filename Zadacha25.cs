using System;

namespace Zadacha25
{
    enum STYLE
    {
        Horror,
        Detective,
        Story,
        Noval
    }

    class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public STYLE Style { get; set; }

        public Book(string author, string name, STYLE style)
        {
            Author = author;
            Name = name;
            this.Style = style;
        }
    }
    class Program
    {
        static void Main()
        {
            Book book = new Book("Пушкина А.С.", "Тру стори", STYLE.Horror);

            Console.WriteLine($"Автор книги: {book.Author} Название книги: {book.Name}. Жанр книги: {STYLE.Horror}");
            Console.WriteLine($"Автор книги: {book.Author} Название книги: {book.Name}. Жанр книги: {STYLE.Detective}");
            Console.WriteLine($"Автор книги: {book.Author} Название книги: {book.Name}. Жанр книги: {STYLE.Story}");
            Console.WriteLine($"Автор книги: {book.Author} Название книги: {book.Name}. Жанр книги: {STYLE.Noval}");

        }
    }
}
