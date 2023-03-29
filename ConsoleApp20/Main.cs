
// Define variables to keep track of the scores for each level


int easyScore = 0;
int mediumScore = 0;
int hardScore = 0;

//array for keeping track of scores
int[] scores = new int[2];


//array for levels
string[] levels = { "E", "M", "H" };


// Print out welcome messages and get the user's name
Console.WriteLine("Welcome to the Māori Quiz!");
Console.WriteLine("---------------------------");
Console.WriteLine("Please enter your name");

//storing the name in a variable
string name = Console.ReadLine();
Console.WriteLine($"Welcome {name}, we will start the quiz now");


// Pause for 1 second and then clear the console
Thread.Sleep(1000);
Console.Clear();


// Use a while loop to keep the game going until the user decides to stop or the game ends
bool keepPlaying = true;

while (keepPlaying)
{// Prompt the user to select a level 
    Console.WriteLine("Select a difficulty level: (E)asy, (M)edium, or (H)ard");
    string level = Console.ReadLine().ToUpper();
   
    
    //ask the question again if the incorrect option is choosen
    if (!levels.Contains(level))
    {
        Console.WriteLine("Invalid level selected. Please try again.");
        continue;
    }



    if (level == "E")
    {
             
        easyScore = PlayEasyQuiz(easyScore);

        Console.WriteLine("\r\nDo you want to play the next level? (Y)es or (N)o");
        string answer = Console.ReadLine().ToUpper();

        while (answer != "Y" && answer != "N")
        {
            Console.WriteLine("\r\nInvalid input. Please enter 'Y' for Yes or 'N' for No.");
            answer = Console.ReadLine().ToUpper();
        }

        if (answer == "N")
        {
            keepPlaying = false;
        }
        else if (answer == "Y")
        {
            Console.WriteLine("\r\nPlaying the medium level...");
            mediumScore = PlayMediumQuiz(mediumScore);

            Console.WriteLine("\r\nDo you want to play the next level? (Y)es or (N)o");
            answer = Console.ReadLine().ToUpper();

            while (answer != "Y" && answer != "N")
            {
                Console.WriteLine("\r\nInvalid input. Please enter 'Y' for Yes or 'N' for No.");
                answer = Console.ReadLine().ToUpper();
            }

            if (answer == "N")
            {
                keepPlaying = false;
            }
            else if (answer == "Y")
            {
                Console.WriteLine("\r\nPlaying the hard level...");
                hardScore = PlayHardQuiz(hardScore);
                keepPlaying = false;
            }
        }
    }

    else if (level == "M")
    {
        mediumScore = PlayMediumQuiz(mediumScore);

        Console.WriteLine("\r\nDo you want to play the next level? (Y)es or (N)o");
        string answer = Console.ReadLine().ToUpper();

        while (answer != "Y" && answer != "N")
        {
            Console.WriteLine("\r\nInvalid input. Please enter 'Y' for Yes or 'N' for No.");
            answer = Console.ReadLine().ToUpper();
        }

        if (answer == "N")
        {
            keepPlaying = false;
        }
        else if (answer == "Y")
        {
            Console.WriteLine("\r\nPlaying the hard level...");
            hardScore = PlayHardQuiz(hardScore);
            keepPlaying = false;
        }
    }

    else if (level == "H")
    {
        hardScore = PlayHardQuiz(hardScore);
        keepPlaying = false;
    }

}
Console.WriteLine($"\r\nThank you for playing {name}! Your final scores are: Easy: {easyScore}, Medium: {mediumScore}, Hard: {hardScore}");
Console.ReadLine();

