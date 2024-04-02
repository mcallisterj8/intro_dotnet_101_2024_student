using GenericLibrary.Interfaces;
namespace GenericLibrary.Models;

public class Library<T> where T : ILibraryItem {
    // Generic list to hold library items of type T
    public List<T> Items { get; private set; } = new List<T>();

    // Method to add an item to the library
    public void AddItem(T item) {
        Items.Add(item);
        Console.WriteLine($"{item.Title} added to the library.");
    }

    // Generic method to get an item by title
    public T GetItem(string title) {
        return this.Items.FirstOrDefault(item => item.Title == title);
    }
}