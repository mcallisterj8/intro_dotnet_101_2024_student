using GenericsExamples.Models;

List<string> words = new List<string> { "apple", "berry", "cherry", "date" };
List<int> numbers = new List<int> { 12, 16, 18, 24, 80 };




Box<string> boxA = new Box<string>("boxA", "Star Item", words);
Console.WriteLine(boxA.ToString());

Console.WriteLine("\n=======================================");

Box<int> boxB = new Box<int>("boxB", 8, numbers);
Console.WriteLine(boxB.ToString());


Console.WriteLine("\n=======================================");