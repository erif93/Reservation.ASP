using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku
{
   public interface IVillageService
    {
        List<Village> Get();
        Village Get(int? id);
        bool Insert(VillageParam _villageparam);
        bool Update(VillageParam _villageparam);
        bool Delete(int? id);
    }
}
