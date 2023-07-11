namespace BonusExamQuestion;
public void PlayRound()
{
// Get the choice of each player
string choice1 = player1.HumanDecision();
string choice2 = player2.ComputerDecision();

// Determine the winner based on the choices
string winner = DetermineWinner(choice1, choice2);

// Update the points of the players
if (winner == "player1")
{
player1.WinRound();
player2.LoseRound();
Console.WriteLine("You win the round!");
}
else if (winner == "player2")
{
player2.WinRound();
player1.LoseRound();
Console.WriteLine("You lose the round!");
}
else
{
Console.WriteLine("It's a tie!");
}

// Print the points of human player
Console.WriteLine("Your points: " + player1.GetPoints());

// Check if the game should continue
if (player1.GetPoints() <= 0)
{
Console.WriteLine("Sorry, you don't have enough points. Thanks for playing!");
return;
}

// Ask the player to continue or exit
Console.WriteLine("Play again? Input 'y' to continue, or 'n' to exit");
string input = Console.ReadLine();

if (input.ToLower() == "n")
{
    Console.WriteLine("Thank you for playing!");
return;
}

// Clear the console for the next round
Console.Clear();
}