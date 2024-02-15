Console.WriteLine("Enter your age:");
string input = Console.ReadLine();
int age;

if (int.TryParse(input, out age)) {
    Console.WriteLine($"You are {age} years old.");
} else {
    Console.WriteLine("Invalid input. Please enter a number.");

}