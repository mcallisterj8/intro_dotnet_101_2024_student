
namespace GenericLogger.Models;
public class Logger {
    public string Name { get; set; }
    public int LogEntriesCount { get; private set; }

    public Logger(string name) {
        this.Name = name;
    }

    public void Log<T1, T2>(T1 info1, T2 info2) {
        Console.WriteLine($"Log Param 1: {info1}, Type: {typeof(T1)}");
        Console.WriteLine($"Log Param 2: {info2}, Type: {typeof(T2)}");

        this.LogEntriesCount += 2;
    }

    // Non-generic method to display the log count
    public void DisplayLogCount() {
        Console.WriteLine($"Total log entries: {this.LogEntriesCount}");
    }
}