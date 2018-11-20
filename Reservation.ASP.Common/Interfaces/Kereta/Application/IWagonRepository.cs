using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ASP.Common.Interfaces.Kereta.Application
{
    public interface IWagonRepository
    {
        List<Wagon> Get();
        Wagon Get(int? id);
        bool Insert(WagonParam _wagonparam);
        bool Update(WagonParam _wagonparam);
        bool Delete(int? id);
    }
}
