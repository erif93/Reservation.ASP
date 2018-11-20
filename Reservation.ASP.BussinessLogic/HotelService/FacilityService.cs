using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Common.Interfaces.Hotelku;
using Reservation.ASP.Common.Interfaces.Hotelku.Application;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.BussinessLogic.HotelService
{
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _ifacilityrepository;
        bool status = false;

        public FacilityService() { }

        public FacilityService(IFacilityRepository ifacilityrepository)
        {
            this._ifacilityrepository = ifacilityrepository;
        }
        public bool Delete(int? id)
        {
            return _ifacilityrepository.Delete(id);

        }

        public List<Facility> Get()
        {
            return _ifacilityrepository.Get();
           
        }

        public Facility Get(int? id)
        {
            return _ifacilityrepository.Get(id);
        }

        public bool Insert(FacilityParam _facilityparam)
        {
            return _ifacilityrepository.Insert(_facilityparam);
        }

        public bool Update(FacilityParam _facilityparam)
        {
            return _ifacilityrepository.Update(_facilityparam);
        }
    }
}
