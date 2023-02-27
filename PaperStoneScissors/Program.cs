using System.Reflection.Emit;
using System.Runtime.CompilerServices;
int userInputLevel;

while (true)
{
    Menu();
    userInputLevel = Convert.ToInt32(Console.ReadLine());
    if (userInputLevel == 1)
    {
        Console.Clear();
        Game();
    }
   

}






static void Menu()
{
    Console.WriteLine("Choose Level");
    Console.WriteLine("1 - Normal");
    Console.WriteLine("2 - Hard  *Not Completed*");
}

static void Choose()
{
    Console.WriteLine("1 - Paper");
    Console.WriteLine("2 - Stone");
    Console.WriteLine("3 - Scissors");
}


static void Game()
{
    Random generator = new Random();



    int userScore = 0, userInput, computerScore = 0, computerPick;


    while (true)
    {
        Choose();
        try
        {
            userInput = Convert.ToInt32(Console.ReadLine());

            computerPick = generator.Next(1, 4);

            if (userInput == computerPick)
            {
                Console.WriteLine("Draw");
                Console.WriteLine("User and Computer pick same thing.");

            }
            else if ((userInput == 1) && (computerPick == 2))
            {
                Console.WriteLine("User: Paper");
                Console.WriteLine("Computer: Stone");
                Console.WriteLine("User Won this round!");
                userScore = userScore + 1;


            }
            else if ((userInput == 1) && (computerPick == 3))
            {
                Console.WriteLine("User: Paper");
                Console.WriteLine("Computer: Scissors");
                Console.WriteLine("Computer Won this round!");
                computerScore = computerScore + 1;


            }
            else if ((userInput == 2) && (computerPick == 1))
            {
                Console.WriteLine("User: Stone");
                Console.WriteLine("Computer: Paper");
                Console.WriteLine("Computer Won this round!");
                computerScore = computerScore + 1;


            }
            else if ((userInput == 2) && (computerPick == 3))
            {
                Console.WriteLine("User: Stone");
                Console.WriteLine("Computer: Scissors");
                Console.WriteLine("User Won this round!");
                userScore = userScore + 1;


            }
            else if ((userInput == 3) && (computerPick == 1))
            {
                Console.WriteLine("User: Scissors");
                Console.WriteLine("Computer: Paper");
                Console.WriteLine("User Won this round!");
                userScore = userScore + 1;


            }
            else if ((userInput == 3) && (computerPick == 2))
            {
                Console.WriteLine("User: Scissors");
                Console.WriteLine("Computer: Stone");
                Console.WriteLine("Computer Won this round!");
                computerScore = computerScore + 1;


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"User Score is: {userScore}");
            Console.WriteLine($"Computer Score is: {computerScore}");
            Console.WriteLine("*Click any key to continue*");
            Console.ReadKey();
            Console.Clear();

            if ((userScore >= 3)||(computerScore >=3 ))
             {
                Console.Clear();

                if(userScore > computerScore)
                {
                    Console.WriteLine("User Won!");
                    Console.WriteLine($"User: {userScore} vs Computer: {computerScore}");
                }
                else
                {
                    Console.WriteLine("Computer Won!");
                    Console.WriteLine($"User: {userScore} vs Computer: {computerScore}");
                }
                Console.WriteLine("");
                break;
                
             }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid pick");
        }

    }

    

}