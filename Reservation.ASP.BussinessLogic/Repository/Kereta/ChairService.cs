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
    public class ChairService : IChairService
    {
        private readonly IChairRepository _ichairrepository;
        bool status = false;
        public ChairService()
        {

        }
        public ChairService(IChairRepository ichairrepository)
        {
            this._ichairrepository = ichairrepository;
        }
        public bool Delete(int? id)
        {
            return _ichairrepository.Delete(id);
        }

        public List<Chair> Get()
        {
            return _ichairrepository.Get();
        }

        public Chair Get(int? id)
        {
            //var supRepo.Get(id);
            return _ichairrepository.Get(id);
        }

        public bool Insert(ChairParam _chairparam)
        {
            return _ichairrepository.Insert(_chairparam);
        }

        public bool Update(ChairParam _chairparam)
        {
            return _ichairrepository.Update(_chairparam);
        }
    }
}
