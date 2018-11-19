using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface IRateService
    {
        List<Rate> Get();
        Rate Get(int? id);
        bool Insert(RateParam _rateparam);
        bool Update(RateParam _rateparam);
        bool Delete(int? id);
    }
}
