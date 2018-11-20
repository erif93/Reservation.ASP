using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku.Application
{
   public interface IHotelReservationRepository
    {
        List<HotelReservation> Get();
        HotelReservation Get(int? id);
        bool Insert(HotelReservationParam _hotelreservationparam);
        bool Update(HotelReservationParam _hotelreservationparam);
        bool Delete(int? id);
    }
}
