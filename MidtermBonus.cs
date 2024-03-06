namespace MidtermBonus{
using System;
  
class Program
{
    static void Main(string[] args)
    {
        int initialPoints = 5;

        while (initialPoints > 0)
        {
            Console.WriteLine("**** Rock, Paper, Scissors, Start!! ****");
            Console.WriteLine($"You have {initialPoints} points");

            HumanPlayer player = new HumanPlayer(initialPoints);
            ComputerPlayer computer = new ComputerPlayer(initialPoints);

            string humanDecision = player.HumanDecision();
            string computerDecision = computer.ComputerDecision();

            Console.WriteLine($"-->Your Decision: {humanDecision}");
            Console.WriteLine($"-->Computer Decision: {computerDecision}");

            if ((humanDecision == "rock" && computerDecision == "scissors") ||
                (humanDecision == "paper" && computerDecision == "rock") ||
                (humanDecision == "scissors" && computerDecision == "paper"))
            {
                Console.WriteLine("You Win!");
                player.WinRound();
                computer.LoseRound();
            }
            else if (humanDecision == computerDecision)
            {
                Console.WriteLine("It's a Tie!");
            }
            else
            {
                Console.WriteLine("Computer Wins!");
                player.LoseRound();
                computer.WinRound();
            }

            initialPoints = player.GetPoints();

            if (initialPoints <= 0)
            {
                Console.WriteLine("Sorry, you don't have enough points. Thanks for playing.");
                Console.WriteLine("Thank you for playing!");
                break;
            }

            Console.WriteLine("-->Play again? Input 'y' to continue, or 'n' to exit");
            string input = Console.ReadLine();
            if (input != "y")
            {
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
        Console.WriteLine("Please input your choice: rock, paper, or scissors");
        string decision = Console.ReadLine().ToLower();
        return decision;
    }
}

class ComputerPlayer
{
    private int points;

    public ComputerPlayer(int initial)
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

    public string ComputerDecision(){
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3);
        
        if (rnd_num == 0)
        {
            return "rock";
        }
        else if (rnd_num == 1)
        {
            return "paper";
        }
        else
        {
            return "scissors";
        }
    }
}}}
 
 


