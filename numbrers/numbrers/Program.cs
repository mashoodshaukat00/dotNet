// See https://aka.ms/new-console-template for more information
int a = 18;
int b = 6;
int c = a + b;

Console.WriteLine(c);

// List T
// this is how you create a list in C#
var names = new List<string>() { "Mashood", "Ahil", "Rania", "Laila" };
names.Add("Shaukat");
names.Add("ALi");
// names.Remove(names[3]);


// Read the last value of the list

Console.WriteLine(names[names.Count - 1]);
//statment below is exactly same is statement above.
// with that you start counting backwards.
Console.WriteLine(names[^1]);
Console.WriteLine(names[^3]);


foreach (var name in names) { 
    Console.WriteLine($"My name is {name.ToUpper()}");
};

// you can also loop over a range, in this string at index 2 and 3 will be shown
// and 4 would not be included.

foreach (var name in names[2..4])
{
    Console.WriteLine($"My name is {name.ToUpper()}");
};

// How to initiate an array in c#
// Remember add() remove() methods cannot be used on array. An array cannot be 
// modified in c#. Its size cannot be changed, Its has a fixed space in memory. 
// List if normal way if you have to deal with lists of data. Since that can be modified.

//Nb: sorting searching and looping over a list or array is same.

var listOfFriends = new string[] { "Umar", "Asim", "Hassan" };


// sorting list

var numbers = new List<int> { 45, 91, 23, 45, 76, 98, 1 };

Console.WriteLine(numbers[0]);
numbers.Sort();
Console.WriteLine(numbers[0]);