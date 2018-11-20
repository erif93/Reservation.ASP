using Reservation.ASP.Common.Interfaces.Kereta;
using Reservation.ASP.Common.Interfaces.Kereta.Application;
using Reservation.ASP.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ASP.BussinessLogic.Repository.Kereta
{
    public class DistrictService:IDistrictService
    {
        private readonly IDistrictRepository _idistrictrepository;
        bool status = false;
        public DistrictService()
        {

        }
        public DistrictService(IDistrictRepository idistrictrepository)
        {
            this._idistrictrepository = idistrictrepository;
        }
        public List<District> Get()
        {
            return _idistrictrepository.Get();
        }

        public District Get(int? id)
        {
            //var supRepo.Get(id);
            return _idistrictrepository.Get(id);
        }
    }
}
