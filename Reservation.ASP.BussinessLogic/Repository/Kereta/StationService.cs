using Reservation.ASP.Common.Interfaces.Kereta;
using Reservation.ASP.Common.Interfaces.Kereta.Application;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ASP.BussinessLogic.Repository.Kereta
{
    public class StationService : IStationService
    {
        private readonly IStationRepository _istationrepository;
        bool status = false;
        public StationService()
        {

        }
        public StationService(IStationRepository istationrepository)
        {
            this._istationrepository = istationrepository;
        }
        public bool Delete(int? id)
        {
            return _istationrepository.Delete(id);
        }

        public List<Station> Get()
        {
            return _istationrepository.Get();
        }

        public Station Get(int? id)
        {
            //var supRepo.Get(id);
            return _istationrepository.Get(id);
        }

        public bool Insert(StationParam _stationparam)
        {
            return _istationrepository.Insert(_stationparam);
        }

        public bool Update(StationParam _stationparam)
        {
            return _istationrepository.Update(_stationparam);
        }
    }
}
