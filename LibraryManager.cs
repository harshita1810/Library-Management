using System;

public class LibraryManager
{
    private static LibraryManager instance;
    private Library library = new Library();

    private LibraryManager() { }

    public static LibraryManager Instance
    {
        get
        {
            if (instance == null)
                instance = new LibraryManager();
            return instance;
        }
    }

    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add new Book");
            Console.WriteLine("2. Add new EBook");
            Console.WriteLine("3. Remove existing Book");
            Console.WriteLine("4. Search any Book");
            Console.WriteLine("5. List of Books");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    AddEBook();
                    break;
                case "3":
                    RemoveBook();
                    break;
                case "4":
                    SearchBook();
                    break;
                case "5":
                    library.ListBooks();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void AddBook()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Is it available? (true/false): ");
        bool available = bool.Parse(Console.ReadLine());

        var book = BookFactory.CreateBook("Book", title, author, isbn, available);
        library.AddBook(book);
    }

    private void AddEBook()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Is it available? (true/false): ");
        bool available = bool.Parse(Console.ReadLine());
        Console.Write("Enter file size (MB): ");
        int fileSize = int.Parse(Console.ReadLine());

        var eBook = BookFactory.CreateBook("EBook", title, author, isbn, available, fileSize);
        library.AddBook(eBook);
    }

    private void RemoveBook()
    {
        Console.Write("Enter ISBN to remove: ");
        string isbn = Console.ReadLine();
        library.RemoveBook(isbn);
    }

    private void SearchBook()
    {
        Console.Write("Enter title to search: ");
        string title = Console.ReadLine();
        var book = library.SearchBook(title);
        Console.WriteLine(book != null ? book.ToString() : "Book not found.");
    }
}