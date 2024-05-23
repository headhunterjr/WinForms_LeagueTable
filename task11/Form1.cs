using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task11
{
    public partial class Form1 : Form
    {
        private List<Team> teams = new List<Team>();
        public static bool sortOrder = true;
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearWindow()
        {
            richTextBoxNameList.Clear();
            richTextBoxGamesPlayedList.Clear();
            richTextBoxGoalDifferenceList.Clear();
            richTextBoxPointsList.Clear();
        }
        public void PrintInWindow()
        {
            foreach (Team team in teams)
            {
                richTextBoxNameList.Text += team.Name + "\n";
                richTextBoxGamesPlayedList.Text += team.GamesPlayed + "\n";
                richTextBoxGoalDifferenceList.Text += (team.GoalsScored - team.GoalsConceded).ToString() + "\n";
                richTextBoxPointsList.Text += team.Points + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxName.Text = "Name";
            richTextBoxGamesPlayed.Text = "Games Played";
            richTextBoxGoalDifference.Text = "Goal Difference";
            richTextBoxPoints.Text = "Points";
            //Functions.ReadFromFile(teams);
            PrintInWindow();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var addTeamForm = new AddTeamForm())
            {
                if (addTeamForm.ShowDialog() == DialogResult.OK)
                {
                    string name = addTeamForm.TeamName;
                    int gamesPlayed = addTeamForm.GamesPlayed;
                    int goalsScored = addTeamForm.GoalsScored;
                    int goalsConceded = addTeamForm.GoalsConceded;
                    int points = addTeamForm.Points;

                    Team newTeam = new Team(name, gamesPlayed, goalsScored, goalsConceded, points);
                    Functions.AddTeam(teams, newTeam);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            teams.Clear();
            ClearWindow();
            Functions.ReadFromFile(teams);
            Form1_Load(sender, e);
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            using (var writeInfoForm = new WriteInfo())
            {
                if (writeInfoForm.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = "C:\\Users\\anchiforov\\PracticeC#\\task11\\task11\\" + WriteInfo.WriteFileName;

                    if (!File.Exists(destinationFilePath))
                    {
                        try
                        {
                            using (FileStream fs = File.Create(destinationFilePath))
                            {
                                Console.WriteLine("Destination file created successfully.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error creating destination file: {ex.Message}");
                            return; 
                        }
                    }

                    try
                    {
                        using(StreamWriter streamWriter = new StreamWriter(destinationFilePath))
                        {
                            foreach (Team team in teams)
                            {
                                streamWriter.WriteLine(team);
                            }
                        }
                        Console.WriteLine("File contents copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error copying file contents: {ex.Message}");
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            buttonRefresh_Click(sender, e);
            groupBox1.Visible = true;
            groupBox1.Location = new Point(buttonSearch.Left, buttonSearch.Top);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            using (SortOrder sortOrderWindow = new SortOrder())
            {
                sortOrderWindow.ShowDialog();
            }
            contextMenuStripSortOptions.Show(buttonSort, new Point(0, buttonSort.Height));
        }

        private void gamesPlayedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortOrder)
            {
                teams = teams.OrderBy(team => team.Name).ThenBy(team => team.Points).ToList();
            }
            else
            {
                teams = teams.OrderByDescending(team => team.Name).ThenByDescending(team => team.Points).ToList();
            }
            ClearWindow();
            PrintInWindow();
        }

        private void gamesPlayedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sortOrder)
            {
                teams = teams.OrderBy(team => team.GamesPlayed).ThenBy(team => team.Name).ToList();
            }
            else
            {
                teams = teams.OrderByDescending(team => team.GamesPlayed).ThenByDescending(team => team.Name).ToList();
            }
            ClearWindow();
            PrintInWindow();
        }

        private void goalsScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortOrder)
            {
                teams = teams.OrderBy(team => team.GoalsScored).ThenBy(team => team.Name).ToList();
            }
            else
            {
                teams = teams.OrderByDescending(team => team.GoalsScored).ThenByDescending(team => team.Name).ToList();
            }
            ClearWindow();
            PrintInWindow();
        }

        private void goalsConcededToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortOrder)
            {
                teams = teams.OrderBy(team => team.GoalsScored).ThenBy(team => team.Name).ToList();
            }
            else
            {
                teams = teams.OrderByDescending(team => team.GoalsScored).ThenByDescending(team => team.Name).ToList();
            }
            ClearWindow();
            PrintInWindow();
        }

        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortOrder)
            {
                teams = teams.OrderBy(team => team.Points).ThenBy(team => team.Name).ToList();
            }
            else
            {
                teams = teams.OrderByDescending(team => team.Points).ThenByDescending(team => team.Name).ToList();
            }
            ClearWindow();
            PrintInWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            string checkedItem = listBox1.Text;
            teams = Functions.FindByField(teams, checkedItem, textBox1.Text);
            ClearWindow();
            PrintInWindow();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C\";
                openFileDialog.Filter = "txt files |*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Functions.FileName = openFileDialog.FileName;
                }
            }
            try
            {
                Functions.ReadFromFile(teams);
                ClearWindow();
                PrintInWindow();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not read file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
