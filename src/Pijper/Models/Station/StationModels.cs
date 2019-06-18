using System;
using System.Collections.Generic;

namespace Pijper.Models.Station {
    public class StationQueryModel {
        private Dictionary<string, Microsoft.Extensions.Primitives.StringValues> _query;

        #region Properties
        // Temporal Constraints
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartBefore { get; set; }
        public string StartAfter { get; set; }
        public string EndBefore { get; set; }
        public string EndAfter { get; set; }
        // SEED Identifiers
        public string Network { get; set; }
        public string Station { get; set; }
        public string Location { get; set; }
        public string Channel { get; set; }
        // Rectangular Spatial Selection
        public string MinLatitude { get; set; }
        public string MaxLatitude { get; set; }
        public string MinLongitude { get; set; }
        public string MaxLongitude { get; set; }
        // Circular Spatial Selection
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string MaxRadius { get; set; }
        public string MinRadius { get; set; }
        // Request Options
        public string Level { get; set; }
        public string IncludeRestricted { get; set; }
        #endregion

        // ctor
        public StationQueryModel(Dictionary<string, Microsoft.Extensions.Primitives.StringValues> query) {
            _query = query;
            Network = ProcessParameter("network");
            Station = ProcessParameter("station");
        }

        private string ProcessParameter(string parameterName) {
            return (_query.ContainsKey(parameterName) 
            ? _query[parameterName] 
            : new Microsoft.Extensions.Primitives.StringValues(String.Empty));
        }
    }

    public class StationModel {
        #region Properties
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string NetworkCode { get; set; }
        public string NetworkYear { get; set; }
        public string Station { get; set; }
        public string Payload { get; set; }
        #endregion

        // ctor
        public StationModel() {
            Created = DateTime.Now;
        }
    }
}