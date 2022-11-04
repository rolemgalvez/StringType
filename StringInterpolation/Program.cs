// Welcome message
Console.WriteLine("String Interpolation App");
Console.WriteLine("------------------------");

// Declare variables
string color = string.Empty;
string animal = string.Empty;

// Ask favorite color
Console.Write("Give me some favorite color: ");
color = Console.ReadLine();
Console.WriteLine();

// Ask favorite animal
Console.Write("How about your favorite animal, what it is: ");
animal = Console.ReadLine();
Console.WriteLine();

// Give the code name
Console.WriteLine($"With that, I will call you {color} {animal}!");
Console.ReadLine();