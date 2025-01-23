public class BookFactory
{
    public static Book CreateBook(string type, string title, string author, string isbn, bool available, int fileSize = 0)
    {
        if (type.Equals("EBook", StringComparison.OrdinalIgnoreCase))
        {
            return new EBook(title, author, isbn, available, fileSize);
        }
        return new Book(title, author, isbn, available);
    }
}