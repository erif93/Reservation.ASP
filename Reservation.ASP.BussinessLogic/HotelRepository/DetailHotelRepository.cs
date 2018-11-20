using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.Common.Interfaces.Hotelku.Application;
using Reservation.ASP.DataAccess.Context;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.BussinessLogic.HotelRepository
{
    public class DetailHotelRepository : IDetailHotelRepository
    {
        BaseContext context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getDetailHotel = Get(id);
            getDetailHotel.Delete();
            context.Entry(getDetailHotel).State = System.Data.Entity.EntityState.Modified;
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            throw new NotImplementedException();
        }

        public List<DetailHotel> Get()
        {
            return context.DetailHotels.Where(x => x.IsDelete.Equals(false)).ToList();
            throw new NotImplementedException();
           
        }

        public DetailHotel Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            DetailHotel detailhotel = context.DetailHotels.SingleOrDefault(x => x.Id == id);
            if (detailhotel == null)
            {
                Console.Write("Facility has not value");
            }
            return detailhotel;
            throw new NotImplementedException();
        }

        public bool Insert(DetailHotelParam _detailhotelparam)
        {
            var push = new DetailHotel(_detailhotelparam);
            context.DetailHotels.Add(push);
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            throw new NotImplementedException();
        }

        public bool Update(DetailHotelParam _detailhotelparam)
        {
            var getDetailHotel = Get(_detailhotelparam.Id);
            getDetailHotel.Update(_detailhotelparam);
            context.Entry(getDetailHotel).State = System.Data.Entity.EntityState.Modified;
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            throw new NotImplementedException();
        }
    }
}
