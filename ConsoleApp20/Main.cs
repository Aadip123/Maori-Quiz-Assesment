
// Define variables to keep track of the scores for each level


internal class Program
{
    
    private static void Main(string[] args)
    {
       int easyScore = 0;
        int mediumScore = 0;
        int hardScore = 0;

       

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
            if (level.Contains("E"))
            {
                easyScore = PlayEasyQuiz(easyScore);
                Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
                string answer = Console.ReadLine().ToUpper();
                while (!answer.Contains("Y") && !answer.Contains("N"))
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                    answer = Console.ReadLine().ToUpper();
                }
                if (answer.Contains("N"))
                {
                    keepPlaying = false;
                }
                else if (answer.Contains("Y"))
                {
                    Console.WriteLine("Playing the medium level...");
                    mediumScore = PlayMediumQuiz(mediumScore);
                    Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
                    answer = Console.ReadLine().ToUpper();
                    while (!answer.Contains("Y") && !answer.Contains("N"))
                    {
                        Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                        answer = Console.ReadLine().ToUpper();
                    }
                    if (answer.Contains("N"))
                    {
                        keepPlaying = false;
                    }
                    else if (answer.Contains("Y"))
                    {
                        Console.WriteLine("Playing the hard level...");
                        hardScore = PlayHardQuiz(hardScore);
                        keepPlaying = false;
                    }
                }
            }
            
            else if (level.Contains("M") )
            {
                mediumScore = PlayMediumQuiz(mediumScore);
                Console.WriteLine("Do you want to play the next level? (Y)es or (N)o");
                string answer = Console.ReadLine().ToUpper();
                while (!answer.Contains("Y") && !answer.Contains("N"))
                {
                    Console.WriteLine("Invalid input. Please enter 'Y' for Yes or 'N' for No.");
                    answer = Console.ReadLine().ToUpper();
                }
                if (answer.Contains("N"))
                {
                    keepPlaying = false;
                }
                else if (answer.Contains("Y"))
                {
                    Console.WriteLine("Playing the hard level...");
                    hardScore = PlayHardQuiz(hardScore);
                    keepPlaying = false;
                }
            }
        
            else if (level.Contains("H"))
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
                Console.WriteLine("\nyour answer is correct point added!");
                score++;
            }
            else { Console.WriteLine("\nyour answer is incorrect"); }

        }
        Console.WriteLine($"\nThank you for playing the easy level! your score is {score}");
        Thread.Sleep(1000);
        Console.Clear();
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
                Console.WriteLine("\nyour answer is correct point added!");
                score++;
            }
            else { Console.WriteLine("your answer is incorrect"); }

            

        }
        Console.WriteLine($"Thank you for playing the medium level! your score is {score}");
        Thread.Sleep(1000);
        Console.Clear();
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
          "C", "D", "D"
    };
        for (int i = 0; i < Hardanswers.Length; i++)
        {
            Console.WriteLine(Hard[i]);
            string useranswer = Console.ReadLine().ToUpper();
            if (useranswer.Contains(Hardanswers[i]))

            {
                Console.WriteLine("\nyour answer is correct point added!");
                score++;
            }
            else { Console.WriteLine("your answer is incorrect"); }

        }
        Console.WriteLine($"Thank you for playing the Hard level! your score is {score}");

        Console.Clear();
        Thread.Sleep(1000);
        return score;
    }

}




