
// Person(string firstName, string lastName, int age)
Person john = new Person("John", "Smith", 22);
Person tom = new Person("Tom", "Thompson", 24); 

// Car(string carName, int wheels)
Car alfredo = new Car("Alfredo", 4);
Car lexi = new Car("Lexi", 4);

alfredo.AddPassenger(john);
// alfredo.AddPassenger(tom);
alfredo.Passengers[3] = tom;

Console.WriteLine($"{john.FirstName} location: {alfredo.CheckPassenger(john)}");
Console.WriteLine($"{tom.FirstName} location BEFORE: {alfredo.CheckPassenger(tom)}");

Person removedPerson = alfredo.RemovePassenger(tom);
Console.WriteLine($"Removed {removedPerson.FirstName} {removedPerson.LastName}");

Console.WriteLine($"{tom.FirstName} location AFTER: {alfredo.CheckPassenger(tom)}");
