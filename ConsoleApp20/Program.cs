
int easyScore = 0;
int mediumScore = 0;
int hardScore = 0;

Console.WriteLine("Welcome to the Māori Quiz!");
Console.WriteLine("---------------------------");
Console.WriteLine("Please enter name");
string name = Console.ReadLine();
Console.WriteLine($"Welcome {name}, we will start the quiz now");
Console.WriteLine("Select a difficulty level: (e)asy, (m)edium, or (h)ard");
string level = Console.ReadLine().ToUpper();


if (level == "E")
{
    Console.WriteLine("Easy Questions:");
    Console.WriteLine("----------------");

    Console.WriteLine("1. What is the Māori word for hello?");
    Console.WriteLine("a) Kia ora");
    Console.WriteLine("b) Haere mai");
    Console.WriteLine("c) Ka kite");
    Console.WriteLine("d) Nau mai");
    string easy1 = Console.ReadLine();
    if (easy1 == "a")
    {
        easyScore++;
        Console.WriteLine($"Correct point added your current score is {easyScore}");
    }
    else if (easy1 != "a") 
    {
        Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {easyScore} move on to next question please.");
    }
    Console.WriteLine("2. What is the Māori word for goodbye?");
    Console.WriteLine("a) E noho rā");
    Console.WriteLine("b) Kia ora");
    Console.WriteLine("c) Haere mai");
    Console.WriteLine("d) Ma");
    string easy2 = Console.ReadLine();
    if (easy2 == "a")
    {
        easyScore++;
        Console.WriteLine($"Correct point added! your current score is {easyScore}");
    }
    else if (easy2 != "a")
    {
        Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {easyScore} move on to next question please.");
    }

}





else if (level == "M")
    Console.WriteLine("medium");
else if (level == "H")
    Console.WriteLine("hard questions");
else Console.WriteLine("please enter a valid letter");
