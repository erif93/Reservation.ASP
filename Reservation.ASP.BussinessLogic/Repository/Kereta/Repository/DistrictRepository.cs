using Reservation.ASP.Common.Interfaces.Kereta.Application;
using Reservation.ASP.DataAccess.Context;
using Reservation.ASP.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ASP.BussinessLogic.Repository.Kereta.Repository
{
    public class DistrictRepository:IDistrictRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        public List<District> Get()
        {
            var c = _context.Districts.Where(x => x.IsDelete.Equals(false)).ToList();
            return c;
        }

        public District Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            District district = _context.Districts.SingleOrDefault(x => x.Id == id);
            if (district == null)
            {
                Console.Write("Supplier has not value");
            }
            return district;
        }
    }
}
