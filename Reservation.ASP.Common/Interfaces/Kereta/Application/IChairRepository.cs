using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta.Application
{
    public interface IChairRepository
    {
        List<Chair> Get();
        Chair Get(int? id);
        bool Insert(ChairParam _chairparam);
        bool Update(ChairParam _chairparam);
        bool Delete(int? id);
    }
}
