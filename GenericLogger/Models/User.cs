namespace GenericLogger.Models;
public class User {
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() {
        return $"Name: {this.Name}, Age: {this.Age}";
    }
}