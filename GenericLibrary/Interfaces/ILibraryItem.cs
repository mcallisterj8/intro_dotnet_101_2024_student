namespace GenericLibrary.Interfaces;
public interface ILibraryItem {
    string Title { get; set; }
    string DisplayInfo();
}