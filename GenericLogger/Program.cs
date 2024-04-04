using GenericLogger.Models;

User userA = new User { Name = "Alice", Age = 27 };

var logger = new Logger("Wall-E");
logger.Log("User logged in", 42);

Console.WriteLine("===========================");

// logger.Log(DateTime.Now, userA);
logger.DisplayLogCount();