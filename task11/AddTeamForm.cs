using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task11
{
    public partial class AddTeamForm : Form
    {
        public string TeamName;
        public int GamesPlayed;
        public int GoalsScored;
        public int GoalsConceded;
        public int Points;
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TeamName = textBoxName.Text;
                GamesPlayed = int.Parse(textBoxGP.Text);
                GoalsScored = int.Parse(textBoxGS.Text);
                GoalsConceded = int.Parse(textBoxGC.Text);
                Points = int.Parse(textBoxPoints.Text);
                DialogResult = DialogResult.OK;
                if (GoalsScored < 0 || GoalsConceded < 0 || GamesPlayed < 0)
                {
                    throw new Exception("Numeric values can not be below 0");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
