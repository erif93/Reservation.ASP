using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface ITrainReservationService
    {
        List<TrainReservation> Get();
        TrainReservation Get(int? id);
        bool Insert(TrainReservationParam _trainreservationparam);
        bool Update(TrainReservationParam _trainreservationparam);
        bool Delete(int? id);
    }
}
