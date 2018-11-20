using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku
{
   public interface IRegencyService
    {
        List<Regency> Get();
        Regency Get(int? id);
        bool Insert(RegencyParam _regencyparam);
        bool Update(RegencyParam _regencyparam);
        bool Delete(int? id);
    }
}
