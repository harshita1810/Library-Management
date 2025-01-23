public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool Available { get; set; }

    public Book(string title, string author, string isbn, bool available)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Available = available;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available: {Available}";
    }
}