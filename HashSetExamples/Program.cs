HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

List<int> numbers = new List<int> { 2, 3, 4, 8 };

hashSet.SymmetricExceptWith(numbers); // Will now contain 1, 5

foreach(int elem in hashSet) {
    Console.WriteLine(elem);
}

