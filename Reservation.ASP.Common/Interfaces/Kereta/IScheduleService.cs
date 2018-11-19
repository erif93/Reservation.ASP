using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface IScheduleService
    {
        List<Schedule> Get();
        Schedule Get(int? id);
        bool Insert(ScheduleParam _scheduleparam);
        bool Update(ScheduleParam _scheduleparam);
        bool Delete(int? id);
    }
}
