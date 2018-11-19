using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface ITrainService
    {
        List<Train> Get();
        Train Get(int? id);
        bool Insert(TrainParam _trainparam);
        bool Update(TrainParam _trainparam);
        bool Delete(int? id);
    }
}
