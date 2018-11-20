using Reservation.ASP.Common.Interfaces.Kereta.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.ASP.DataAccess.Models;
using Reservation.ASP.DataAccess.Param;
using Reservation.ASP.DataAccess.Context;
using System.Data.Entity;

namespace Reservation.ASP.BussinessLogic.Repository.Kereta.Repository
{
    public class ChairRepository : IChairRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getChair = _context.Chairs.Find(id);
            getChair.Delete();
            _context.Entry(getChair).State = EntityState.Modified;
            var result = _context.SaveChanges();
            //_context.SaveCanges()==jumlah result yang terupdate
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Chair> Get()
        {
            var c = _context.Chairs.Where(x => x.IsDelete.Equals(false)).ToList();
            return c;
        }

        public Chair Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Chair chair = _context.Chairs.SingleOrDefault(x => x.Id == id);
            if (chair == null)
            {
                Console.Write("Supplier has not value");
            }
            return chair;
        }

        public bool Insert(ChairParam _chairparam)
        {
            var push = new Chair(_chairparam);
            _context.Chairs.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(ChairParam _chairparam)
        {
            var getChair = Get(_chairparam.Id);
            getChair.Update(_chairparam);
            _context.Entry(getChair).State = EntityState.Modified;
            var result = _context.SaveChanges();
            //_context.SaveCanges()==jumlah result yang terupdate
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
