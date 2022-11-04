// Welcome message
Console.WriteLine("Empty String App");
Console.WriteLine("----------------");
Console.WriteLine();

// Variable declaration
string skill = string.Empty;
string course = string.Empty;

// Ask skill
Console.WriteLine("Hi there!");
Console.Write("Just curious, what is your skill: ");
skill = Console.ReadLine();
Console.WriteLine();

// Ask course
Console.Write("How about your course, what it is: ");
course = Console.ReadLine();
Console.WriteLine();

// Response
Console.WriteLine("Your skill is " + skill + ".");
Console.WriteLine("Your course is " + course + ".");
Console.WriteLine("I think you can work with us!");
Console.ReadLine();