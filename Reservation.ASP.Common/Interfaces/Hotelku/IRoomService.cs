using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku
{
  public interface IRoomService
    {
        List<Room> Get();
        Room Get(int? id);
        bool Insert(RoomParam _roomparam);
        bool Update(RoomParam _roomparam);
        bool Delete(int? id);
    }
}
