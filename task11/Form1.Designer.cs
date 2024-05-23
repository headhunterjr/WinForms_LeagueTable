namespace task11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.contextMenuStripSortOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gamesPlayedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesPlayedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsScoredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goalsConcededToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBoxPointsList = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGoalDifferenceList = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGamesPlayedList = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNameList = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBoxPoints = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGoalDifference = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGamesPlayed = new System.Windows.Forms.RichTextBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStripSortOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 70);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(271, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(407, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Premier League Teams";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRead);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.buttonSort);
            this.panel2.Controls.Add(this.buttonWrite);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 511);
            this.panel2.TabIndex = 1;
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(27, 6);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(126, 65);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(12, 422);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(167, 65);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.ContextMenuStrip = this.contextMenuStripSortOptions;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(27, 323);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(126, 65);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // contextMenuStripSortOptions
            // 
            this.contextMenuStripSortOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSortOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesPlayedToolStripMenuItem,
            this.gamesPlayedToolStripMenuItem1,
            this.goalsScoredToolStripMenuItem,
            this.goalsConcededToolStripMenuItem,
            this.pointsToolStripMenuItem});
            this.contextMenuStripSortOptions.Name = "contextMenuStripSortOptions";
            this.contextMenuStripSortOptions.Size = new System.Drawing.Size(187, 124);
            // 
            // gamesPlayedToolStripMenuItem
            // 
            this.gamesPlayedToolStripMenuItem.Name = "gamesPlayedToolStripMenuItem";
            this.gamesPlayedToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.gamesPlayedToolStripMenuItem.Text = "Name";
            this.gamesPlayedToolStripMenuItem.Click += new System.EventHandler(this.gamesPlayedToolStripMenuItem_Click);
            // 
            // gamesPlayedToolStripMenuItem1
            // 
            this.gamesPlayedToolStripMenuItem1.Name = "gamesPlayedToolStripMenuItem1";
            this.gamesPlayedToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.gamesPlayedToolStripMenuItem1.Text = "Games Played";
            this.gamesPlayedToolStripMenuItem1.Click += new System.EventHandler(this.gamesPlayedToolStripMenuItem1_Click);
            // 
            // goalsScoredToolStripMenuItem
            // 
            this.goalsScoredToolStripMenuItem.Name = "goalsScoredToolStripMenuItem";
            this.goalsScoredToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.goalsScoredToolStripMenuItem.Text = "Goals Scored";
            this.goalsScoredToolStripMenuItem.Click += new System.EventHandler(this.goalsScoredToolStripMenuItem_Click);
            // 
            // goalsConcededToolStripMenuItem
            // 
            this.goalsConcededToolStripMenuItem.Name = "goalsConcededToolStripMenuItem";
            this.goalsConcededToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.goalsConcededToolStripMenuItem.Text = "Goals Conceded";
            this.goalsConcededToolStripMenuItem.Click += new System.EventHandler(this.goalsConcededToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(27, 252);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(126, 65);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(27, 181);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 65);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(27, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 65);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(802, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Name",
            "Games Played",
            "Goals Scored",
            "Goals Conceded",
            "Points"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search query";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(185, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 511);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.richTextBoxPointsList);
            this.panel5.Controls.Add(this.richTextBoxGoalDifferenceList);
            this.panel5.Controls.Add(this.richTextBoxGamesPlayedList);
            this.panel5.Controls.Add(this.richTextBoxNameList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 462);
            this.panel5.TabIndex = 6;
            // 
            // richTextBoxPointsList
            // 
            this.richTextBoxPointsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxPointsList.Enabled = false;
            this.richTextBoxPointsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPointsList.Location = new System.Drawing.Point(597, 0);
            this.richTextBoxPointsList.Name = "richTextBoxPointsList";
            this.richTextBoxPointsList.Size = new System.Drawing.Size(199, 462);
            this.richTextBoxPointsList.TabIndex = 7;
            this.richTextBoxPointsList.Text = "";
            // 
            // richTextBoxGoalDifferenceList
            // 
            this.richTextBoxGoalDifferenceList.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxGoalDifferenceList.Enabled = false;
            this.richTextBoxGoalDifferenceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGoalDifferenceList.Location = new System.Drawing.Point(398, 0);
            this.richTextBoxGoalDifferenceList.Name = "richTextBoxGoalDifferenceList";
            this.richTextBoxGoalDifferenceList.Size = new System.Drawing.Size(199, 462);
            this.richTextBoxGoalDifferenceList.TabIndex = 6;
            this.richTextBoxGoalDifferenceList.Text = "";
            // 
            // richTextBoxGamesPlayedList
            // 
            this.richTextBoxGamesPlayedList.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxGamesPlayedList.Enabled = false;
            this.richTextBoxGamesPlayedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGamesPlayedList.Location = new System.Drawing.Point(199, 0);
            this.richTextBoxGamesPlayedList.Name = "richTextBoxGamesPlayedList";
            this.richTextBoxGamesPlayedList.Size = new System.Drawing.Size(199, 462);
            this.richTextBoxGamesPlayedList.TabIndex = 5;
            this.richTextBoxGamesPlayedList.Text = "";
            // 
            // richTextBoxNameList
            // 
            this.richTextBoxNameList.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxNameList.Enabled = false;
            this.richTextBoxNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNameList.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxNameList.Name = "richTextBoxNameList";
            this.richTextBoxNameList.Size = new System.Drawing.Size(199, 462);
            this.richTextBoxNameList.TabIndex = 4;
            this.richTextBoxNameList.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBoxPoints);
            this.panel4.Controls.Add(this.richTextBoxGoalDifference);
            this.panel4.Controls.Add(this.richTextBoxGamesPlayed);
            this.panel4.Controls.Add(this.richTextBoxName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 49);
            this.panel4.TabIndex = 5;
            // 
            // richTextBoxPoints
            // 
            this.richTextBoxPoints.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxPoints.Enabled = false;
            this.richTextBoxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPoints.Location = new System.Drawing.Point(597, 0);
            this.richTextBoxPoints.Name = "richTextBoxPoints";
            this.richTextBoxPoints.Size = new System.Drawing.Size(199, 49);
            this.richTextBoxPoints.TabIndex = 3;
            this.richTextBoxPoints.Text = "";
            // 
            // richTextBoxGoalDifference
            // 
            this.richTextBoxGoalDifference.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxGoalDifference.Enabled = false;
            this.richTextBoxGoalDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGoalDifference.Location = new System.Drawing.Point(398, 0);
            this.richTextBoxGoalDifference.Name = "richTextBoxGoalDifference";
            this.richTextBoxGoalDifference.Size = new System.Drawing.Size(199, 49);
            this.richTextBoxGoalDifference.TabIndex = 2;
            this.richTextBoxGoalDifference.Text = "";
            // 
            // richTextBoxGamesPlayed
            // 
            this.richTextBoxGamesPlayed.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxGamesPlayed.Enabled = false;
            this.richTextBoxGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxGamesPlayed.Location = new System.Drawing.Point(199, 0);
            this.richTextBoxGamesPlayed.Name = "richTextBoxGamesPlayed";
            this.richTextBoxGamesPlayed.Size = new System.Drawing.Size(199, 49);
            this.richTextBoxGamesPlayed.TabIndex = 1;
            this.richTextBoxGamesPlayed.Text = "";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxName.Enabled = false;
            this.richTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxName.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(199, 49);
            this.richTextBoxName.TabIndex = 0;
            this.richTextBoxName.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 581);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStripSortOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxGoalDifference;
        private System.Windows.Forms.RichTextBox richTextBoxGamesPlayed;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBoxNameList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBoxPoints;
        private System.Windows.Forms.RichTextBox richTextBoxPointsList;
        private System.Windows.Forms.RichTextBox richTextBoxGoalDifferenceList;
        private System.Windows.Forms.RichTextBox richTextBoxGamesPlayedList;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSortOptions;
        private System.Windows.Forms.ToolStripMenuItem gamesPlayedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesPlayedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goalsScoredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goalsConcededToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRead;
    }
}

