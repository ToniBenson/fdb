using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace FDB_Analysis.code.tcp
{
    /// <summary>
    /// this class reads the stats from footballdb.com and delivers the whole apage content 
    /// </summary>
    /// 



    class DataReader
    {
        // url's
        String sTotalOffense = @"https://www.footballdb.com/stats/teamstat.html?lg=NFL&yr=2018&type=reg&cat=T&group=O&conf=";
        String sTotalDefense = @"https://www.footballdb.com/stats/teamstat.html?lg=NFL&yr=2018&type=reg&cat=T&group=D&conf=";


        public async Task<string> getStats(String sCategory)
        {
            // Switch for the category

            // read html data
            HttpClient client = new HttpClient();
            String responseString = await client.GetStringAsync(sTotalOffense);

            // return data
            return responseString;
        }
    }
}
