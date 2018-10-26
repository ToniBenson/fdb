using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDB_Analysis.code.data
{
    /// <summary>
    /// This class takes the raw html code, extracts the data and returns a memory structure with the extracted data
    /// </summary>
    class DataExtractor  
    {
        private Dictionary<String, TeamData> oTeamStats = new Dictionary<String, TeamData>();
        public Dictionary<String, TeamData> readTeamStats(String sOffenseFile, String sDefenseFile)
        {


            // read offense Data
            readOffenseData(sOffenseFile);

            // read defense data
            readDefenseData(sDefenseFile);

            return oTeamStats;
        }

        private void readOffenseData (String sFilePath)
        {
            String sOffenseData;
            StreamReader streamReader = new StreamReader(sFilePath, Encoding.UTF8);
            sOffenseData = streamReader.ReadToEnd();
            int iStartIndex = sOffenseData.IndexOf("<tbody>");
            int iEndIndex = sOffenseData.IndexOf("</tbody>");
            sOffenseData = sOffenseData.Substring(iStartIndex, iEndIndex-iStartIndex);

            iStartIndex = sOffenseData.IndexOf("<tr");
            while (iStartIndex >= 0)
            {
                iEndIndex = sOffenseData.IndexOf("</tr>", iStartIndex);
                String sTeamdata = sOffenseData.Substring(iStartIndex, iEndIndex - iStartIndex);
                iStartIndex = sOffenseData.IndexOf("<tr", iEndIndex+1);

                TeamData oData = new TeamData();
                for (int iCount = 0; iCount < 10;  iCount++)
                {
                    
                    int iTDStart = sTeamdata.IndexOf("<td");
                    int iTDEnd = sTeamdata.IndexOf("</td>");
                    String sData = sTeamdata.Substring(iTDStart, iTDEnd - iTDStart);

                    switch (iCount)
                    {
                        // Teamname
                        case 0:
                            oData.TeamName = readTeamName(sData);
                            break;
                        
                        // Offense Games
                        case 1:
                            oData.OffenseGms = readValue(sData);
                            break;

                        // Offense Points total
                        case 2:
                            oData.OffensePnt = readValue(sData);
                            break;

                        // Offense Points/Game
                        case 3:
                            oData.OffensePntG = readValue(sData);
                            break;

                        // Offense Rushing total
                        case 4:
                            oData.OffenseRsh = readValue(sData);
                            break;

                        // Offense Rushing/Game
                        case 5:
                            oData.OffenseRshG = readValue(sData);
                            break;

                        // Offense Passing total
                        case 6:
                            oData.OffensePss = readValue(sData);
                            break;

                        // Offense Passing/Game
                        case 7:
                            oData.OffensePssG = readValue(sData);
                            break;

                        // Offense Total
                        // Offense Total/Game
                        case 8:
                        case 9:
                            break;

                        default:                            
                            break;
                    }
                    if (iCount < 9) sTeamdata = sTeamdata.Substring(iTDEnd + 5);
                }
                String sTeamName = oData.TeamName;
                oTeamStats.Add(oData.TeamName, oData);                
            }
        }

// TODO (26.10.) -> Defense-Auslese implementieren
// dabei darauf achten, dass die Stats-Objekte schon im Dictonary stehen und dort jeweils die Defense-Werte aktualisiert werden muessen...
        private void readDefenseData(String sFilePath)
        {
            String sDefenseData;

            StreamReader streamReader = new StreamReader(sFilePath, Encoding.UTF8);
            sDefenseData = streamReader.ReadToEnd();
            int iStartIndex = sDefenseData.IndexOf("<tbody>");
            int iEndIndex = sDefenseData.IndexOf("</tbody>");
            sDefenseData = sDefenseData.Substring(iStartIndex, iEndIndex - iStartIndex);

            iStartIndex = sDefenseData.IndexOf("<tr");
            while (iStartIndex >= 0)
            {
                iEndIndex = sDefenseData.IndexOf("</tr>", iStartIndex);
                String sTeamdata = sDefenseData.Substring(iStartIndex, iEndIndex - iStartIndex);
                iStartIndex = sDefenseData.IndexOf("<tr", iEndIndex + 1);
                String sTeamName = readTeamName(sTeamdata);

                TeamData oData = oTeamStats[sTeamName];
                for (int iCount = 0; iCount < 10; iCount++)
                {

                    int iTDStart = sTeamdata.IndexOf("<td");
                    int iTDEnd = sTeamdata.IndexOf("</td>");
                    String sData = sTeamdata.Substring(iTDStart, iTDEnd - iTDStart);

                    switch (iCount)
                    {
                        // Teamname
                        case 0:
                            oData.TeamName = readTeamName(sData);
                            break;

                        // Offense Games
                        case 1:
                            oData.DefenseGms = readValue(sData);
                            break;

                        // Offense Points total
                        case 2:
                            oData.DefensePnt = readValue(sData);
                            break;

                        // Offense Points/Game
                        case 3:
                            oData.DefensePntG = readValue(sData);
                            break;

                        // Offense Rushing total
                        case 4:
                            oData.DefenseRsh = readValue(sData);
                            break;

                        // Offense Rushing/Game
                        case 5:
                            oData.DefenseRshG = readValue(sData);
                            break;

                        // Offense Passing total
                        case 6:
                            oData.DefensePss = readValue(sData);
                            break;

                        // Offense Passing/Game
                        case 7:
                            oData.DefensePssG = readValue(sData);
                            break;

                        // Defense Total
                        // Defense Total/Game
                        case 8:
                        case 9:
                            break;

                        default:
                            break;
                    }
                    if (iCount < 9) sTeamdata = sTeamdata.Substring(iTDEnd + 5);
                }                
                oTeamStats[oData.TeamName] = oData;
            }
        }



        private String readTeamName(String sData)
        {
            String sReturn = "";

            int iStart = sData.IndexOf("<a href=\"/teams/nfl/");
            sReturn = sData.Substring(iStart);
            iStart = sReturn.IndexOf(">");
            sReturn = sReturn.Substring(iStart+1);
            int iEnd = sReturn.IndexOf("</a>");
            sReturn = sReturn.Substring(0, iEnd);
            return sReturn;
        }

        private String readValue(String sData)
        {
            return sData.Substring(4);
        }

    }
}
