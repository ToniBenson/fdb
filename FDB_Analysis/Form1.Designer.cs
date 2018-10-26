namespace FDB_Analysis
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeamAway = new System.Windows.Forms.ComboBox();
            this.btStartAnalysis = new System.Windows.Forms.Button();
            this.lbAwayTeam = new System.Windows.Forms.Label();
            this.cbTeamHome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "@";
            // 
            // cbTeamAway
            // 
            this.cbTeamAway.FormattingEnabled = true;
            this.cbTeamAway.Items.AddRange(new object[] {
            "Arizona Cardinals",
            "Atlanta Falcons",
            "Baltimore Ravens",
            "Buffalo Bills",
            "Carolina Panthers",
            "Chicago Bears",
            "Cincinnati Bengals",
            "Cleveland Browns",
            "Dallas Cowboys",
            "Denver Broncos",
            "Detroit Lions",
            "Green Bay Packers",
            "Houston Texans",
            "Indianapolis Colts",
            "Jacksonville Jaguars",
            "Kansas City Chiefs",
            "Los Angeles Chargers",
            "Los Angeles Rams",
            "Miami Dolphins",
            "Minnesota Vikings",
            "New England Patriots",
            "New Orleans Saints",
            "New York Giants",
            "New York Jets",
            "Oakland Raiders",
            "Philadelphia Eagles",
            "Pittsburgh Steelers",
            "San Francisco 49ers",
            "Seattle Seahawks",
            "Tampa Bay Buccaneers",
            "Tennessee Titans",
            "Washington Redskins"});
            this.cbTeamAway.Location = new System.Drawing.Point(44, 84);
            this.cbTeamAway.Name = "cbTeamAway";
            this.cbTeamAway.Size = new System.Drawing.Size(226, 21);
            this.cbTeamAway.TabIndex = 1;
            // 
            // btStartAnalysis
            // 
            this.btStartAnalysis.Location = new System.Drawing.Point(587, 80);
            this.btStartAnalysis.Name = "btStartAnalysis";
            this.btStartAnalysis.Size = new System.Drawing.Size(141, 27);
            this.btStartAnalysis.TabIndex = 2;
            this.btStartAnalysis.Text = "analyse";
            this.btStartAnalysis.UseVisualStyleBackColor = true;
            this.btStartAnalysis.Click += new System.EventHandler(this.btStartAnalysis_Click);
            // 
            // lbAwayTeam
            // 
            this.lbAwayTeam.AutoSize = true;
            this.lbAwayTeam.Location = new System.Drawing.Point(41, 121);
            this.lbAwayTeam.Name = "lbAwayTeam";
            this.lbAwayTeam.Size = new System.Drawing.Size(35, 13);
            this.lbAwayTeam.TabIndex = 3;
            this.lbAwayTeam.Text = "label2";
            // 
            // cbTeamHome
            // 
            this.cbTeamHome.FormattingEnabled = true;
            this.cbTeamHome.Items.AddRange(new object[] {
            "Arizona Cardinals",
            "Atlanta Falcons",
            "Baltimore Ravens",
            "Buffalo Bills",
            "Carolina Panthers",
            "Chicago Bears",
            "Cincinnati Bengals",
            "Cleveland Browns",
            "Dallas Cowboys",
            "Denver Broncos",
            "Detroit Lions",
            "Green Bay Packers",
            "Houston Texans",
            "Indianapolis Colts",
            "Jacksonville Jaguars",
            "Kansas City Chiefs",
            "Los Angeles Chargers",
            "Los Angeles Rams",
            "Miami Dolphins",
            "Minnesota Vikings",
            "New England Patriots",
            "New Orleans Saints",
            "New York Giants",
            "New York Jets",
            "Oakland Raiders",
            "Philadelphia Eagles",
            "Pittsburgh Steelers",
            "San Francisco 49ers",
            "Seattle Seahawks",
            "Tampa Bay Buccaneers",
            "Tennessee Titans",
            "Washington Redskins"});
            this.cbTeamHome.Location = new System.Drawing.Point(340, 84);
            this.cbTeamHome.Name = "cbTeamHome";
            this.cbTeamHome.Size = new System.Drawing.Size(241, 21);
            this.cbTeamHome.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 536);
            this.Controls.Add(this.cbTeamHome);
            this.Controls.Add(this.lbAwayTeam);
            this.Controls.Add(this.btStartAnalysis);
            this.Controls.Add(this.cbTeamAway);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeamAway;
        private System.Windows.Forms.Button btStartAnalysis;
        private System.Windows.Forms.Label lbAwayTeam;
        private System.Windows.Forms.ComboBox cbTeamHome;
    }
}

