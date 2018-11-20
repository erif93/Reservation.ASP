using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku.Application
{
  public interface IDistrictRepository
    {
        List<District> Get();
        District Get(int? id);
        bool Insert(DistrictParam _districtparam);
        bool Update(DistrictParam _districtparam);
        bool Delete(int? id);
    }
}
