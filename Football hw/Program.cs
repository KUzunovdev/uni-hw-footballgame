namespace Football_hw
{
    public class Program
    {
        static void Main(string[] args)
        {

            //some code just to test if the logic works
            Random random = new Random();

           
            List<Player> team1Players = new List<Player>();
            List<Player> team2Players = new List<Player>();
            for (int i = 0; i < 11; i++)
            {
                team1Players.Add(new Player { Name = $"Player {i + 1}", Age = random.Next(20, 35), Height = random.Next(170, 200) });
                team2Players.Add(new Player { Name = $"Player {i + 1}", Age = random.Next(20, 35), Height = random.Next(170, 200) });
            }

            Team team1 = new Team { Coach = new Coach { Name = "Coach 1", Age = 50 }, Players = team1Players };
            Team team2 = new Team { Coach = new Coach { Name = "Coach 2", Age = 55 }, Players = team2Players };

            Game game = new Game { Team1 = team1, Team2 = team2, Goals = new List<Goal>() };
            //there can be 2 goals at the same minute i havent added validation for that

            for (int i = 0; i < 10; i++)
            {
                int randomMinute = random.Next(91);
                if (random.Next(2) == 0)
                {
                    Player scoringPlayer = team1.Players[random.Next(11)];
                    game.Goals.Add(new Goal { Player = scoringPlayer, Minute = randomMinute });
                }
                else
                {
                    Player scoringPlayer = team2.Players[random.Next(11)];
                    game.Goals.Add(new Goal { Player = scoringPlayer, Minute = randomMinute });
                }
            }

            var orderedGoals = game.Goals.OrderBy(g => g.Minute);
            foreach (var goal in orderedGoals)
            {
                Console.WriteLine($"Goal at minute {goal.Minute} by {goal.Player.Name}");
            }

            
            Console.WriteLine($"Game result: {game.GameResult}");
            //the team does not have a property for name so i am printing the coach name 
            Console.WriteLine($"The winner is: {(game.Winner == null ? "Draw" : game.Winner.Coach.Name)}");

            Console.ReadKey();
        }

        }
}