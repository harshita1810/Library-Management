using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(string isbn)
    {
        books.RemoveAll(b => b.ISBN == isbn);
    }

    public Book SearchBook(string title)
    {
        return books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public void ListBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}