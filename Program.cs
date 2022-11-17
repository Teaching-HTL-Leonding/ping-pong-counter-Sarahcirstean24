Console.Write("Game mode? ");
string gameMode = Console.ReadLine()!;
int numberOfGames = 0;
switch (gameMode)
{
    case "short": numberOfGames = 1; break;
    case "regular": numberOfGames = 4; break;
    case "double": numberOfGames = 3; break;
    
    do
    {
      Console.Write("How many games must be won to win the match: ");
      numberOfGames = int.Parse(Console.ReadLine()!);
    } while (numberOfGames < 0);
    break;
    default:
   Console.WriteLine("Match type wrong.");
   break;  
}
int gamesPlayer1 = 0, gamesPlayer2 = 0;

int pointsPlayer1 = 0, pointsPlayer2 = 0;
string scorer; 
int service = Random.Shared.Next(1, 3); 
do
{
    Console.WriteLine($"Player {service} has the service");

    Console.Write("Who won the point: ");
    scorer = Console.ReadLine()!;
    switch (scorer)
    {
        case "1":
        pointsPlayer1++;
        if (pointsPlayer1 == 11)
            {
                Console.WriteLine("Player 1 has won the game.\n");
                gamesPlayer1++;
                pointsPlayer1 = pointsPlayer2 = 0;
                service = Random.Shared.Next(1, 3); 
            }
            break;
        case "2":
        pointsPlayer2++;
            if (pointsPlayer2 == 11)
            {
                Console.WriteLine("Player 2 has won the game.\n");
                gamesPlayer2++;
                pointsPlayer1 = pointsPlayer2 = 0;
                service = Random.Shared.Next(1, 3); 
            }
            break;
    }

    Console.WriteLine($"Games: {gamesPlayer1}:{gamesPlayer2}, Points: {pointsPlayer1}:{pointsPlayer2}");

    if ((pointsPlayer1 + pointsPlayer2) % 2 == 0)
    {
        if (service == 1) { service = 2; }
        else { service = 1; }
    }
}
while (scorer != "q" && gamesPlayer1 != numberOfGames && gamesPlayer2 != numberOfGames);

if (scorer != "q") 
{
    int winner = 0;
    if (gamesPlayer1 == numberOfGames) { winner = 1; }
    else { winner = 2; }
    Console.WriteLine($"Congratulations, player {winner}, you have won the match!");
}




