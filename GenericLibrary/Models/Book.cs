using GenericLibrary.Interfaces;

namespace GenericLibrary.Models;
public class Book : ILibraryItem {
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author) {
        Title = title;
        Author = author;
    }

    public string DisplayInfo() {
        return $"Book: {this.Title} by {this.Author}";
    }
}