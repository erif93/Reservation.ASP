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
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _ihotelrepository;

        public HotelService() { }
        public HotelService(IHotelRepository ihotelrepository)
        {
            this._ihotelrepository = ihotelrepository;
        }
        public bool Delete(int? id)
        {
            return _ihotelrepository.Delete(id);
            throw new NotImplementedException();
        }

        public List<Hotel> Get()
        {
            return _ihotelrepository.Get();
            throw new NotImplementedException();
        }

        public Hotel Get(int? id)
        {
            return _ihotelrepository.Get(id);
            throw new NotImplementedException();
        }

        public bool Insert(HotelParam _hotelparam)
        {
            return _ihotelrepository.Insert(_hotelparam);
            throw new NotImplementedException();
        }

        public bool Update(HotelParam _hotelparam)
        {
            return _ihotelrepository.Update(_hotelparam);
            throw new NotImplementedException();
        }
    }
}
