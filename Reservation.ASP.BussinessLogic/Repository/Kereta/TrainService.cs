using Reservation.ASP.Common.Interfaces.Kereta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;
using Reservation.ASP.Common.Interfaces.Kereta.Application;

namespace Reservation.ASP.BussinessLogic.Repository.Kereta
{
    public class TrainService : ITrainService
    {
        private readonly ITrainRepository _itrainrepository;
        bool status = false;
        public TrainService()
        {

        }
        public TrainService(ITrainRepository itrainrepository)
        {
            this._itrainrepository = itrainrepository;
        }
        public bool Delete(int? id)
        {
            return _itrainrepository.Delete(id);
        }

        public List<Train> Get()
        {
            return _itrainrepository.Get();
        }

        public Train Get(int? id)
        {
            //var supRepo.Get(id);
            return _itrainrepository.Get(id);
        }

        public bool Insert(TrainParam _trainparam)
        {
            return _itrainrepository.Insert(_trainparam);
        }

        public bool Update(TrainParam _trainparam)
        {
            return _itrainrepository.Update(_trainparam);
        }
    }
}
