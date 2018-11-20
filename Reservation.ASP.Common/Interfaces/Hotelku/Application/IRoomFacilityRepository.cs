using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku.Application
{
   public interface IRoomFacilityRepository
    {
        List<RoomFacility> Get();
        RoomFacility Get(int? id);
        bool Insert(RoomFacilityParam _roomfacilityparam);
        bool Update(RoomFacilityParam _roomfacilityparam);
        bool Delete(int? id);
    }
}
