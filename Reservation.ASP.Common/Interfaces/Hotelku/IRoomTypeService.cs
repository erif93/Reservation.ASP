using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku
{
   public interface IRoomTypeService
    {
        List<RoomType> Get();
        RoomType Get(int? id);
        bool Insert(RoomTypeParam _roomtypeparam);
        bool Update(RoomTypeParam _roomtypeparam);
        bool Delete(int? id);
    }
}
