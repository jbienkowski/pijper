using Pijper.Models.Station;
using Pijper.Fdsn;

namespace Pijper.Controllers.Station
{
    public class StationResponseBuilder
    {
        #region Properties
        private StationQueryModel _stationQuery;
        private FdsnStationXmlModel _response;
        #endregion

        // Constructor
        public StationResponseBuilder(StationQueryModel sqm)
        {
            _stationQuery = sqm;
            _response = new FdsnStationXmlModel();
            var da = new FdsnRouter();
        }
    }
}