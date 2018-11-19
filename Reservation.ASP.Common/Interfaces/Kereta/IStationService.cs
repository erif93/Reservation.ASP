using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface IStationService
    {
        List<Station> Get();
        Station Get(int? id);
        bool Insert(StationParam _stationparam);
        bool Update(StationParam _stationparam);
        bool Delete(int? id);
    }
}
