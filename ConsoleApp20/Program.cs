
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System.Reflection.Emit;

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
System.Threading.Thread.Sleep(1000);
Console.Clear();

bool keepPlaying = true;

while (keepPlaying)
{
    Console.WriteLine("Select a difficulty level: (E)asy, (M)edium, or (H)ard");
    string level = Console.ReadLine().ToUpper();

    if (level == "E")
    {
        easyScore = PlayQuiz("Easy", easyScore);
    }
    else if (level == "M")
    {
        mediumScore = PlayQuiz("Medium", mediumScore);
    }
    else if (level == "H")
    {
        hardScore = PlayQuiz("Hard", hardScore);
    }
    else
    {
        Console.WriteLine("Invalid level selected. Please try again.");
        continue;
    }

    Console.WriteLine("Do you want to play again? (Y)es or (N)o");
    string answer = Console.ReadLine().ToUpper();

    if (answer == "N")
    {
        keepPlaying = false;
    }

    Console.WriteLine($"Thank you for playing! Your final scores are: Easy: {easyScore}, Medium: {mediumScore}, Hard: {hardScore}");
    Console.ReadLine();

}






// method called easy showing score and level



static int PlayQuiz(string levelName, int score)
    {
        Console.WriteLine($"{levelName} Questions:");
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

        Console.WriteLine($"Thank you for playing the {levelName} quiz. Your final score is {score}.");
        return score;
    }







//easy ends


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
        string medium2 = Console.ReadLine().ToUpper();
        if (medium2 == "A")
        {
            mediumScore++;
            Console.WriteLine($"Correct point added! your current score is {mediumScore}");
        }
        else if (medium2 != "A")
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
        string hard1 = Console.ReadLine().ToUpper();
        if (hard1 == "A")
        {
            hardScore++;
            Console.WriteLine($"Correct point added your current score is {hardScore}");
        }
        else if (hard1 != "A")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {hardScore}.");
        }
        Console.WriteLine("2. What is the Māori word for goodbye?");
        Console.WriteLine("a) E noho rā");
        Console.WriteLine("b) Kia ora");
        Console.WriteLine("c) Haere mai");
        Console.WriteLine("d) Ma");
        string hard2 = Console.ReadLine().ToUpper();
        if (hard2 == "A")
        {
            hardScore++;
            Console.WriteLine($"Correct point added! your current score is {hardScore}");
        }
        else if (hard2 != "A")
        {
            Console.WriteLine($"Sorry you have chosen an incorrect answer, your score is {hardScore}.");
        }
        Console.WriteLine($"Thank you for playing! this is the end of the quiz ");


    }

    return hardScore;
}




