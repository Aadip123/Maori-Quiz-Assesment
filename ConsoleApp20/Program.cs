
int easyScore = 0;
int mediumScore = 0;
int hardScore = 0;

Console.WriteLine("Welcome to the Māori Quiz!");
Console.WriteLine("---------------------------");
Console.WriteLine("Select a difficulty level: (e)asy, (m)edium, or (h)ard");
string level = (Console.ReadLine()).ToUpper();

if (level == "e")
    Console.WriteLine("easy questions...");
else if (level == "m")
    Console.WriteLine("medium");
else if (level == "h")
    Console.WriteLine("hard questions");
else Console.WriteLine("please enter a valid number");
