Console.WriteLine("================================");
Console.WriteLine(Directory.GetCurrentDirectory());
Console.WriteLine("================================");

// Create a directory
string writeFolder = "Output";
Directory.CreateDirectory(writeFolder);

// Move into that directory
Directory.SetCurrentDirectory(writeFolder);

Console.WriteLine("================================");
Console.WriteLine(Directory.GetCurrentDirectory());
Console.WriteLine("================================");

// Now, write in that directory
string content = "Hello World!";
File.WriteAllText("test.txt", content);
