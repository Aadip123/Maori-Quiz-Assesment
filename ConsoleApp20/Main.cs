
// Define variables to keep track of the scores for each level


internal class Program
{
    
    private static void Main(string[] args)
    {
       int easyScore = 0;
        int mediumScore = 0;
        int hardScore = 0;

        int[] scores = new int[3];

        //array for levels
        string[] levels = { "E", "M", "H" };


        // Print out welcome messages and get the user's name
        Console.WriteLine("Welcome to the Māori Quiz!");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Please enter your name");

        //storing the name in a variable

        // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();

        // Converting null literal or possible null value to non-nullable type.
        Console.WriteLine($"Welcome {name}, we will start the quiz now");


        // Pause for 1 second and then clear the console
        Thread.Sleep(1000);
        Console.Clear();





        bool keepPlaying = true;
        while (keepPlaying)
        {
            Console.WriteLine("Select a difficulty level: (E)asy, (M)edium, or (H)ard");
            string level = Console.ReadLine().ToUpper();
            if (!levels.Contains(level))
            {
                Console.WriteLine("Invalid level selected. Please try again.");
                continue;
            }
            if (level == "E")
            {
                easyScore = PlayEasyQuiz(easyScore);
                Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
                string answer = Console.ReadLine().ToUpper();
                while (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                    answer = Console.ReadLine().ToUpper();
                }
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
                    while (answer != "Y" && answer != "N")
                    {
                        Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                        answer = Console.ReadLine().ToUpper();
                    }
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
                string answer = Console.ReadLine().ToUpper();
                while (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                    answer = Console.ReadLine().ToUpper();
                }
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
            else if (level == "H")
            {
                hardScore = PlayHardQuiz(hardScore);
                keepPlaying = false;
            }
        }
        Console.WriteLine($"Thank you for playing! Your final scores are: Easy: {easyScore}, Medium: {mediumScore}, Hard: {hardScore}");
        Console.ReadLine();


    }

    // end of main method


    static int PlayEasyQuiz(int score)
    {

        string[] Easy = new string[] {

        "Easy Questions:\n------------------\n 1. What is the Māori word for hello? \na) Kia ora \nb) Haere mai \nc) Ka kite \nd) Nau mai",
        "Easy Questions:\n------------------\n 2. What is the Māori word for goodbye? \na) Ka kite \nb) Haere rā \nc) Nau mai \nd) Kia ora",
        "Easy Questions:\n------------------\n 3. What is the Māori word for love? \na) Aroha \nb) Mana \nc) Whakapapa \nd) Kaitiakitanga"
        };

        string[] easyanswers = new string[]
        {
         "A", "A", "A"
        };
        for (int i = 0; i < easyanswers.Length; i++)
        {
            Console.WriteLine(Easy[i]);
            string useranswer = Console.ReadLine().ToUpper();
            if (useranswer.Contains(easyanswers[i]))

            {
                Console.WriteLine("\nyou answer is correct point added!");
                score++;
            }
            else { Console.WriteLine("\nyour answer is incorrect"); }

        }
        Console.WriteLine($"\nThank you for playing the easy level! your score is {score}");
        return score;
    }







    // Array of questions for each level

    static int PlayMediumQuiz(int score)
    {
        string[] Medium = new string[] {

    "Medium Questions:\n--------------------\n 1. What is the meaning of the Māori word 'tino'? \na) Very \nb) Only \nc) Happy \nd) Again",
        "Medium Questions:\n--------------------\n 2. Which of the following is NOT one of the three baskets of knowledge in Māori tradition? \na) Te Kete Aronui \nb) Te Kete Tuauri \nc) Te Kete Tuatea \nd) Te Kete Wananga",
        "Medium Questions:\n--------------------\n 3. What is the name of the Māori god of the sea? \na) Tāne \nb) Rongo \nc) Tangaroa \nd) Tūmatauenga"

    };
        string[] Mediumanswers = new string[]
       {
          "A", "C", "C"
    };
        for (int i = 0; i < Mediumanswers.Length; i++)
        {
            Console.WriteLine(Medium[i]);
            string useranswer = Console.ReadLine().ToUpper();
            if (useranswer.Contains(Mediumanswers[i]))

            {
                Console.WriteLine("\nyou answer is correct point added!");
                score++;
            }
            else { Console.WriteLine("your answer is incorrect"); }

        }
        Console.WriteLine($"Thank you for playing the medium level! your score is {score}");
        return score;
    }


    static int PlayHardQuiz(int score)
    {
        string[] Hard = new string[] {
        "Hard Questions:\n------------------\n 1. Who was the first Māori king? \na) Tāwhiao \nb) Te Rata \nc) Potatau Te Wherowhero \nd) Te Kooti",
            "Hard Questions:\n------------------\n 2. What is the name of the Māori creation story? \na) Te Kaha o te Rangatahi \nb) Te Awa Tupua \nc) Te Aitanga a Hauiti \nd) Te Kore",
            "Hard Questions:\n------------------\n 3. What is the Māori word for the Southern Cross constellation? \na) Matariki \nb) Atutahi \nc) Tautoru \nd) Māhutonga"
    };
        string[] Hardanswers = new string[]
       {
          "A", "B", "C"
    };
        for (int i = 0; i < Hardanswers.Length; i++)
        {
            Console.WriteLine(Hard[i]);
            string useranswer = Console.ReadLine().ToUpper();
            if (useranswer.Contains(Hardanswers[i]))

            {
                Console.WriteLine("\nyou answer is correct point added!");
                score++;
            }
            else { Console.WriteLine("your answer is incorrect"); }

        }
        Console.WriteLine($"Thank you for playing the medium level! your score is {score}");
        return score;
    }

}




// Prompt the user to play again or quit



// Check if the user wants to play next level


/*if (level == "E")
{

    string[] easyquestions = {"Easy Questions:\n------------------\n 1. What is the Māori word for hello? \na) Kia ora \nb) Haere mai \nc) Ka kite \nd) Nau mai", "what is blue" };
    string[] easyanswers ={ "A","blue" };


    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine(easyquestions[i]);
        string useranswer = Console.ReadLine().ToUpper();

        if (useranswer.Contains(easyanswers[i]))
        {
            Console.WriteLine("right");
        }
        else
        {
            Console.WriteLine("wrong");
        }
    }

    // saving the score with the return from the method     
    easyScore = PlayEasyQuiz(easyScore);


    // asks user if they want to play next level
    Console.WriteLine("\r\nDo you want to play the next level? (Y)es or (N)o");
    string answer = Console.ReadLine().ToUpper();

    // added a while loop so if the user enters an option that it not Y or N they will be asked to re enter a new number 
    while (answer != "Y" && answer != "N")
    {
        Console.WriteLine("\r\nInvalid input. Please enter 'Y' for Yes or 'N' for No.");
        answer = Console.ReadLine().ToUpper();
    }
    // added if statemnt for N and Y answers 
    if (answer == "N")
    {
        keepPlaying = false;
    }
    else if (answer == "Y")
    {
        Console.Clear();

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
            Console.Clear();

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
        Console.Clear();

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
return score;*/