static int PlayEasyQuiz(int score)
{
    Console.WriteLine("Easy Questions:");
    Console.WriteLine("------------------");

    Console.WriteLine("1. What is the Māori word for hello?");
    Console.WriteLine("a) Kia ora");
    Console.WriteLine("b) Haere mai");
    Console.WriteLine("c) Ka kite");
    Console.WriteLine("d) Nau mai");
    string answer1 = Console.ReadLine().ToUpper();
    
    //for incorrect options

    while (answer1 != "A" && answer1 != "B" && answer1 != "C" && answer1 != "D")
    {
        Console.WriteLine("\r\nyou have chosen an invalid option please enter another letter that fits into A-D");
        answer1 = Console.ReadLine().ToUpper();
    }
    if (answer1 == "A")
    {
        score++;
        Console.WriteLine($"\r\nCorrect point added! Your current score is {score}");
    }
    else
    {
        Console.WriteLine($"\r\nSorry, you have chosen an incorrect option. Your score is {score}.");
    }
   



    Console.WriteLine("2. What is the Māori word for goodbye?");
    Console.WriteLine("a) E noho rā");
    Console.WriteLine("b) Kia ora");
    Console.WriteLine("c) Haere mai");
    Console.WriteLine("d) Mā");
    string answer2 = Console.ReadLine().ToUpper();
    if (answer2 == "A")
    {
        score++;
        Console.WriteLine($"\r\nCorrect point added! Your current score is {score}");
    }
    else
    {
        Console.WriteLine($"\r\nSorry, you have chosen an incorrect option. Your score is {score}.");
    }

    Console.WriteLine($"\r\nThank you for playing the Easy Level. Your final score for this level is {score}.");
    return score;
}


// method called easy showing score and level



//easy ends


static int PlayMediumQuiz(int score)

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
        score++;
        Console.WriteLine($"\r\nCorrect point added! your current score is {score}");
    }

    else if (medium1 != "D")
    {
        Console.WriteLine($"\r\nSorry you have chosen an incorrect option, your score is {score}.");
    }
    Console.WriteLine("2. What is the Māori word for family?");
    Console.WriteLine("a) Whānau");
    Console.WriteLine("b) Mana");
    Console.WriteLine("c) Tapu");
    Console.WriteLine("d) Mauri");
    string medium2 = Console.ReadLine().ToUpper();
    if (medium2 == "A")
    {
        score++;
        Console.WriteLine($"\r\nCorrect point added! your current score is {score}");
    }
    else if (medium2 != "A")
    {
        Console.WriteLine($"\r\nSorry you have chosen an incorrect option, your score is {score}.");
    }

    Console.WriteLine($"\r\nThank you for playing the Medium Level. Your final score for this level is {score}.");
    return score;




}



static int PlayHardQuiz(int score)
{
    Console.WriteLine("Hard Questions:");
    Console.WriteLine("----------------");

    Console.WriteLine("1.If someone says: Kei te ngenge ahau, they are feeling ?");
    Console.WriteLine("a) tired");
    Console.WriteLine("b) drunk");
    Console.WriteLine("c) hungry");
    Console.WriteLine("d) sad");
    string hard1 = Console.ReadLine().ToUpper();
    if (hard1 == "A")
    {
        score++;
        Console.WriteLine($"\r\nCorrect point added your current score is {score}");
    }
    else if (hard1 != "A")
    {
        Console.WriteLine($"\r\nSorry you have chosen an incorrect option, your score is {score}.");
    }
    Console.WriteLine("2. What is the Māori word for goodbye?");
    Console.WriteLine("a) E noho rā");
    Console.WriteLine("b) Kia ora");
    Console.WriteLine("c) Haere mai");
    Console.WriteLine("d) Ma");
    string hard2 = Console.ReadLine().ToUpper();
    if (hard2 == "A")
    {
        score++;
        Console.WriteLine($"\r\nCorrect point added! your current score is {score}");
    }
    else if (hard2 != "A")
    {
        Console.WriteLine($"\r\nSorry you have chosen an incorrect option, your score is {score}.");
    }
    Console.WriteLine($"\r\nThank you for playing the Hard Level. Your final score for this level is {score}.");
    return score;
}

