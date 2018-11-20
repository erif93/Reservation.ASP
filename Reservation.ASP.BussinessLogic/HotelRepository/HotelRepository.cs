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
    public class HotelRepository : IHotelRepository
    {
        BaseContext context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getHotel = Get(id);
            getHotel.Delete();
            context.Entry(getHotel).State = System.Data.Entity.EntityState.Modified;
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Hotel> Get()
        {
            return context.Hotels.Where(x => x.IsDelete.Equals(false)).ToList();
        }

        public Hotel Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Hotel hotel = context.Hotels.SingleOrDefault(x => x.Id == id);
            if (hotel == null)
            {
                Console.Write("Hotel has not value");
            }
            return hotel;
        }

        public bool Insert(HotelParam _hotelparam)
        {
            var push = new Hotel(_hotelparam);
            context.Hotels.Add(push);
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            throw new NotImplementedException();
        }

        public bool Update(HotelParam _hotelparam)
        {
            var getHotel = Get(_hotelparam.Id);
            getHotel.Update(_hotelparam);
            context.Entry(getHotel).State = System.Data.Entity.EntityState.Modified;
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
