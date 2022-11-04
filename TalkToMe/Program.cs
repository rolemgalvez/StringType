

// Welcome message
Console.WriteLine("Talk To Me App");
Console.WriteLine("--------------");
Console.WriteLine();

// Declare variables
string firstName = string.Empty;
string lastName = string.Empty;
string message = string.Empty;

// Ask first name
Console.WriteLine("Oh look who's here!");
Console.Write("What is your name: ");
firstName = Console.ReadLine();
Console.WriteLine();

// Ask last name
Console.WriteLine($"Yes, I know you're {firstName}.");
Console.Write("I mean, what is your last name: ");
lastName = Console.ReadLine();
Console.WriteLine();

// Give some random message
message = $@"Okay {firstName} {lastName}, the code is D:\Is\Just\A\Random\Interaction";
Console.WriteLine(message);
Console.ReadLine();