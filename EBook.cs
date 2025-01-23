public class EBook : Book
{
    public int FileSize { get; set; }

    public EBook(string title, string author, string isbn, bool available, int fileSize)
        : base(title, author, isbn, available)
    {
        FileSize = fileSize;
    }

    public override string ToString()
    {
        return base.ToString() + $", FileSize: {FileSize}MB";
    }
}