using System.Collections;
string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

string toRemove = "Cherry";
int removedIndex = -1;

// Look for the target
for(int i = 0; i < fruits.Length; i++) {
    if(fruits[i] == toRemove) {
        // Found the target
        // Remove element
        fruits[i] = null;
        removedIndex = i;
        // Stop looping as no longer need to look for target
        break;
    }
}

for(int i = 0; i < fruits.Length; i++) {
    if(null == fruits[i]) {
        Console.WriteLine($"fruits[{i}] = null");
    } else {
        Console.WriteLine($"fruits[{i}] = {fruits[i]}");
    }
}
Console.WriteLine("===============================================");
// Shift elements and fill in gap
for(int i = removedIndex; i < fruits.Length-1; i++) {
    fruits[i] = fruits[i + 1];
}

fruits[fruits.Length-1] = null;



for(int i = 0; i < fruits.Length; i++) {
    if(null == fruits[i]) {
        Console.WriteLine($"fruits[{i}] = null");
    } else {
        Console.WriteLine($"fruits[{i}] = {fruits[i]}");
    }
}


ArrayList test = new ArrayList();

test.Add(1);
test.Add("a");
