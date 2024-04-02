using GenericLibrary.Models;

// Creating a library for books
var bookLibrary = new Library<Book>();

bookLibrary.AddItem(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
bookLibrary.AddItem(new Book("1984", "George Orwell"));

// Fetching and displaying a book by title
var book = bookLibrary.GetItem("1984");
Console.WriteLine(book?.DisplayInfo());

Console.WriteLine("==========================================");
// Creating a library for magazines
var magazineLibrary = new Library<Magazine>();
magazineLibrary.AddItem(new Magazine("National Geographic", 500));
magazineLibrary.AddItem(new Magazine("TIME", 1000));

// Fetching and displaying a magazine by title
var magazine = magazineLibrary.GetItem("TIME");
Console.WriteLine(magazine?.DisplayInfo());

