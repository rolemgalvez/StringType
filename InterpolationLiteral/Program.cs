

// Welcome message
Console.WriteLine("String Interpolation & Literal");
Console.WriteLine("------------------------------");
Console.WriteLine();

// Declare variables
string name = string.Empty;
string nameAndAddress = string.Empty;

// Ask name
Console.Write("Give me your name: ");
name = Console.ReadLine();
Console.WriteLine();

// Print guess
nameAndAddress = $@"Okay {name}, just showing you this random address - C:\Thank\You\For\Interacting";
Console.WriteLine(nameAndAddress);
Console.ReadLine();