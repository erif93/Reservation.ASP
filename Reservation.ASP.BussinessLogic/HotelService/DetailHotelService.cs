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
    public class DetailHotelService : IDetailHotelService
    {
        private readonly IDetailHotelRepository _idetailhotelrepository;
        public DetailHotelService() { }

        public DetailHotelService(IDetailHotelRepository idetailhotelrepository)
        {
            this._idetailhotelrepository = idetailhotelrepository;
        }
        public bool Delete(int? id)
        {
            return _idetailhotelrepository.Delete(id);
            throw new NotImplementedException();
        }

        public List<DetailHotel> Get()
        {
            return _idetailhotelrepository.Get();
            throw new NotImplementedException();
        }

        public DetailHotel Get(int? id)
        {
            return _idetailhotelrepository.Get(id);
            throw new NotImplementedException();
        }

        public bool Insert(DetailHotelParam _detailhotelparam)
        {
            return _idetailhotelrepository.Insert(_detailhotelparam);
            throw new NotImplementedException();
        }

        public bool Update(DetailHotelParam _detailhotelparam)
        {
            return _idetailhotelrepository.Update(_detailhotelparam);
            throw new NotImplementedException();
        }
    }
}
