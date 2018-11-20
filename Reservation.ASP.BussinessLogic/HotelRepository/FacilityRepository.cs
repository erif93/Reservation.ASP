using System;
using System.Collections.Generic;
using System.Linq;
using Reservation.ASP.Common.Interfaces.Hotelku.Application;
using Reservation.ASP.DataAccess.Context;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;

namespace Reservation.ASP.BussinessLogic.HotelRepository
{
    public class FacilityRepository : IFacilityRepository
    {
        BaseContext context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getFacility = Get(id);
            getFacility.Delete();
            context.Entry(getFacility).State = System.Data.Entity.EntityState.Modified;
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            throw new NotImplementedException();
        }

        public List<DataAccess.Models.Facility> Get()
        {
            return context.Facilities.Where(x => x.IsDelete.Equals(false)).ToList();
            throw new NotImplementedException();
          
        }

        public DataAccess.Models.Facility Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Facility facility = context.Facilities.SingleOrDefault(x => x.Id == id);
            if (facility == null)
            {
                Console.Write("Facility has not value");
            }
            return facility;
            
        }

        public bool Insert(FacilityParam _facilityparam)
        {
            var push = new Facility(_facilityparam);
            context.Facilities.Add(push);
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
            throw new NotImplementedException();
        }

        public bool Update(FacilityParam _facilityparam)
        {
            var getFacility = Get(_facilityparam.Id);
            getFacility.Update(_facilityparam);
            context.Entry(getFacility).State = System.Data.Entity.EntityState.Modified;
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
