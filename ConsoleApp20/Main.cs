
int easyScore = 0;
int mediumScore = 0;
int hardScore = 0;

int[] scores = new int[3];
string[] levels = { "E", "M", "H" };

Console.WriteLine("Welcome to the Māori Quiz!");
Console.WriteLine("---------------------------");
Console.WriteLine("Please enter name");
string name = Console.ReadLine();
Console.WriteLine($"Welcome {name}, we will start the quiz now");
System.Threading.Thread.Sleep(3000);
Console.Clear();

bool keepPlaying = true;

while (keepPlaying)
{
    Console.WriteLine("Select a difficulty level: (E)asy, (M)edium, or (H)ard");
    string level = Console.ReadLine().ToUpper();

    if (level == "E")
    {
        easyScore = PlayEasyQuiz(easyScore);
        Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
        string answer = Console.ReadLine().ToUpper();

        if (answer == "N")
        {
            keepPlaying = false;
        }
        else if (answer == "Y")
        {
            Console.WriteLine("Playing the medium level...");
            mediumScore = PlayMediumQuiz(mediumScore);
            Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
            answer = Console.ReadLine().ToUpper();
            if (answer == "N")
            {
                keepPlaying = false;
            }
            else if (answer == "Y")
            {
                Console.WriteLine("Playing the hard level...");
                hardScore = PlayHardQuiz(hardScore);
                keepPlaying = false;
            }
        }
    }

    else if (level == "M")
    {
        mediumScore = PlayMediumQuiz(mediumScore);
        Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
         string answer1 = Console.ReadLine().ToUpper();
        if (answer1 == "N")
        {
            keepPlaying = false;
        }
        else if (answer1 == "Y")
        {
            Console.WriteLine("Playing the hard level...");
            hardScore = PlayHardQuiz(hardScore);
            keepPlaying = false;
        }
        else
        {
            Console.WriteLine("Invalid level selected. Please try again.");
            continue;
        }
    }
  

    Console.WriteLine($"Thank you for playing! Your final scores are: Easy: {easyScore}, Medium: {mediumScore}, Hard: {hardScore}");
    Console.ReadLine();

}

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
    if (answer1 == "A")
    {
        score++;
        Console.WriteLine($"Correct point added! Your current score is {score}");
    }
    else
    {
        Console.WriteLine($"Sorry, you have chosen an incorrect answer. Your score is {score}.");
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
        Console.WriteLine($"Correct point added! Your current score is {score}");
    }
    else
    {
        Console.WriteLine($"Sorry, you have chosen an incorrect answer. Your score is {score}.");
    }

    Console.WriteLine($"Thank you for playing the quiz. Your final score is {score}.");
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
            Console.WriteLine($"Correct point added! your current score is {score}");
        }

        else if (medium1 != "D")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {score}.");
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
            Console.WriteLine($"Correct point added! your current score is {score}");
        }
        else if (medium2 != "A")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {score}.");
        }
        

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
            Console.WriteLine($"Correct point added your current score is {score}");
        }
        else if (hard1 != "A")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {score}.");
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
            Console.WriteLine($"Correct point added! your current score is {score}");
        }
        else if (hard2 != "A")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {score}.");
        }
        Console.WriteLine($"Thank you for playing! this is the end of the quiz ");


    return score;



}

    





