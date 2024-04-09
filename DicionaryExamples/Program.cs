
var capitals = new Dictionary<string, string>();

capitals.Add("France", "Paris");
capitals.Add("Japan", "Tokyo");

if( capitals.TryAdd("Germany", "Berlin") ) {
    Console.WriteLine($"Added element!");
} else {
    Console.WriteLine($"Did NOT add element!");
}

if( capitals.TryAdd("France", "Paris") ) {
    Console.WriteLine($"Added element!");
} else {
    Console.WriteLine($"Did NOT add element!");
}

foreach(KeyValuePair<string, string> kvp in capitals) {
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");

}

Console.WriteLine("================= ITERATING KEYS BEGIN =================");
foreach (var key in capitals.Keys) {
    Console.WriteLine($"Country: {key}");
}

Console.WriteLine("================= ITERATING KEYS END =================");

Console.WriteLine("\n================= ITERATING VALUES BEGIN =================");
foreach (var value in capitals.Values) {
    Console.WriteLine($"Capital: {value}");
}

Console.WriteLine("================= ITERATING VALUES END =================");
