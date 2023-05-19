using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Football_hw.Program;

namespace Football_hw
{
    public class Team
    {
        public Coach Coach { get; set; }

        private List<Player> players = new List<Player>();
        public List<Player> Players
        {
            get { return players; }
            set { if (value.Count >= 11 && value.Count <= 22) { players = value; } }
        }

        public double AverageAge
        {
            get
            {
                if (Players.Count > 0)
                {
                    int totalAge = Players.Sum(x => x.Age);
                    return totalAge / (double)Players.Count;
                }
                else { throw new Exception("There can not be a team with 0 players"); }
            }

        }
    }
}
