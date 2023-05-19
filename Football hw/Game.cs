using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Football_hw.Program;

namespace Football_hw
{
    public class Game
    {
        public Team Team1 { get; set; }

        public Team Team2 { get; set; }

        public Referee Referee { get; set; }

        public List<Referee> AssistantReferees { get; set; } = new List<Referee>();

        public List<Goal> Goals { get; set; } = new List<Goal>();

        public void RecordGoal(Player scoringPlayer, int minute)
        {
            Goals.Add(new Goal { Player = scoringPlayer, Minute = minute });
        }

        

        public string GameResult
        {
            get
            {
                int team1Goals = Goals.Count(g => Team1.Players.Contains(g.Player));
                int team2Goals = Goals.Count(g => Team2.Players.Contains(g.Player));
                return $"Team 1: {team1Goals}, Team 2: {team2Goals}";
            }
        }

        public Team Winner
        {
            get
            {
                int team1Goals = Goals.Count(g => Team1.Players.Contains(g.Player));
                int team2Goals = Goals.Count(g => Team2.Players.Contains(g.Player));

                if (team1Goals > team2Goals)
                    return Team1;
                else if (team2Goals > team1Goals)
                    return Team2;
                else
                    return null;
            }
        }
    }
}
