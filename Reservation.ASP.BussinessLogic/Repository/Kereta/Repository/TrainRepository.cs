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
    public class TrainRepository : ITrainRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        public bool Delete(int? id)
        {
            var getTrain = _context.Trains.Find(id);
            getTrain.Delete();
            _context.Entry(getTrain).State = EntityState.Modified;
            var result = _context.SaveChanges();
            //_context.SaveCanges()==jumlah result yang terupdate
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Train> Get()
        {
            var c = _context.Trains.Where(x => x.IsDelete.Equals(false)).ToList();
            return c;
        }

        public Train Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Train train = _context.Trains.SingleOrDefault(x => x.Id == id);
            if (train == null)
            {
                Console.Write("Supplier has not value");
            }
            return train;
        }

        public bool Insert(TrainParam _trainparam)
        {
            var push = new Train(_trainparam);
            _context.Trains.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(TrainParam _trainparam)
        {
            var getTrain = Get(_trainparam.Id);
            getTrain.Update(_trainparam);
            _context.Entry(getTrain).State = EntityState.Modified;
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
