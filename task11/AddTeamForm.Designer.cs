namespace task11
{
    partial class AddTeamForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxGP = new System.Windows.Forms.TextBox();
            this.textBoxGS = new System.Windows.Forms.TextBox();
            this.textBoxGC = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(35, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Games Played";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goals Conceded";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Goals Scored";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(969, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Points";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(143, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxGP
            // 
            this.textBoxGP.Location = new System.Drawing.Point(233, 63);
            this.textBoxGP.Name = "textBoxGP";
            this.textBoxGP.Size = new System.Drawing.Size(143, 22);
            this.textBoxGP.TabIndex = 6;
            // 
            // textBoxGS
            // 
            this.textBoxGS.Location = new System.Drawing.Point(477, 63);
            this.textBoxGS.Name = "textBoxGS";
            this.textBoxGS.Size = new System.Drawing.Size(143, 22);
            this.textBoxGS.TabIndex = 7;
            // 
            // textBoxGC
            // 
            this.textBoxGC.Location = new System.Drawing.Point(721, 63);
            this.textBoxGC.Name = "textBoxGC";
            this.textBoxGC.Size = new System.Drawing.Size(143, 22);
            this.textBoxGC.TabIndex = 8;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(948, 63);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(143, 22);
            this.textBoxPoints.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(477, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 63);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 185);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxGC);
            this.Controls.Add(this.textBoxGS);
            this.Controls.Add(this.textBoxGP);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Name = "AddTeamForm";
            this.Text = "AddTeam";
            this.Load += new System.EventHandler(this.AddTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxGP;
        private System.Windows.Forms.TextBox textBoxGS;
        private System.Windows.Forms.TextBox textBoxGC;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.Button buttonAdd;
    }
}