namespace RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        RockPaperScissors game = new RockPaperScissors(5);

        while (!game.IsGameOver())
        {
            game.PlayRound();

            if (game.IsGameOver())
            {
                Console.WriteLine("Sorry, you have no more points. Game over.");
                break;
            }

            if (!game.AskToPlayAgain())
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }
}

class HumanPlayer
{
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Please input your choice: rock, paper, or scissors.");
        string choice = Console.ReadLine()!.ToLower();
        while (choice != "rock" && choice != "paper" && choice != "scissors")
        {
            Console.WriteLine("Invalid input. Please choose Rock, Paper, or Scissors.");
            choice = Console.ReadLine()!.ToLower();
        }

        return choice;
    }
}

class ComputerPlayer
{
    private Random random;

    public ComputerPlayer()
    {
        random = new Random();
    }

    public string ComputerDecision()
    {
        int choice = random.Next(0, 3);
        switch (choice)
        {
            case 0: return "rock";
            case 1: return "paper";
            case 2: return "scissors";
            default: return "rock";
        }
    }
}

class RockPaperScissors
{
    private HumanPlayer human;
    private ComputerPlayer computer;

    public RockPaperScissors(int initialPoints)
    {
        human = new HumanPlayer(initialPoints);
        computer = new ComputerPlayer();
    }

    public void PlayRound()
    {
        Console.WriteLine($"You have {human.GetPoints()} points.");

        string humanChoice = human.HumanDecision();
        Console.WriteLine($"Your decision: {humanChoice}");

        string computerChoice = computer.ComputerDecision();
        Console.WriteLine($"Computer's decision: {computerChoice}");

        if (humanChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((humanChoice == "rock" && computerChoice == "scissors") || (humanChoice == "paper" && computerChoice == "rock") || (humanChoice == "scissors" && computerChoice == "paper"))
        { 
            Console.WriteLine("You win!");
            human.WinRound();
        }
        else
        {
            Console.WriteLine("You lose!");
            human.LoseRound();
        }
    }

    public bool IsGameOver()
    {
        return human.GetPoints() <= 0;
    }

    public bool AskToPlayAgain()
    {
        Console.WriteLine("Play again? Input \"y\" to continue or \"n\" to exit.");
        string playAgain = Console.ReadLine()!.ToLower();
        return playAgain == "y";
    }
}
