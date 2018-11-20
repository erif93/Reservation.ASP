using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku
{
   public interface IProvinceService
    {
        List<Province> Get();
        Province Get(int? id);
        bool Insert(ProvinceParam _provinceparam);
        bool Update(ProvinceParam _provinceparam);
        bool Delete(int? id);
    }
}
