
string dirPath = "./apple";

Directory.CreateDirectory(dirPath);

Directory.SetCurrentDirectory(dirPath);

Console.WriteLine($"CURRENT DIR: {Directory.GetCurrentDirectory()}");
Directory.SetCurrentDirectory("../");
Console.WriteLine($"CURRENT DIR: {Directory.GetCurrentDirectory()}");



