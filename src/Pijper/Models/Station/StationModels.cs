using System;
using System.Collections.Generic;

namespace Pijper.Models.Station
{
    public class StationQueryModel
    {
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

        // Constructor
        public StationQueryModel(Dictionary<string, Microsoft.Extensions.Primitives.StringValues> query)
        {
            _query = query;
            StartTime = ProcessParameter("starttime");
            EndTime = ProcessParameter("endtime");
            StartBefore = ProcessParameter("startbefore");
            StartAfter = ProcessParameter("startafter");
            EndBefore = ProcessParameter("endbefore");
            EndAfter = ProcessParameter("endafter");
            Network = ProcessParameter("network");
            Station = ProcessParameter("station");
            Location = ProcessParameter("location");
            Channel = ProcessParameter("channel");
            MinLatitude = ProcessParameter("minlatitude");
            MaxLatitude = ProcessParameter("maxlatitude");
            MinLongitude = ProcessParameter("minlongitude");
            MaxLongitude = ProcessParameter("maxlongitude");
            Latitude = ProcessParameter("latitude");
            Longitude = ProcessParameter("longitude");
            MaxRadius = ProcessParameter("maxradius");
            MinRadius = ProcessParameter("minradius");
            Level = ProcessParameter("level");
            IncludeRestricted = ProcessParameter("includerestricted");
        }

        private string ProcessParameter(string parameterName)
        {
            return (
                _query.ContainsKey(parameterName)
                ? _query[parameterName]
                : new Microsoft.Extensions.Primitives.StringValues(String.Empty)
                );
        }
    }

    public class FdsnStationXmlModel
    {
        #region Properties
        public string SchemaVersion { get; private set; }
        public string Source { get; private set; }
        public string Sender { get; private set; }
        public List<StationNetworkModel> Networks { get; set; }
        #endregion

        public FdsnStationXmlModel()
        {
            SchemaVersion = "1.0";
            Source = "Pijper";
            Sender = "ODC";
            Networks = new List<StationNetworkModel>();
        }
    }

    public class StationNetworkModel
    {
        #region Properties
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string Code { get; set; }
        public string StartDate { get; set; }
        public string RestrictedStatus { get; set; }
        public string Description { get; set; }
        public List<StationStationModel> Stations { get; set; }
        #endregion

        // ctor
        public StationNetworkModel()
        {
            Created = DateTime.Now;
            Stations = new List<StationStationModel>();
        }
    }

    public class StationStationModel
    {
        public Guid Id { get; set; }
        public string Payload { get; set; }
        public List<StationChannelModel> Channels { get; set; }

        public StationStationModel()
        {
            Channels = new List<StationChannelModel>();
        }
    }

    public class StationChannelModel
    {
        public Guid Id { get; set; }
        public string Payload { get; set; }
        public List<StationResponseModel> Responses { get; set; }

        public StationChannelModel()
        {
            Responses = new List<StationResponseModel>();
        }
    }

    public class StationResponseModel
    {
        public Guid Id { get; set; }
        public string Payload { get; set; }
    }
}