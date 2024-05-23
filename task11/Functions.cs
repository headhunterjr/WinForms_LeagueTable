using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task11
{
    internal class Functions
    {
        private static string fileName = "";
        public static string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public static void ReadFromFile(List<Team> teams)
        {
            string[] lines = File.ReadAllLines(fileName);
            teams.Clear();
            foreach (string line in lines)
            {
                string[] components = line.Split(',');
                if (!teams.Select(team => team).Where(team => team.Name == components[0]).Any())
                {
                    if (int.Parse(components[1].Trim()) < 0 || int.Parse(components[2]) < 0 || int.Parse(components[3]) < 0)
                    {
                        MessageBox.Show("Numeric data can not be below zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        teams.Add(new Team(components[0], int.Parse(components[1].Trim()), int.Parse(components[2].Trim()), int.Parse(components[3].Trim()), int.Parse(components[4].Trim())));
                    }
                }
            }
        }
        public static void AddTeam(List<Team> teams, Team team)
        {
            teams.Add(team);
            using (StreamWriter streamWriter = new StreamWriter(fileName, true))
            {
                streamWriter.Write("\n" + team.ToString());
            }
        }
        public static List<Team> FindByField(List<Team> teams, string field, string val)
        {
            var query = from team in teams select team;
            switch (field)
            {
                case "Name":
                    query = from team in teams
                                where team.Name == val
                                select team;
                    break;
                case "Games Played":
                    query = from team in teams
                            where team.GamesPlayed.ToString() == val
                            select team;
                    break;
                case "Goals Scored":
                    query = from team in teams
                            where team.GoalsScored.ToString() == val
                            select team; 
                    break;
                case "Goals Conceded":
                    query = from team in teams
                            where team.GoalsConceded.ToString() == val
                            select team;
                    break;
                case "Points":
                    query = from team in teams
                            where team.Points.ToString() == val
                            select team;
                    break;
                default:
                    break;
            }
            return query.ToList();
        }
    }
}
