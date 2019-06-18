using System.Collections.Generic;
using Pijper.Models.Station;
using LiteDB;

namespace Pijper.Data {
    public class DatabaseManager {
        // ctor
        public DatabaseManager() {

        }

        public IEnumerable<StationModel> GetStationMetadata() {
            using (var db = new LiteDatabase(@"filename=Pijper.db;mode=Exclusive")) {
                var stationMeta = db.GetCollection<StationModel>("stations");
                return stationMeta.Find(n => n.NetworkCode == "NL");
            }
        }
    }
}