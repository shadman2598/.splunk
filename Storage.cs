public static class Storage {
    private static List<Book> _books = new List<Book>
    {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
        new Book { Id = 2,Title = "To Kill a Mockingbird", Author = "Harper Lee" },
        new Book { Id = 3,Title = "1984", Author = "George Orwell" },
        new Book { Id = 4,Title = "The Lord of the Rings", Author = "J. R. R. Tolkien" },
        new Book { Id = 5,Title = "The Hobbit", Author = "J. R. R. Tolkien" },
    };

    public static List<Book> Books
    {
        get { return _books; }
    }
    private static List<Reader> _readers = new List<Reader>
    {
        new Reader { Id = 1, Name = "John Doe" },
        new Reader { Id = 2, Name = "Jane Doe" },
        new Reader { Id = 3, Name = "John Smith" },
        new Reader { Id = 4, Name = "Jane Smith" },
    };

    public static List<Reader> Readers
    {
        get { return _readers; }
    }

    private static List<Borrowing> _borrowings = new List<Borrowing>
    {
        new Borrowing { Id = 1, BookId = 1, ReaderId = 1, BorrowDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc), ReturnDate = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc) },
        new Borrowing { Id = 2, BookId = 2, ReaderId = 2, BorrowDate = new DateTime(2024, 1, 2, 0, 0, 0, DateTimeKind.Utc), ReturnDate = new DateTime(2024, 1, 16, 0, 0, 0, DateTimeKind.Utc) },
        new Borrowing { Id = 3, BookId = 3, ReaderId = 3, BorrowDate = new DateTime(2024, 1, 3, 0, 0, 0, DateTimeKind.Utc), ReturnDate = new DateTime(2024, 1, 17, 0, 0, 0, DateTimeKind.Utc) },
        new Borrowing { Id = 4, BookId = 4, ReaderId = 4, BorrowDate = new DateTime(2024, 1, 4, 0, 0, 0, DateTimeKind.Utc), ReturnDate = new DateTime(2024, 1, 18, 0, 0, 0, DateTimeKind.Utc) },
    };

    public static List<Borrowing> Borrowings
    {
        get { return _borrowings; }
    }
}
// Github Copilot