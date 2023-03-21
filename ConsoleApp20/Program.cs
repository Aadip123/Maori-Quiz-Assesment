
int easyScore = 0;
int mediumScore = 0;
int hardScore = 0;

Console.WriteLine("Welcome to the Māori Quiz!");
Console.WriteLine("---------------------------");
Console.WriteLine("Please enter name");
string name = Console.ReadLine();
Console.WriteLine($"Welcome {name}, we will start the quiz now");
System.Threading.Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Select a difficulty level: (e)asy, (m)edium, or (h)ard");
string level = Console.ReadLine().ToUpper();
mediumScore=Medium(mediumScore, level);
easyScore=Easy(easyScore, level);


static int Easy(int easyScore, string level)
{
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
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {easyScore}.");
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
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {easyScore}.");
        }
        Console.WriteLine($"Thank you for playing your score is {easyScore} please click M to play Medium level or any other key to quit ");


    }
  

    string nextlevel = Console.ReadLine().ToUpper();
    if (nextlevel == "M")
    {
        Console.WriteLine();
    }
    else if (nextlevel != "N")
    {
        Console.WriteLine("you have chosen an invalid letter please retry");
    }


    return easyScore;



}


//easy ends

static int Medium(int mediumScore, string level)
{
    if (level == "M")


    {
        Console.WriteLine("Medium Questions:");
        Console.WriteLine("----------------");

        Console.WriteLine("1. What is the Māori word for hello?");
        Console.WriteLine("a) Kia ora");
        Console.WriteLine("b) Haere mai");
        Console.WriteLine("c) Ka kite");
        Console.WriteLine("d) Nau mai");
        string medium1 = Console.ReadLine();
        if (medium1 == "a")
        {
            mediumScore++;
            Console.WriteLine($"Correct point added your current score is {mediumScore}");
        }
        else if (medium1 != "a")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {mediumScore}.");
        }
        Console.WriteLine("2. What is the Māori word for goodbye?");
        Console.WriteLine("a) E noho rā");
        Console.WriteLine("b) Kia ora");
        Console.WriteLine("c) Haere mai");
        Console.WriteLine("d) Ma");
        string medium2 = Console.ReadLine();
        if (medium2 == "a")
        {
            mediumScore++;
            Console.WriteLine($"Correct point added! your current score is {mediumScore}");
        }
        else if (medium2 != "a")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {mediumScore}.");
        }
        Console.WriteLine($"Thank you for playing your score is {mediumScore} please click N for next level or any other key to quit ");


    }

    return mediumScore;
}



