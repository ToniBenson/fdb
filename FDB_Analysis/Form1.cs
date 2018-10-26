using FDB_Analysis.code.fbdController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDB_Analysis
{
    public partial class Form1 : Form
    {
        FDBController myController = new FDBController();
        public Form1()
        {
            InitializeComponent();

            String sTeamAway = "Chicago Bears";
            String sTeamHome = "New York Jets";
            myController.getTeamStats();    
            lbAwayTeam.Text = "stats loaded!";
        }

        private void btStartAnalysis_Click(object sender, EventArgs e)
        {            
            String sTeamAway = cbTeamAway.SelectedItem.ToString();
            String sTeamHome = cbTeamHome.SelectedItem.ToString();
            lbAwayTeam.Text = myController.getGameAnalysis(sTeamAway, sTeamHome);
        }
    }

    //https://github.com/ToniBenson/fdb.git

}
