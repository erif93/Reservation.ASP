using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku.Application
{
   public interface IHotelRepository
    {
        List<Hotel> Get();
        Hotel Get(int? id);
        bool Insert(HotelParam _hotelparam);
        bool Update(HotelParam _hotelparam);
        bool Delete(int? id);
    }
}
