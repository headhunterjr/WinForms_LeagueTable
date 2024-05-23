using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Team
    {
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int Points { get; set; }

        public Team(string name, int gamesPlayed, int goalsScored, int goalsConceded, int points)
        {
            Name = name;
            GamesPlayed = gamesPlayed;
            GoalsScored = goalsScored;
            GoalsConceded = goalsConceded;
            Points = points;
        }
        public override string ToString()
        {
            return $"{Name}, {GamesPlayed}, {GoalsScored}, {GoalsConceded}, {Points}";
        }
    }
}
