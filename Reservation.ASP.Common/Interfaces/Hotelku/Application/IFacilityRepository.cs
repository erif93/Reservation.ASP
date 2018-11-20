using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Hotelku.Application
{
   public interface IFacilityRepository
    {
        List<Facility> Get();
        Facility Get(int? id);
        bool Insert(FacilityParam _facilityparam);
        bool Update(FacilityParam _facilityparam);
        bool Delete(int? id);
    }
}
