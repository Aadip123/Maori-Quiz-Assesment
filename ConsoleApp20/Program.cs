
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

// method called easy showing score and level
static int Easy(int easyScore, string level)
{
    if (level == "E")
      // if statment checks what level is inputted
 
    {
        Console.WriteLine("Easy Questions:");
        Console.WriteLine("----------------");

        Console.WriteLine("1. What is the Māori word for hello?");
        Console.WriteLine("a) Kia ora");
        Console.WriteLine("b) Haere mai");
        Console.WriteLine("c) Ka kite");
        Console.WriteLine("d) Nau mai");
        string easy1 = Console.ReadLine().ToUpper();
        if (easy1 == "a")
        {
            easyScore++;
            Console.WriteLine($"Correct point added your current score is {easyScore}");
        }// adding score 
        else if (easy1 != "a")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {easyScore}.");
        }
        Console.WriteLine("2. What is the Māori word for goodbye?");
        Console.WriteLine("a) E noho rā");
        Console.WriteLine("b) Kia ora");
        Console.WriteLine("c) Haere mai");
        Console.WriteLine("d) Ma");
        string easy2 = Console.ReadLine().ToUpper();
        if (easy2 == "a")
        {
            easyScore++;
            Console.WriteLine($"Correct point added! your current score is {easyScore}");
        }
        else if (easy2 != "a")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {easyScore}.");
        }
       
        // working on clicking key to medium level

    }

    return easyScore;
}

//easy ends
Console.WriteLine($"Thank you for playing your score is {easyScore} please click M to play Medium level or any other key to quit ");
string nextlevel = Console.ReadLine().ToUpper();


static int Medium(int mediumScore, string level)
{// new level starts
    if (level == "M")
        //if statment for medium level

    {
        Console.WriteLine("Medium Questions:");
        Console.WriteLine("------------------");

        Console.WriteLine("1. What is the Māori word for thank you?");
        Console.WriteLine("a) Tino pai");
        Console.WriteLine("b) Aroha mai");
        Console.WriteLine("c) Nau mai");
        Console.WriteLine("d) Kia ora");
        string medium1 = Console.ReadLine().ToUpper();
        if (medium1 == "D")
        {
            mediumScore++;
            Console.WriteLine($"Correct point added! your current score is {mediumScore}");
        }

        else if (medium1 != "D")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {mediumScore}.");
        }
        Console.WriteLine("2. What is the Māori word for family?");
        Console.WriteLine("a) Whānau");
        Console.WriteLine("b) Mana");
        Console.WriteLine("c) Tapu");
        Console.WriteLine("d) Mauri");
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
        Console.WriteLine($"Thank you for playing your score is {mediumScore} please click H to play Hard level or any other key to quit ");
    }

    return mediumScore;

}
Console.WriteLine($"Thank you for playing your score is {mediumScore} please click H to play Hard level or any other key to quit ");
Console.ReadLine();
static int Hard(int hardScore, string level)
{
    if (level == "H")


    {
        Console.WriteLine("Hard Questions:");
        Console.WriteLine("----------------");

        Console.WriteLine("1. ?");
        Console.WriteLine("a) ");
        Console.WriteLine("b) ");
        Console.WriteLine("c) ");
        Console.WriteLine("d) ");
        string hard1 = Console.ReadLine();
        if (hard1 == "a")
        {
            hardScore++;
            Console.WriteLine($"Correct point added your current score is {hardScore}");
        }
        else if (hard1 != "a")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {hardScore}.");
        }
        Console.WriteLine("2. What is the Māori word for goodbye?");
        Console.WriteLine("a) E noho rā");
        Console.WriteLine("b) Kia ora");
        Console.WriteLine("c) Haere mai");
        Console.WriteLine("d) Ma");
        string hard2 = Console.ReadLine();
        if (hard2 == "a")
        {
            hardScore++;
            Console.WriteLine($"Correct point added! your current score is {hardScore}");
        }
        else if (hard2 != "a")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {hardScore}.");
        }
        Console.WriteLine($"Thank you for playing! this is the end of the quiz ");


    }

    return hardScore;
}




