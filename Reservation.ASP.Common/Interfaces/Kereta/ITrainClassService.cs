using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.Common.Interfaces.Kereta
{
    public interface ITrainClassService
    {
        List<TrainClass> Get();
        TrainClass Get(int? id);
        bool Insert(TrainClassParam _trainclassparam);
        bool Update(TrainClassParam _trainclassparam);
        bool Delete(int? id);
    }
}
