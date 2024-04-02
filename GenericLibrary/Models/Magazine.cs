using GenericLibrary.Interfaces;

namespace GenericLibrary.Models;
public class Magazine : ILibraryItem {
    public string Title { get; set; }
    public int IssueNumber { get; set; }

    public Magazine(string title, int issueNumber) {
        Title = title;
        IssueNumber = issueNumber;
    }

    public string DisplayInfo() {
        return $"Magazine: {this.Title}, Issue {this.IssueNumber}";
    }
}