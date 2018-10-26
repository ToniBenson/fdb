using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDB_Analysis.code.data;

namespace FDB_Analysis.code.fbdController
{
    class FDBController
    {
        private Dictionary<String, TeamData> oTeamStats = new Dictionary<String, TeamData>();

        public void getTeamStats()
        {
            // read html file from the internet
            String sTotalOffense = @"https://www.footballdb.com/stats/teamstat.html?lg=NFL&yr=2018&type=reg&cat=T&group=O&conf=";
            String sTotalDefense = @"https://www.footballdb.com/stats/teamstat.html?lg=NFL&yr=2018&type=reg&cat=T&group=D&conf=";
            // later, not possible to test within coba...

            // readout the file and create a data object
            DataExtractor oFileData = new DataExtractor();
            String sOffenseFile = @"H:\temp\fdb\Offense.htm";
            String sDefenseFile = @"H:\temp\fdb\Defense.htm";
            oTeamStats = oFileData.readTeamStats(sOffenseFile, sDefenseFile);            
        }


        // this method starts a single game analysis with two teams
        public String getGameAnalysis(String sTeamAway, String sTeamHome)
        {
            TeamData tdAway = oTeamStats[sTeamAway];
            TeamData tdHome = oTeamStats[sTeamHome];

            // AwayTeam            
            String sOffense = tdAway.TeamName + "\t-> Points/Game = " + tdAway.OffensePntG + "   Rushing/Game = " + tdAway.OffenseRshG + "   Passing/Game = " + tdAway.OffensePssG + "\n";
            sOffense += tdHome.TeamName + "\t-> Points/Game = " + tdHome.OffensePntG + "   Rushing/Game = " + tdHome.OffenseRshG + "   Passing/Game = " + tdHome.OffensePssG + "\n";
            

            // HomeTeam
            String sDefense = tdAway.TeamName + "\t-> Points/Game = " + tdAway.DefensePntG + "   Rushing/Game = " + tdAway.DefenseRshG + "   Passing/Game = " + tdAway.DefensePssG + "\n";
            sDefense += tdHome.TeamName + "\t-> Points/Game = " + tdHome.DefensePntG + "   Rushing/Game = " + tdHome.DefenseRshG + "   Passing/Game = " + tdHome.DefensePssG + "\n";

            return sOffense + "-------------------------------------------------------------------\n" + sDefense;
        }
    }
}
