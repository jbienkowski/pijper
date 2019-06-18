using System.Collections.Generic;
using Pijper.Models.Station;
using LiteDB;

namespace Pijper.Data
{
    public class DatabaseManager
    {
        // Constructor
        public DatabaseManager() { }

        public IEnumerable<StationNetworkModel> GetStationMetadata()
        {
            using (var ctx = new LiteDatabase(@"filename=Pijper.db;mode=Exclusive"))
            {
                var stationMeta = ctx.GetCollection<StationNetworkModel>("stations");
                return stationMeta.Find(n => n.Code == "NL");
            }
        }
    }
}