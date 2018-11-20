using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku
{
   public interface IDetailHotelService
    {
        List<DetailHotel> Get();
        DetailHotel Get(int? id);
        bool Insert(DetailHotelParam _detailhotelparam);
        bool Update(DetailHotelParam _detailhotelparam);
        bool Delete(int? id);
    }
}
